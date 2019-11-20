using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypingGame
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Word.Enabled = false;
        }

        int score = 0;
        int Timeleft = 121;

        public void ResetWord()
        {
            Word.Text = string.Empty;
        }
        private void CheckAnswer(object sender, KeyEventArgs e)
        {
            if (GivenWord.Text == Word.Text && e.KeyCode == Keys.Enter)
            {
                score++;
                Score.Text = "Score : " + score;
            }
            if (e.KeyCode == Keys.Enter)
            {
                ResetWord();
            }

        }
        public Form FormToShowOnClosing { get; set; }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (null != FormToShowOnClosing)
                FormToShowOnClosing.Show();
        }

        private void TimerCount(object sender, EventArgs e)
        {
            Timeleft--;
            if (Timeleft == 0)

                Timer.Stop();
            TimeLeft.Text = "Tijd over : " + Timeleft.ToString();

        }

        private void StartTest(object sender, EventArgs e)
        {
            Timer.Start();
            Timer.Tick += new EventHandler(TimerCount);
            Timer.Interval = 1000;
            Timer.Start();
            Start.Enabled = false;
            Word.Enabled = true;
        }
    }
}
