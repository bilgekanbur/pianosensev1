using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PianoSense
{
    public partial class ResultForm : Form
    {
        public ResultForm(List<string> originalNotes, List<string> playedNotes)
        {
            InitializeComponent();

            // Orijinal notaları listBox1'e ekle
            foreach (var note in originalNotes)
            {
                listBox1.Items.Add(note);
            }

            // Çalınan notaları listBox2'ye ekle
            //foreach (var note in playedNotes)
           // {
                //listBox2.Items.Add(note);
            //}
        }
    }
}
