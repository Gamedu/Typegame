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
            this.Start = new System.Windows.Forms.Button();
            this.GegevenWoord = new System.Windows.Forms.Label();
            this.Woord = new System.Windows.Forms.TextBox();
            this.AantalCorrect = new System.Windows.Forms.Label();
            this.AantalIncorrect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(339, 314);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(99, 23);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start game";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // GegevenWoord
            // 
            this.GegevenWoord.AutoSize = true;
            this.GegevenWoord.Location = new System.Drawing.Point(147, 87);
            this.GegevenWoord.Name = "GegevenWoord";
            this.GegevenWoord.Size = new System.Drawing.Size(46, 17);
            this.GegevenWoord.TabIndex = 1;
            this.GegevenWoord.Text = "label1";
            // 
            // Woord
            // 
            this.Woord.Location = new System.Drawing.Point(518, 87);
            this.Woord.Name = "Woord";
            this.Woord.Size = new System.Drawing.Size(100, 22);
            this.Woord.TabIndex = 2;
            this.Woord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Woord_KeyDown);
            // 
            // AantalCorrect
            // 
            this.AantalCorrect.AutoSize = true;
            this.AantalCorrect.Location = new System.Drawing.Point(518, 139);
            this.AantalCorrect.Name = "AantalCorrect";
            this.AantalCorrect.Size = new System.Drawing.Size(106, 17);
            this.AantalCorrect.TabIndex = 3;
            this.AantalCorrect.Text = "Aantal Correct :";
            // 
            // AantalIncorrect
            // 
            this.AantalIncorrect.AutoSize = true;
            this.AantalIncorrect.Location = new System.Drawing.Point(518, 160);
            this.AantalIncorrect.Name = "AantalIncorrect";
            this.AantalIncorrect.Size = new System.Drawing.Size(107, 17);
            this.AantalIncorrect.TabIndex = 4;
            this.AantalIncorrect.Text = "Aantal Incorrect";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AantalIncorrect);
            this.Controls.Add(this.AantalCorrect);
            this.Controls.Add(this.Woord);
            this.Controls.Add(this.GegevenWoord);
            this.Controls.Add(this.Start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label GegevenWoord;
        private System.Windows.Forms.TextBox Woord;
        private System.Windows.Forms.Label AantalCorrect;
        private System.Windows.Forms.Label AantalIncorrect;
    }
}

