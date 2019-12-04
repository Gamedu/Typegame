using System;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace TypingGame
{
    public partial class SandboxTyping : Form
    {
        readonly WordGenerator WordsFree = new WordGenerator();
        SoundPlayer SandboxMusic = new SoundPlayer();
        private int Score;
        public SandboxTyping()
        {
            InitializeComponent();
            CorrectScore.Text = "0";

            foreach (var button in this.Controls.OfType<Button>())
            {
                button.TabStop = false;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
            }
            SandboxMusic.SoundLocation = "SandboxMusic.wav";
            UnmuteButton.Visible = false;
        }
        private void SandboxTyping_Load(object sender, EventArgs e)
        {
            GivenWord.Text = WordsFree.GenerateRandomWord();
            WordTimer.Start();
            SandboxMusic.PlayLooping();
        }
        private void WordTimer_Tick(object sender, EventArgs e)
        {
            if (GivenWord.Text.Length == Word.TextLength)
            {
                if (GivenWord.Text == Word.Text)
                {
                    Score++;
                    CorrectScore.Text = Score.ToString();
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
            GivenWord.Text = WordsFree.GenerateRandomWord();
        }
        public Form GoToSandbox { get; set; }
        private void Return_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartScreen asd = new StartScreen();
            asd.GoToStartScreen = this;
            asd.Show();
        }

        private void UnmuteButton_Click(object sender, EventArgs e)
        { 
            SandboxMusic.PlayLooping();
            UnmuteButton.Visible = false;
            MuteButton.Visible = true;
        }

        private void MuteButton_Click(object sender, EventArgs e)
        {
            SandboxMusic.Stop();
            MuteButton.Visible = false;
            UnmuteButton.Visible = true;
        }

    }
}

