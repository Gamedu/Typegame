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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Timer = new System.Windows.Forms.Label();
            this.GegevenWoord = new System.Windows.Forms.Label();
            this.Woord = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
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
            // Timer
            // 
            this.Timer.AutoSize = true;
            this.Timer.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timer.Location = new System.Drawing.Point(1147, 53);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(96, 38);
            this.Timer.TabIndex = 1;
            this.Timer.Text = "Tijd : ";
            // 
            // GegevenWoord
            // 
            this.GegevenWoord.AutoSize = true;
            this.GegevenWoord.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GegevenWoord.Location = new System.Drawing.Point(382, 71);
            this.GegevenWoord.Name = "GegevenWoord";
            this.GegevenWoord.Size = new System.Drawing.Size(585, 134);
            this.GegevenWoord.TabIndex = 2;
            this.GegevenWoord.Text = "voorbeeld";
            // 
            // Woord
            // 
            this.Woord.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Woord.Location = new System.Drawing.Point(420, 357);
            this.Woord.Name = "Woord";
            this.Woord.Size = new System.Drawing.Size(489, 62);
            this.Woord.TabIndex = 3;
            this.Woord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Woord_KeyDown);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 653);
            this.Controls.Add(this.Woord);
            this.Controls.Add(this.GegevenWoord);
            this.Controls.Add(this.Timer);
            this.Controls.Add(this.Score);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Timer;
        private System.Windows.Forms.Label GegevenWoord;
        private System.Windows.Forms.TextBox Woord;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}