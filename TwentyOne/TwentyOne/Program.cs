using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino.TwentyOne;




namespace Casino.TwentyOne

{
    class Program
    {
        static void Main(string[] args)
        {
            ////using var for datatype
            //var newPlayer = new Player("Jaimie");

            //Globally unique identifier 
            Guid identifier = Guid.NewGuid();


            const string casinoName = "Grand Hotel and Casino";

            Console.WriteLine("Welcome to the {9}. Let's start by telling me your name.", casinoName);
            string playerName = Console.ReadLine();

            Console.WriteLine("And how much did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Heelo, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                player.ID = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"/Users/jaimiebertoli/Documents/GitHub/Basic-C-Sharp-Projects/TwentyOne/Logs/log.txt", true))
                {
                    file.WriteLine(player.ID);
                    
                }

                //polymorphism to expose overloaded operators we made
                Game game = new TwentyOneGame();
                game += player;
                player.IsActivelyPlaying = true;
                while (player.IsActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.Read();
        }

    }

}
