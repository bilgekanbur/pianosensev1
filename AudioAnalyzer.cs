using NAudio.Wave;
using MathNet.Numerics.IntegralTransforms;
using System.Numerics;
using System.Collections.Generic;


namespace PianoSense
{
    public static class AudioAnalyzer
    {
        public static List<string> AnalyzeRecording(string filePath)
        {
            List<string> results = new List<string>();
            var samplesPerSecond = 44100; // 44.1 kHz
            var samplesPerChunk = samplesPerSecond;

            using (var reader = new AudioFileReader(filePath))
            {
                float[] buffer = new float[samplesPerChunk];
                int samplesRead;
                int second = 1;

                while ((samplesRead = reader.Read(buffer, 0, samplesPerChunk)) > 0)
                {
                    string note = DetectDominantNoteInChunk(buffer);
                    results.Add($"Second {second}: {note}");
                    second++;
                }
            }
            return results;
        }

        public static string DetectDominantNoteInChunk(float[] audioData)
        {
            int length = audioData.Length;
            Complex[] complexData = new Complex[length];

            for (int i = 0; i < length; i++)
            {
                complexData[i] = new Complex(audioData[i], 0);
            }

            Fourier.Forward(complexData, FourierOptions.Matlab);

            double maxMagnitude = 0;
            int dominantIndex = 0;
            for (int i = 0; i < complexData.Length / 2; i++)
            {
                double magnitude = complexData[i].Magnitude;
                if (magnitude > maxMagnitude)
                {
                    maxMagnitude = magnitude;
                    dominantIndex = i;
                }
            }

            double dominantFrequency = (double)dominantIndex * 44100 / audioData.Length;
            return GetNoteFromFrequency(dominantFrequency);
        }

        public static string GetNoteFromFrequency(double frequency)
        {
            if (frequency >= 261.63 && frequency <= 277.18) return "C4";
            if (frequency > 277.18 && frequency <= 293.66) return "C#4";
            if (frequency > 293.66 && frequency <= 311.13) return "D4";
            if (frequency > 311.13 && frequency <= 329.63) return "D#4";
            if (frequency > 329.63 && frequency <= 349.23) return "E4";
            if (frequency > 349.23 && frequency <= 369.99) return "F4";
            // Diğer notaları ekleyin
            return "Unknown";
        }
    }
}
