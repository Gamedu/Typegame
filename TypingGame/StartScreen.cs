using System;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace TypingGame
{
    public partial class StartScreen : Form
    {
        System.Media.SoundPlayer StartScreenMusic = new SoundPlayer();
        new WordGenerator LoadWords = new WordGenerator();
        public StartScreen()
        {
            InitializeComponent();
            foreach (var button in this.Controls.OfType<Button>())
            {
                button.TabStop = false;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
            }
            StartScreenMusic.SoundLocation = "StartMusic.wav";
            UnmuteButton.Visible = false;
            string Load = LoadWords.GenerateRandomWord();
        }

        public Form GoToStartScreen { get; set; }
        private void TimingTyping(object sender, EventArgs e)
        {
            this.Hide();
            TimedTyping asd = new TimedTyping();
            asd.GoToTimedTyping = this;
            asd.Show();
        }
        private void SandboxTyping(object sender, EventArgs e)
        {
            this.Hide();
            SandboxTyping asd = new SandboxTyping();
            asd.GoToSandbox = this;
            asd.Show();
        }

        private void StartScreen_Load(object sender, EventArgs e)
        {
            StartScreenMusic.PlayLooping();
        }

        private void MuteMusic_Click(object sender, EventArgs e)
        {
            StartScreenMusic.Stop();
            MuteButton.Visible = false;
            UnmuteButton.Visible = true;
        }

        private void UnmuteButton_Click(object sender, EventArgs e)
        {
            StartScreenMusic.PlayLooping();
            UnmuteButton.Visible = false;
            MuteButton.Visible = true;
        }
    }
}
