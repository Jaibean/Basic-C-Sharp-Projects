 using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace TwentyOne
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }


        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);
            using (StreamWriter file = new StreamWriter(@"/Users/jaimiebertoli/Documents/GitHub/Basic-C-Sharp-Projects/TwentyOne/Logs/log.txt", true))
            {
                file.WriteLine(card);
            }
            Deck.Cards.RemoveAt(0);
        }
    }
}
