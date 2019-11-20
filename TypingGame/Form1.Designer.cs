namespace TypingGame
{
    partial class Form1
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
            this.GivenWord = new System.Windows.Forms.Label();
            this.Word = new System.Windows.Forms.TextBox();
            this.CorrectScore = new System.Windows.Forms.Label();
            this.IncorrectScore = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GivenWord
            // 
            this.GivenWord.AutoSize = true;
            this.GivenWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GivenWord.Location = new System.Drawing.Point(363, 45);
            this.GivenWord.Name = "GivenWord";
            this.GivenWord.Size = new System.Drawing.Size(586, 135);
            this.GivenWord.TabIndex = 1;
            this.GivenWord.Text = "voorbeeld";
            // 
            // Word
            // 
            this.Word.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Word.Location = new System.Drawing.Point(403, 403);
            this.Word.Name = "Word";
            this.Word.Size = new System.Drawing.Size(489, 61);
            this.Word.TabIndex = 2;
            this.Word.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Word_KeyDown);
            // 
            // CorrectScore
            // 
            this.CorrectScore.AutoSize = true;
            this.CorrectScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorrectScore.Location = new System.Drawing.Point(1075, 537);
            this.CorrectScore.Name = "CorrectScore";
            this.CorrectScore.Size = new System.Drawing.Size(244, 38);
            this.CorrectScore.TabIndex = 3;
            this.CorrectScore.Text = "Aantal Correct :";
            // 
            // IncorrectScore
            // 
            this.IncorrectScore.AutoSize = true;
            this.IncorrectScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncorrectScore.Location = new System.Drawing.Point(1057, 575);
            this.IncorrectScore.Name = "IncorrectScore";
            this.IncorrectScore.Size = new System.Drawing.Size(272, 38);
            this.IncorrectScore.TabIndex = 4;
            this.IncorrectScore.Text = "Aantal Incorrect : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 653);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IncorrectScore);
            this.Controls.Add(this.CorrectScore);
            this.Controls.Add(this.Word);
            this.Controls.Add(this.GivenWord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label GivenWord;
        private System.Windows.Forms.TextBox Word;
        private System.Windows.Forms.Label CorrectScore;
        private System.Windows.Forms.Label IncorrectScore;
        private System.Windows.Forms.Button button1;
    }
}

