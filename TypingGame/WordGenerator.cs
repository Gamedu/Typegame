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
        private List<string> Woorden = new List<string>()
        {
            "groenten",
            "tevreden",
            "bruiloft",
            "samen",
            "zeven",
            "kwaliteit",
            "medewerker",
            "controle",
            "kapot",
            "nederlaag",
            "speler",
            "boot",
            "zeker",
            "lopen",
            "zien",
            "landgraaf",
            "gegeven",
            "beginnen",
            "vrachtwagen",
            "reden",
            "televisie",
            "frisdrank",
            "paard",
            "radio",
            "gitaar",
            "politie",
            "onderzoek",
            "weerstand",

        };
        private Random rnd = new Random();
        public string currentword {get; private set;}
        public string GenerateRandomWord()
        {
            currentword = Woorden[rnd.Next(Woorden.Count)];
            return currentword;
        }
    }
}
