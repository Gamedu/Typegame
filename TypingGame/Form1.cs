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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int correct = 0;
        int incorrect = 0;
        private void Word_KeyDown(object sender, KeyEventArgs e)
        {
            if (GivenWord.Text == Word.Text && e.KeyCode == Keys.Enter)
            {
                correct++;
                CorrectScore.Text = "Aantal Correct : " + correct;
            }  
            
            if (GivenWord.Text != Word.Text && e.KeyCode == Keys.Enter)
            {
                incorrect++;
                IncorrectScore.Text = "Aantal Incorrect : " + incorrect; 
            }

            if (e.KeyCode == Keys.Enter)
            {
                Word.Text = string.Empty;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 asd = new Form2();
            asd.FormToShowOnClosing = this;
            asd.Show();
        }
    }
}
