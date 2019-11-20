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
            this.GegevenWoord = new System.Windows.Forms.Label();
            this.Woord = new System.Windows.Forms.TextBox();
            this.AantalCorrect = new System.Windows.Forms.Label();
            this.AantalIncorrect = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GegevenWoord
            // 
            this.GegevenWoord.AutoSize = true;
            this.GegevenWoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GegevenWoord.Location = new System.Drawing.Point(363, 45);
            this.GegevenWoord.Name = "GegevenWoord";
            this.GegevenWoord.Size = new System.Drawing.Size(586, 135);
            this.GegevenWoord.TabIndex = 1;
            this.GegevenWoord.Text = "voorbeeld";
            // 
            // Woord
            // 
            this.Woord.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Woord.Location = new System.Drawing.Point(403, 403);
            this.Woord.Name = "Woord";
            this.Woord.Size = new System.Drawing.Size(489, 61);
            this.Woord.TabIndex = 2;
            this.Woord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Woord_KeyDown);
            // 
            // AantalCorrect
            // 
            this.AantalCorrect.AutoSize = true;
            this.AantalCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AantalCorrect.Location = new System.Drawing.Point(1075, 537);
            this.AantalCorrect.Name = "AantalCorrect";
            this.AantalCorrect.Size = new System.Drawing.Size(244, 38);
            this.AantalCorrect.TabIndex = 3;
            this.AantalCorrect.Text = "Aantal Correct :";
            // 
            // AantalIncorrect
            // 
            this.AantalIncorrect.AutoSize = true;
            this.AantalIncorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AantalIncorrect.Location = new System.Drawing.Point(1057, 575);
            this.AantalIncorrect.Name = "AantalIncorrect";
            this.AantalIncorrect.Size = new System.Drawing.Size(272, 38);
            this.AantalIncorrect.TabIndex = 4;
            this.AantalIncorrect.Text = "Aantal Incorrect : ";
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
            this.Controls.Add(this.AantalIncorrect);
            this.Controls.Add(this.AantalCorrect);
            this.Controls.Add(this.Woord);
            this.Controls.Add(this.GegevenWoord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label GegevenWoord;
        private System.Windows.Forms.TextBox Woord;
        private System.Windows.Forms.Label AantalCorrect;
        private System.Windows.Forms.Label AantalIncorrect;
        private System.Windows.Forms.Button button1;
    }
}

