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
            CorrectScore.Text = "0";
        }

        private int Score;

        private void Word2_KeyDown_1(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (WordsFree.currentword == Word.Text && e.KeyCode == Keys.Enter)
                {
                    Score++;
                    CorrectScore.Text = Score.ToString();
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
            foreach (var button in this.Controls.OfType<Button>())
            {
                button.TabStop = false;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
            }
        }
    }
}

