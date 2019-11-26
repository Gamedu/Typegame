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
        WordGenerator WordsFree = new WordGenerator();
        public SandboxTyping()
        {
            InitializeComponent();
        }

        private int Score;

        private void Word2_KeyDown_1(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (WordsFree.currentword == Word.Text && e.KeyCode == Keys.Enter)
                {
                    Score++;
                    CorrectScore.Text = "Score : " + Score;
                }
                Word.Text = string.Empty;
                GivenWord.Text = WordsFree.GenerateRandomWord();
            }
        }
        public Form GoToSandbox { get; set; }
        private void Return_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartScreen asd = new StartScreen();
            asd.GoToStartScreen = this;
            asd.Show();
        }

        private void SandboxTyping_Load(object sender, EventArgs e)
        {
            GivenWord.Text = WordsFree.GenerateRandomWord();
        }
    }
}

