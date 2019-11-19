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
            this.SuspendLayout();
            // 
            // GegevenWoord
            // 
            this.GegevenWoord.AutoSize = true;
            this.GegevenWoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GegevenWoord.Location = new System.Drawing.Point(446, 50);
            this.GegevenWoord.Name = "GegevenWoord";
            this.GegevenWoord.Size = new System.Drawing.Size(379, 135);
            this.GegevenWoord.TabIndex = 1;
            this.GegevenWoord.Text = "label1";
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
            this.AantalCorrect.Location = new System.Drawing.Point(1010, 537);
            this.AantalCorrect.Name = "AantalCorrect";
            this.AantalCorrect.Size = new System.Drawing.Size(252, 39);
            this.AantalCorrect.TabIndex = 3;
            this.AantalCorrect.Text = "Aantal Correct :";
            // 
            // AantalIncorrect
            // 
            this.AantalIncorrect.AutoSize = true;
            this.AantalIncorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AantalIncorrect.Location = new System.Drawing.Point(989, 576);
            this.AantalIncorrect.Name = "AantalIncorrect";
            this.AantalIncorrect.Size = new System.Drawing.Size(282, 39);
            this.AantalIncorrect.TabIndex = 4;
            this.AantalIncorrect.Text = "Aantal Incorrect : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 636);
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
    }
}

