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
            this.GivenWord2 = new System.Windows.Forms.Label();
            this.Word2 = new System.Windows.Forms.TextBox();
            this.CorrectScore2 = new System.Windows.Forms.Label();
            this.IncorrectScore2 = new System.Windows.Forms.Label();
            this.Return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GivenWord2
            // 
            this.GivenWord2.AutoSize = true;
            this.GivenWord2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GivenWord2.Location = new System.Drawing.Point(283, 88);
            this.GivenWord2.Name = "GivenWord2";
            this.GivenWord2.Size = new System.Drawing.Size(586, 135);
            this.GivenWord2.TabIndex = 2;
            this.GivenWord2.Text = "voorbeeld";
            // 
            // Word2
            // 
            this.Word2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Word2.Location = new System.Drawing.Point(306, 342);
            this.Word2.Name = "Word2";
            this.Word2.Size = new System.Drawing.Size(489, 61);
            this.Word2.TabIndex = 3;
            this.Word2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Word2_KeyDown_1);
            // 
            // CorrectScore2
            // 
            this.CorrectScore2.AutoSize = true;
            this.CorrectScore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorrectScore2.Location = new System.Drawing.Point(831, 385);
            this.CorrectScore2.Name = "CorrectScore2";
            this.CorrectScore2.Size = new System.Drawing.Size(244, 38);
            this.CorrectScore2.TabIndex = 7;
            this.CorrectScore2.Text = "Aantal Correct :";
            // 
            // IncorrectScore2
            // 
            this.IncorrectScore2.AutoSize = true;
            this.IncorrectScore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncorrectScore2.Location = new System.Drawing.Point(812, 423);
            this.IncorrectScore2.Name = "IncorrectScore2";
            this.IncorrectScore2.Size = new System.Drawing.Size(272, 38);
            this.IncorrectScore2.TabIndex = 8;
            this.IncorrectScore2.Text = "Aantal Incorrect : ";
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(93, 422);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(75, 23);
            this.Return.TabIndex = 9;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // SandboxTyping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 562);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.IncorrectScore2);
            this.Controls.Add(this.CorrectScore2);
            this.Controls.Add(this.Word2);
            this.Controls.Add(this.GivenWord2);
            this.Name = "SandboxTyping";
            this.Text = "StartScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GivenWord2;
        private System.Windows.Forms.TextBox Word2;
        private System.Windows.Forms.Label CorrectScore2;
        private System.Windows.Forms.Label IncorrectScore2;
        private System.Windows.Forms.Button Return;
    }
}