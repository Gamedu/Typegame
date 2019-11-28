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
    public partial class SandboxTyping : Form
    {
        readonly WordGenerator WordsFree = new WordGenerator();
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
        }
        private void SandboxTyping_Load(object sender, EventArgs e)
        {
            GivenWord.Text = WordsFree.GenerateRandomWord();
            WordTimer.Start();
        }
        private void WordTimer_Tick(object sender, EventArgs e)
        {
            if (WordsFree.currentword == Word.Text)
            {
                Score++;
                CorrectScore.Text = Score.ToString();
                ClearWords();
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
    }
}

