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
        private List<string> Words = new List<string>()
        {
            "appel",
            "arts",
            "aan",
            "alles",
            "als",
            "aan",
            "aarde",
            "anders",
            "afval",
            "arend",
            "banaan",
            "beneden",
            "boef",
            "bestel",
            "baard",
            "bar",
            "bats",
            "beest",
            "ding",
            "deur",
            "daar",
            "deze",
            "dingen",
            "dieren",
            "doof",
            "fiets",
            "friet",
            "feest",
            "goed",
            "groet",
            "gooi",
            "hallo",
            "heeft",
            "haal",
            "iemand",
            "iets",
            "jij",
            "jullie",
            "joker",
            "juist",
            "koala",
            "kreeft",
            "krant",
            "lief",
            "leren",
            "lezen",
            "meer",
            "maanden",
            "maan",
            "mand",
            "neer",
            "niemand",
            "niets",
            "naar",
            "over",
            "oven",
            "onder",
            "pers",
            "perzik",
            "plank",
            "rand",
            "raam",
            "rits",
            "rekenen",
            "raar",
            "stok",
            "slaan",
            "staan",
            "schrijf",
            "tekenen",
            "trem",
            "tien",
            "twijfel",
            "uil",
            "uit",
            "verander",
            "veel",
            "vrij",
            "vriend",
            "wij",
            "wezen",
            "weer",
            "yam",
            "yoga",
            "yoghurt",
            "zonde",
            "zon",
            "zaterdag",
            "zeker",
            "qua",
            "quiz",
            "typen",

        };
        private Random rnd = new Random();
        public string CurrentWord {get; private set;}
        public string GenerateRandomWord()
        {
            CurrentWord = Words[rnd.Next(Words.Count)];
            return CurrentWord;
        }
    }
}
