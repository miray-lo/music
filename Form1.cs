using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace WAV音效檔播放器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            ofdWAVFile.Filter = "WAV Files(*.wav)|*.wav";
            if (ofdWAVFile.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = ofdWAVFile.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer player1 = new SoundPlayer();
            player1.SoundLocation = txtPath.Text;
            player1.Load();
            player1.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SoundPlayer player2 = new SoundPlayer(txtPath.Text);
            player2.PlayLooping();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            FileStream fsWAV = new FileStream(txtPath.Text, FileMode.Open);
            SoundPlayer player3 = new SoundPlayer(fsWAV);
            player3.Stop();
            fsWAV.Close();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("確定要關閉應用程式嗎?", "關閉確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}