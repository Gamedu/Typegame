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
        //hallo
        int correct = 0;
        int incorrect = 0;
        private void Start_Click(object sender, EventArgs e)
        {
            
        }

        private void Woord_KeyDown(object sender, KeyEventArgs e)
        {
            if (GegevenWoord.Text == Woord.Text && e.KeyCode == Keys.Enter)
            {
                correct++;
                AantalCorrect.Text = "Aantal Correct : " + correct;
            }
            if (GegevenWoord.Text != Woord.Text && e.KeyCode == Keys.Enter)
            {
                incorrect++;
                AantalIncorrect.Text = "Aantal Incorrect : " + incorrect;
            }
        }
    }
}
