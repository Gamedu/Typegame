using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TypingGame
{
    class WordGenerator
    {
        List<Words> newWords = new List<Words>();
        List<Words> Group123 = new List<Words>();
        List<Words> Group45 = new List<Words>();
        List<Words> Group6 = new List<Words>();
        List<Words> Group7 = new List<Words>();
        List<Words> Group8 = new List<Words>();

        private Random rnd = new Random();

        public string CurrentWord;
        public int Group = 8;
        public string GenerateRandomWord()
        {
            using (var DbContext = new dbi441943Entities6())
            {
                var getWords = DbContext.Words.ToList();
                foreach (var item in getWords)
                {
                  newWords.Add(new Words(item.WordString));  
                }
                foreach (var item in getWords)
                {
                    if (item.Cat == "VeryEasy")
                    {
                            Group123.Add(new Words(item.WordString));
                    }

                    if (item.Cat == "VeryEasy" || item.Cat == "Easy")
                    {
                        Group45.Add(new Words(item.WordString));
                    }

                    if (item.Cat == "VeryEasy" || item.Cat == "Easy" || item.Cat == "Average")
                    {
                        Group6.Add(new Words(item.WordString));
                    }

                    if (item.Cat == "VeryEasy" || item.Cat == "Easy" || item.Cat == "Average" || item.Cat == "Hard")
                    {
                        Group7.Add(new Words(item.WordString));
                    }

                    if (item.Cat == "VeryEasy" || item.Cat == "Easy" || item.Cat == "Average" || item.Cat == "Hard" || item.Cat == "Master")
                    {
                        Group8.Add(new Words(item.WordString));
                    }
                }
            }

            switch (Group)
            {
                case 1:
                case 2:
                case 3:
                    CurrentWord = Group123[rnd.Next(Group123.Count())].Word;
                    break;
                case 4:
                case 5:
                    CurrentWord = Group45[rnd.Next(Group45.Count())].Word;
                    break;
                case 6:
                    CurrentWord = Group6[rnd.Next(Group6.Count())].Word;
                    break;
                case 7:
                    CurrentWord = Group7[rnd.Next(Group7.Count())].Word;
                    break;
                case 8:
                    CurrentWord = Group8[rnd.Next(Group8.Count())].Word;
                    break;
            }
            return CurrentWord;
        }

        class Words
        {
            public string Word { get; set; }

            public Words(string word)
            {
                Word = word;
            }
        }
    }
}
