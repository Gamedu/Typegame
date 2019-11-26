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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SandboxTyping));
            this.GivenWord = new System.Windows.Forms.Label();
            this.Word = new System.Windows.Forms.TextBox();
            this.CorrectScore = new System.Windows.Forms.Label();
            this.Return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GivenWord
            // 
            this.GivenWord.AutoSize = true;
            this.GivenWord.BackColor = System.Drawing.Color.Transparent;
            this.GivenWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GivenWord.Location = new System.Drawing.Point(283, 88);
            this.GivenWord.Name = "GivenWord";
            this.GivenWord.Size = new System.Drawing.Size(0, 135);
            this.GivenWord.TabIndex = 2;
            // 
            // Word
            // 
            this.Word.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Word.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Word.Location = new System.Drawing.Point(306, 351);
            this.Word.Name = "Word";
            this.Word.Size = new System.Drawing.Size(489, 61);
            this.Word.TabIndex = 3;
            this.Word.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Word2_KeyDown_1);
            // 
            // CorrectScore
            // 
            this.CorrectScore.AutoSize = true;
            this.CorrectScore.BackColor = System.Drawing.Color.Transparent;
            this.CorrectScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorrectScore.Location = new System.Drawing.Point(490, 505);
            this.CorrectScore.Name = "CorrectScore";
            this.CorrectScore.Size = new System.Drawing.Size(121, 38);
            this.CorrectScore.TabIndex = 7;
            this.CorrectScore.Text = "Score :";
            // 
            // Return
            // 
            this.Return.BackColor = System.Drawing.Color.Transparent;
            this.Return.Location = new System.Drawing.Point(93, 422);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(75, 23);
            this.Return.TabIndex = 9;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = false;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // SandboxTyping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1112, 562);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.CorrectScore);
            this.Controls.Add(this.Word);
            this.Controls.Add(this.GivenWord);
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
    }
}