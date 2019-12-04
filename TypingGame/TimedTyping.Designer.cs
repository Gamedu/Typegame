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
            this.Start = new System.Windows.Forms.Button();
            this.Return = new System.Windows.Forms.Button();
            this.Points = new System.Windows.Forms.Label();
            this.WordTimer = new System.Windows.Forms.Timer(this.components);
            this.MuteButton = new System.Windows.Forms.Button();
            this.UnmuteButton = new System.Windows.Forms.Button();
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
            this.TimeLeft.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLeft.ForeColor = System.Drawing.Color.Black;
            this.TimeLeft.Location = new System.Drawing.Point(53, 81);
            this.TimeLeft.Name = "TimeLeft";
            this.TimeLeft.Size = new System.Drawing.Size(78, 55);
            this.TimeLeft.TabIndex = 1;
            this.TimeLeft.Text = "60";
            // 
            // GivenWord
            // 
            this.GivenWord.AutoSize = true;
            this.GivenWord.BackColor = System.Drawing.Color.Transparent;
            this.GivenWord.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GivenWord.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GivenWord.Location = new System.Drawing.Point(312, 97);
            this.GivenWord.Name = "GivenWord";
            this.GivenWord.Size = new System.Drawing.Size(0, 167);
            this.GivenWord.TabIndex = 2;
            // 
            // Word
            // 
            this.Word.BackColor = System.Drawing.Color.Firebrick;
            this.Word.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Word.ForeColor = System.Drawing.Color.White;
            this.Word.Location = new System.Drawing.Point(299, 324);
            this.Word.Name = "Word";
            this.Word.Size = new System.Drawing.Size(489, 62);
            this.Word.TabIndex = 3;
            // 
            // Start
            // 
            this.Start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Start.BackgroundImage")));
            this.Start.Location = new System.Drawing.Point(423, 401);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(283, 80);
            this.Start.TabIndex = 4;
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.StartTest);
            // 
            // Return
            // 
            this.Return.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Return.BackgroundImage")));
            this.Return.Location = new System.Drawing.Point(-2, 472);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(266, 96);
            this.Return.TabIndex = 5;
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // Points
            // 
            this.Points.AutoSize = true;
            this.Points.BackColor = System.Drawing.Color.Firebrick;
            this.Points.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Points.Font = new System.Drawing.Font("Comic Sans MS", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Points.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Points.Location = new System.Drawing.Point(1045, 489);
            this.Points.Name = "Points";
            this.Points.Size = new System.Drawing.Size(60, 69);
            this.Points.TabIndex = 6;
            this.Points.Text = "0";
            // 
            // WordTimer
            // 
            this.WordTimer.Interval = 10;
            this.WordTimer.Tick += new System.EventHandler(this.CheckWord);
            // 
            // MuteButton
            // 
            this.MuteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MuteButton.BackgroundImage")));
            this.MuteButton.Location = new System.Drawing.Point(1020, 12);
            this.MuteButton.Name = "MuteButton";
            this.MuteButton.Size = new System.Drawing.Size(80, 68);
            this.MuteButton.TabIndex = 8;
            this.MuteButton.UseVisualStyleBackColor = true;
            this.MuteButton.Click += new System.EventHandler(this.MuteButton_Click);
            // 
            // UnmuteButton
            // 
            this.UnmuteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UnmuteButton.BackgroundImage")));
            this.UnmuteButton.Location = new System.Drawing.Point(1020, 12);
            this.UnmuteButton.Name = "UnmuteButton";
            this.UnmuteButton.Size = new System.Drawing.Size(80, 68);
            this.UnmuteButton.TabIndex = 9;
            this.UnmuteButton.UseVisualStyleBackColor = true;
            this.UnmuteButton.Click += new System.EventHandler(this.UnmuteButton_Click);
            // 
            // TimedTyping
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1112, 563);
            this.Controls.Add(this.UnmuteButton);
            this.Controls.Add(this.MuteButton);
            this.Controls.Add(this.Points);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Word);
            this.Controls.Add(this.GivenWord);
            this.Controls.Add(this.TimeLeft);
            this.Controls.Add(this.Points2);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1130, 610);
            this.Name = "TimedTyping";
            this.Text = "TimedTyping";
            this.Load += new System.EventHandler(this.TimedTyping_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Points2;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label TimeLeft;
        public System.Windows.Forms.Label GivenWord;
        private System.Windows.Forms.TextBox Word;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Label Points;
        private System.Windows.Forms.Timer WordTimer;
        private System.Windows.Forms.Button MuteButton;
        private System.Windows.Forms.Button UnmuteButton;
    }
}