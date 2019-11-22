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
        List<string> Woorden = new List<string>();
        Random rnd = new Random();

        int Score = 0;

        public TimedTyping()
        {
            InitializeComponent();
            Word.Enabled = false;

            Woorden.Add("groenten");
            Woorden.Add("tevreden");
            Woorden.Add("bruiloft");
            Woorden.Add("samen");
            Woorden.Add("zeven");
            Woorden.Add("qualiteit");
            Woorden.Add("medewerker");
            Woorden.Add("controle");
            Woorden.Add("kapot");
            Woorden.Add("nederlaag");
        }
        public void EnterWords()
        {
            GenerateRandomWord();
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
                EnterWords();
            }
        }
        int counter = 60;
        private void TimerCount(object sender, EventArgs e)
        {
            counter--;
            TimeLeft.Text = ("Tijd over : ") + counter.ToString();
            if (counter == 0)
            {
                Timer.Stop();
                MessageBox.Show("Tijd is op");
                Score = 0;
                Start.Enabled = true;
                Start.Text = "Restart";
            }
        }
        public void StartTest(object sender, EventArgs e)
        {
            int counter = 60;
            Timer.Tick += new EventHandler(TimerCount);
            Timer.Interval = 1000;
            Timer.Start();
            TimeLeft.Text = ("Tijd over : ") + counter.ToString();
            Word.Enabled = true;
            Start.Enabled = false;
            GenerateRandomWord();
        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartScreen asd = new StartScreen();
            asd.GoToStartScreen = this;
            asd.Show();
        }
        public Form GoToTimedTyping { get; set; }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (null != GoToTimedTyping)
                GoToTimedTyping.Show();
        }
        public void GenerateRandomWord()
        {
            int Words = rnd.Next(Woorden.Count);
            Convert.ToInt32(Words);
            GivenWord.Text = Woorden[Words];
        }  
    }
}
