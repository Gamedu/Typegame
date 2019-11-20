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
    public partial class TimedTyping : Form
    {
        public TimedTyping()
        {
            InitializeComponent();
            Word.Enabled = false;
        }

        int Score = 0;
        int Timeleft = 121;

        public void ResetWord()
        {
            Word.Text = string.Empty;
        }
        private void CheckAnswer(object sender, KeyEventArgs e)
        {
            if (GivenWord.Text == Word.Text && e.KeyCode == Keys.Enter)
            {
                Score++;
                Points.Text = "Punten : " + Score;
            }
            if (e.KeyCode == Keys.Enter)
            {
                ResetWord();
            }

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

        private void Return_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartScreen asd = new StartScreen();
            asd.FormToShowOnClosing3 = this;
            asd.Show();
        }
        public Form FormToShowOnClosing { get; set; }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (null != FormToShowOnClosing)
                FormToShowOnClosing.Show();
        }
    }
}
