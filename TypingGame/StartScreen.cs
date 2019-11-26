using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypingGame
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
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
            foreach (var button in this.Controls.OfType<Button>())
            {
                button.TabStop = false;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
            }
        }
    }
}
