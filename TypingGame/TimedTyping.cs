using System;
using System.Linq;
using System.Windows.Forms;

namespace TypingGame
{
    public partial class TimedTyping : Form
    {
        readonly WordGenerator WordsTime = new WordGenerator();

        private int Score;
        private int counter = 60;

        public TimedTyping()
        {
            InitializeComponent();
            Timer.Tick += new EventHandler(TimerCount);
            Word.Enabled = false;

            foreach (var button in this.Controls.OfType<Button>())
            {
                button.TabStop = false;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
            }
        }
        public void StartTest(object sender, EventArgs e)
        {
            var counter = 60;

            Timer.Start();
            WordTimer.Start();
            
            Word.Enabled = true;
            Start.Enabled = false;
            
            GivenWord.Text = WordsTime.GenerateRandomWord();
            TimeLeft.Text = counter.ToString();
        }
        private void TimerCount(object sender, EventArgs e)
        {
            counter--;
            TimeLeft.Text = counter.ToString();
            if (counter == 0)
            {
                Timer.Stop();

                Score = 0;
                counter = 60;

                Start.Enabled = true;
                Word.Enabled = false;

                GivenWord.Text = "";
                MessageBox.Show("Tijd is op");
            }
        }
        private void CheckWord(object sender, EventArgs e)
        {
            if (GivenWord.Text.Length == Word.TextLength)
            {
                if (WordsTime.currentword == Word.Text)
                {
                    Score++;
                    Points.Text = Score.ToString();
                    ClearWords();
                }
                else
                {
                    ClearWords();
                }
            }
        }
        public void ClearWords()
        {
            Word.Text = string.Empty;
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
    }
}
