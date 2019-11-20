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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int score = 0;
        int Tijdover = 120;
        private void Woord_KeyDown(object sender, KeyEventArgs e)
        {
            if (GegevenWoord.Text == Woord.Text && e.KeyCode == Keys.Enter)
            {
                score++;
                Score.Text = "Score : " + score;

                timer1.Start();
                timer1.Tick += new EventHandler(timer1_Tick);
                timer1.Interval = 1000; // 1 second
                timer1.Start();
                Timer.Text = Tijdover.ToString();
            }

        }
        public Form FormToShowOnClosing { get; set; }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (null != FormToShowOnClosing)
                FormToShowOnClosing.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Tijdover--;
            if (Tijdover== 0)

                timer1.Stop();
            Timer.Text = "Timer : " + Tijdover.ToString();

        }
    }
}
