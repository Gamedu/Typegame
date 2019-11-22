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
        int correct = 0;
        int incorrect = 0;

        private void Word2_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (GivenWord2.Text == Word2.Text && e.KeyCode == Keys.Enter)
            {
                correct++;
                CorrectScore2.Text = "Aantal Correct : " + correct;
            }

            if (GivenWord2.Text != Word2.Text && e.KeyCode == Keys.Enter)
            {
                incorrect++;
                IncorrectScore2.Text = "Aantal Incorrect : " + incorrect;
            }

            if (e.KeyCode == Keys.Enter)
            {
                Word2.Text = string.Empty;
                GivenWord2.Text = WordsFree.GenerateRandomWord();
            }
        }
        public Form GoToSandbox { get; set; }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (null != GoToSandbox)
                GoToSandbox.Show();
        }
        private void Return_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartScreen asd = new StartScreen();
            asd.GoToStartScreen = this;
            asd.Show();
        }

        private void SandboxTyping_Load(object sender, EventArgs e)
        {
            GivenWord2.Text = WordsFree.GenerateRandomWord();
        }
    }
}

