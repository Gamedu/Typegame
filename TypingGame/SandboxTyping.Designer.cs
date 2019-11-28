namespace TypingGame
{
    partial class SandboxTyping
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SandboxTyping));
            this.GivenWord = new System.Windows.Forms.Label();
            this.Word = new System.Windows.Forms.TextBox();
            this.CorrectScore = new System.Windows.Forms.Label();
            this.Return = new System.Windows.Forms.Button();
            this.WordTimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // GivenWord
            // 
            this.GivenWord.AutoSize = true;
            this.GivenWord.BackColor = System.Drawing.Color.Transparent;
            this.GivenWord.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GivenWord.Location = new System.Drawing.Point(283, 88);
            this.GivenWord.Name = "GivenWord";
            this.GivenWord.Size = new System.Drawing.Size(0, 167);
            this.GivenWord.TabIndex = 2;
            // 
            // Word
            // 
            this.Word.BackColor = System.Drawing.Color.SandyBrown;
            this.Word.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Word.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Word.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Word.Location = new System.Drawing.Point(306, 351);
            this.Word.Name = "Word";
            this.Word.Size = new System.Drawing.Size(489, 61);
            this.Word.TabIndex = 3;
            // 
            // CorrectScore
            // 
            this.CorrectScore.AutoSize = true;
            this.CorrectScore.BackColor = System.Drawing.Color.SandyBrown;
            this.CorrectScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CorrectScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorrectScore.Location = new System.Drawing.Point(724, 510);
            this.CorrectScore.Name = "CorrectScore";
            this.CorrectScore.Size = new System.Drawing.Size(2, 57);
            this.CorrectScore.TabIndex = 7;
            // 
            // Return
            // 
            this.Return.BackColor = System.Drawing.Color.Black;
            this.Return.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Return.BackgroundImage")));
            this.Return.Location = new System.Drawing.Point(0, 525);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(265, 44);
            this.Return.TabIndex = 9;
            this.Return.UseVisualStyleBackColor = false;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // WordTimer
            // 
            this.WordTimer.Tick += new System.EventHandler(this.WordTimer_Tick);
            // 
            // SandboxTyping
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1112, 568);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.CorrectScore);
            this.Controls.Add(this.Word);
            this.Controls.Add(this.GivenWord);
            this.DoubleBuffered = true;
            this.Name = "SandboxTyping";
            this.Text = "SandboxTyping";
            this.Load += new System.EventHandler(this.SandboxTyping_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GivenWord;
        private System.Windows.Forms.TextBox Word;
        private System.Windows.Forms.Label CorrectScore;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Timer WordTimer;
        private System.Windows.Forms.Timer timer1;
    }
}