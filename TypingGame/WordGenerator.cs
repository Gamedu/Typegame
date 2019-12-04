using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TypingGame
{
    class WordGenerator
    {
        List<string> newWords = new List<string>();

        private Random rnd = new Random();
        public string CurrentWord {get; private set;}
        public string GenerateRandomWord()
        {
            using (var DbContext = new GameduEntities())
            {
                var getWords = DbContext.TableWords.ToList();

                foreach (var item in getWords)
                {
                    newWords.Add(item.Word);
                }
            }

            CurrentWord = newWords[rnd.Next(newWords.Count)];
            newWords.Remove(CurrentWord);
            return CurrentWord;
        }
    }
}
