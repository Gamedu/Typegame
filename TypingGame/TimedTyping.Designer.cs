namespace TypingGame
{
    partial class TimedTyping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimedTyping));
            this.Points2 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.TimeLeft = new System.Windows.Forms.Label();
            this.GivenWord = new System.Windows.Forms.Label();
            this.Word = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Start = new System.Windows.Forms.Button();
            this.Return = new System.Windows.Forms.Button();
            this.Points = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Points2
            // 
            this.Points2.AutoSize = true;
            this.Points2.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Points2.Location = new System.Drawing.Point(1147, 565);
            this.Points2.Name = "Points2";
            this.Points2.Size = new System.Drawing.Size(128, 38);
            this.Points2.TabIndex = 0;
            this.Points2.Text = "Score : ";
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            // 
            // TimeLeft
            // 
            this.TimeLeft.AutoSize = true;
            this.TimeLeft.BackColor = System.Drawing.Color.Transparent;
            this.TimeLeft.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLeft.ForeColor = System.Drawing.Color.Black;
            this.TimeLeft.Location = new System.Drawing.Point(871, 81);
            this.TimeLeft.Name = "TimeLeft";
            this.TimeLeft.Size = new System.Drawing.Size(156, 38);
            this.TimeLeft.TabIndex = 1;
            this.TimeLeft.Text = "Tijd over :";
            // 
            // GivenWord
            // 
            this.GivenWord.AutoSize = true;
            this.GivenWord.BackColor = System.Drawing.Color.Transparent;
            this.GivenWord.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GivenWord.Location = new System.Drawing.Point(249, 81);
            this.GivenWord.Name = "GivenWord";
            this.GivenWord.Size = new System.Drawing.Size(0, 134);
            this.GivenWord.TabIndex = 2;
            // 
            // Word
            // 
            this.Word.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Word.Location = new System.Drawing.Point(299, 324);
            this.Word.Name = "Word";
            this.Word.Size = new System.Drawing.Size(489, 62);
            this.Word.TabIndex = 3;
            this.Word.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CheckAnswer);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(497, 440);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 4;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.StartTest);
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(106, 288);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(75, 23);
            this.Return.TabIndex = 5;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // Points
            // 
            this.Points.AutoSize = true;
            this.Points.BackColor = System.Drawing.Color.Transparent;
            this.Points.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Points.Location = new System.Drawing.Point(863, 440);
            this.Points.Name = "Points";
            this.Points.Size = new System.Drawing.Size(164, 25);
            this.Points.TabIndex = 6;
            this.Points.Text = "Aantal woorden : ";
            // 
            // TimedTyping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1112, 562);
            this.Controls.Add(this.Points);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Word);
            this.Controls.Add(this.GivenWord);
            this.Controls.Add(this.TimeLeft);
            this.Controls.Add(this.Points2);
            this.Name = "TimedTyping";
            this.Text = "TimedTyping";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Points2;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label TimeLeft;
        public System.Windows.Forms.Label GivenWord;
        private System.Windows.Forms.TextBox Word;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Label Points;
    }
}