using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hitoya
{
    class Program
    {

        public enum PowerTokens
        { AddToken, Chaos, Death, Rotate}

        public static bool gameOver = false;
        static Player playerOne, playerTwo;
        public static Card[] Deck;
        public static Player activePlayer;

        static void Main(string[] args)
        {

            InitiateGame();    

            while (gameOver == false)
            {

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

            //Shuffle the deck
        }
    }
}
