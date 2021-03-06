﻿using System;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace TypingGame
{
    public partial class TimedTyping : Form
    {
        readonly WordGenerator WordsTime = new WordGenerator();
        SoundPlayer TimedMusic = new SoundPlayer();
        int Score;
        private int counter = 60;
        private int correct;
        private int incorrect;
        private int total;
        public TimedTyping()
        {
            InitializeComponent();
            Timer.Tick += new EventHandler(TimerCount);
            Word.Enabled = false;

            foreach (var button in this.Controls.OfType<Button>())
            {
                button.TabStop = false;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
            }
            TimedMusic.SoundLocation = "RacingMusic.wav";
            UnmuteButton.Visible = false;
        }
        public void StartTest(object sender, EventArgs e)
        {
            Timer.Start();
            WordTimer.Start();
            Score = 0;
            Points.Text = Score.ToString();
            this.ActiveControl = Word;  

            Word.Enabled = true;
            Start.Enabled = false;

            GivenWord.Text = WordsTime.GenerateRandomWord();

            TimeLeft.Text = counter.ToString();
        }
        public void TimerCount(object sender, EventArgs e)
        {
            counter--;
            TimeLeft.Text = counter.ToString();
            if (counter == 0)
            {
                Timer.Stop();
                Start.Enabled = true;
                Word.Enabled = false;

                GivenWord.Text = "";
                counter = 60;

                using (dbi441943Entities6 DbContext = new dbi441943Entities6())
                {
                    var getUser = DbContext.AspNetUsers.Where(s => s.Email== "ryanhouben1998@gmail.com").FirstOrDefault();

                    var newScore = new TypingGameScore()
                    {
                        AspNetUser = getUser,
                        Correct = correct,
                        InCorrect = incorrect,
                        TotalScore = total,
                        ResultDateTime = DateTime.Now
                    };

                    DbContext.TypingGameScores.Add(newScore);
                    
                    DbContext.SaveChanges();
                }
            }
        }
        private void CheckWord(object sender, EventArgs e)
        {
            if (GivenWord.Text.Length == Word.TextLength)
            {
                if (GivenWord.Text == Word.Text)
                {
                    Score++;
                    correct++;
                    total++;
                    Points.Text = Score.ToString();
                    ClearWords();
                }
                else
                {
                    ClearWords();
                    incorrect++;
                    total++;
                }
            }
        }
        public void ClearWords()
        {
            Word.Text = string.Empty;
            GivenWord.Text = WordsTime.GenerateRandomWord();
        }
        private void Return_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartScreen asd = new StartScreen();
            asd.GoToStartScreen = this;
            asd.Show();
            Timer.Stop();
            this.Close();
        }
        public Form GoToTimedTyping { get; set; }
        private void TimedTyping_Load(object sender, EventArgs e)
        {
            TimedMusic.PlayLooping();
        }
        private void MuteButton_Click(object sender, EventArgs e)
        {
            TimedMusic.Stop();
            MuteButton.Visible = false;
            UnmuteButton.Visible = true;
        }
        private void UnmuteButton_Click(object sender, EventArgs e)
        {
            TimedMusic.PlayLooping();
            UnmuteButton.Visible = false;
            MuteButton.Visible = true;
        }
    }
}
