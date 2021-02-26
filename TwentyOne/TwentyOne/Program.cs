using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {

            Deck deck = new Deck();

            //working with lamba
            //List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();

            List<int> numberList = new List<int>() { 1, 2, 3, 4, 55, 666, 7 };

            int sum = numberList.Sum(x => x + 5);
            Console.WriteLine(sum);


            //foreach (Card card in newList)
            //{
            //    Console.WriteLine(card.Face);
            //}

            //Deck deck = new Deck();
            //int count = deck.Cards.Count(x => x.Face == Face.Ace);
            //Console.WriteLine(count);



            ////working with Suit enum
            //Card card = new Card();
            //card.Suit = Suit.Clubs;
            //int underlyingValue = Convert.ToInt32(Suit.Diamonds);
            //Console.WriteLine(underlyingValue);


            //Game game = new TwentyOneGame();
            //game.Players = new List<Player>();
            //Player player = new Player();
            //player.Name = "Jaimie";
            //game += player;
            //game -= player;

            //List<Game> games = new List<Game>();
            //TwentyOneGame game = new TwentyOneGame();
            //games.Add(game);
            //Game game = new TwentyOneGame();

            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Jaimie", "Alex", "Mark" };
            //game.ListPlayers();
            //game.Play();
            //Console.ReadLine();


            //Card card1 = new Card();
            //Card card2 = card1;
            //card1.Face = Face.Eight;
            //card2.Face = Face.King;

            //Console.WriteLine(card1.Face);

            //Deck deck = new Deck();
            //deck.Shuffle(3);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
         
            Console.ReadLine();
        }


        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i=0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}

   


    }

}
