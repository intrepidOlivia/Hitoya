using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hitoya
{
    public enum PowerTokens
    { Life, Chaos, Death, Rotate }

    class Program
    {

        public static bool gameOver = false;
        static Player playerOne, playerTwo;
        public ArrayList Deck;
        public static Player activePlayer;

        static void Main(string[] args)
        {

            InitiateGame();    

            while (gameOver == false)
            {

                //Determine whose turn it is

                //Initiate that player's turn

                //Make changes to the player's hands or the playing field

                //Switch to the next player's turn

            }

        }

        /// <summary>
        /// Initiates the game variables, loads the cards, and creates the two Player objects.
        /// </summary>
        static void InitiateGame()
        {
            gameOver = false;
            playerOne = new Player();
            playerTwo = new Player();

            LoadCards();

        }

        /// <summary>
        /// Retrieves the player name from some source (either the user's input or some other identity attribute)
        /// </summary>
        private String GetPlayerName()
        {

            String input = "";

            return input;
        }

        /// <summary>
        /// Loads the cards from the file _________________.
        /// </summary>
        private static void LoadCards()
        {

            

            //Load the cards from their appropriate files

            /* 
             TODO: Learn how serialization works in order to learn how to retrieve data. Relevant link: 
             https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/index
             */

            //Shuffle the deck
        }
    }
}
