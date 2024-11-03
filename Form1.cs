using System;
using System.IO;
using System.Windows.Forms;
using NAudio.Wave;
using System.Collections.Generic;

namespace PianoSense
{
    public partial class Form1 : Form
    {
        private WaveInEvent waveIn;
        private WaveFileWriter waveFile;
        private bool isRecording = false;
        private string filename; // Sınıf düzeyinde tanımlayın

        public Form1()
        {
            InitializeComponent();
        }

        private void starting_record_button_Click(object sender, EventArgs e)
        {
            if (!isRecording)
            {
                StartRecording();
                MessageBox.Show("Kayıt başladı");
            }
        }

        private void stopping_record_button_Click(object sender, EventArgs e)
        {
            if (isRecording)
            {
                StopRecording();
                MessageBox.Show("Kayıt durdu");

                // Kayıt durduktan sonra sonuçları göster
                string originalFilePath = "C:\\Users\\bilge\\OneDrive\\Masaüstü\\bitirmeproje\\PianoSense\\cav_bella.wav";
                string playedFilePath = filename; // filename değişkenini kullanın
                ShowResults(originalFilePath, playedFilePath);
            }
            isRecording = !isRecording;
        }

        private void StartRecording()
        {
            var waveFormat = new WaveFormat(44100, 1); // Mono, 44100 Hz
            waveIn = new WaveInEvent
            {
                WaveFormat = waveFormat
            };
            waveIn.DataAvailable += OnDataAvailable;
            waveIn.RecordingStopped += OnRecordingStopped;

            string songName = textBox1.Text.Replace(" ", "_");
            string selectedDate = dateTimePicker1.Value.ToString("yyyyMMdd");
            string tryingNumber = textBox2.Text;
            filename = Path.Combine(Environment.CurrentDirectory, $"{songName}_{selectedDate}_{tryingNumber}.wav");
            waveFile = new WaveFileWriter(filename, waveIn.WaveFormat);

            waveIn.StartRecording();
            isRecording = true;
        }

        private void OnDataAvailable(object sender, WaveInEventArgs e)
        {
            if (waveFile != null)
            {
                waveFile.Write(e.Buffer, 0, e.BytesRecorded);
                waveFile.Flush();
            }
        }

        private void StopRecording()
        {
            waveIn.StopRecording();
        }

        private void OnRecordingStopped(object sender, StoppedEventArgs e)
        {
            waveIn.Dispose();
            waveFile.Dispose();
            isRecording = false;
        }

        private void ShowResults(string originalFilePath, string playedFilePath)
        {
            // Orijinal şarkı ve çalınan şarkının notalarını analiz et
            List<string> originalNotes = AudioAnalyzer.AnalyzeRecording(originalFilePath);
            List<string> playedNotes = AudioAnalyzer.AnalyzeRecording(playedFilePath);

            // Sonuçları göster
            ResultForm resultForm = new ResultForm(originalNotes, playedNotes);
            resultForm.ShowDialog();
        }
    }
}
