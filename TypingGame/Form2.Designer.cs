namespace TypingGame
{
    partial class Form2
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
            this.Score = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.TimeLeft = new System.Windows.Forms.Label();
            this.GivenWord = new System.Windows.Forms.Label();
            this.Word = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(1147, 565);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(128, 38);
            this.Score.TabIndex = 0;
            this.Score.Text = "Score : ";
            // 
            // TimeLeft
            // 
            this.TimeLeft.AutoSize = true;
            this.TimeLeft.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLeft.Location = new System.Drawing.Point(1090, 56);
            this.TimeLeft.Name = "TimeLeft";
            this.TimeLeft.Size = new System.Drawing.Size(156, 38);
            this.TimeLeft.TabIndex = 1;
            this.TimeLeft.Text = "Tijd over :";
            // 
            // GivenWord
            // 
            this.GivenWord.AutoSize = true;
            this.GivenWord.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GivenWord.Location = new System.Drawing.Point(382, 71);
            this.GivenWord.Name = "GivenWord";
            this.GivenWord.Size = new System.Drawing.Size(585, 134);
            this.GivenWord.TabIndex = 2;
            this.GivenWord.Text = "voorbeeld";
            // 
            // Word
            // 
            this.Word.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Word.Location = new System.Drawing.Point(420, 357);
            this.Word.Name = "Word";
            this.Word.Size = new System.Drawing.Size(489, 62);
            this.Word.TabIndex = 3;
            this.Word.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CheckAnswer);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(593, 450);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 4;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.StartTest);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 653);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Word);
            this.Controls.Add(this.GivenWord);
            this.Controls.Add(this.TimeLeft);
            this.Controls.Add(this.Score);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label TimeLeft;
        private System.Windows.Forms.Label GivenWord;
        private System.Windows.Forms.TextBox Word;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button Start;
    }
}