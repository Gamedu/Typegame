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
        WordGenerator WordsTime = new WordGenerator();

        private int Score;
        int counter = 60;

        public TimedTyping()
        {
            InitializeComponent();
            Word.Enabled = false;
            foreach (var button in this.Controls.OfType<Button>())
            {
                button.TabStop = false;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
            }
        }
        public void EnterWords()
        {
            Word.Text = string.Empty;
            GivenWord.Text = WordsTime.GenerateRandomWord();
        }
        private void TimerCount(object sender, EventArgs e)
        {
            counter--;
            TimeLeft.Text = counter.ToString();
            if (counter == 0)
            {
                Timer.Stop();
                MessageBox.Show("Tijd is op");
                Score = 0;
                Start.Enabled = true;
            }
        }
        public void StartTest(object sender, EventArgs e)
        {
            int counter = 60;
            Timer.Tick += new EventHandler(TimerCount);
            Timer.Start();
            WordTimer.Start();
            TimeLeft.Text = counter.ToString();
            Word.Enabled = true;
            Start.Enabled = false;
            GivenWord.Text = WordsTime.GenerateRandomWord();
        }
        private void Return_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartScreen asd = new StartScreen();
            asd.GoToStartScreen = this;
            asd.Show();
            Timer.Stop();
        }
        public Form GoToTimedTyping { get; set; }

        private void WordTimer_Tick(object sender, EventArgs e)
        {
            if (WordsTime.currentword == Word.Text)
            {
                Score++;
                Points.Text = Score.ToString();
                EnterWords();
            }
        }
    }
}
