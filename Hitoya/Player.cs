using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hitoya
{

    public enum Colors { red, blue }

    /// <summary>
    /// There may only be two players at any given time. Each Player has a Hand, an Inventory, and a Score.
    /// </summary>
    class Player
    {
        Program Game;
        String playerName;
        public ArrayList Hand;
        public ArrayList TokenInventory;
        int captured;       //How many enemy counters the player has captured
        int currentScore;
        Colors color;

        public Player()
        {

        }

        public Player(String nameInput, Program game)
        {
            playerName = nameInput;
            Game = game;
        }

        public String Name
        {
            get { return playerName; }
            set { playerName = value; }
        }

        /// <summary>
        /// Retrieves the player name from some source (either the user's input or some other identity attribute)
        /// </summary>
        private static String GetPlayerName()
        {

            String input = "";

            return input;
        }

        /// <summary>
        /// The current score, based on the number of enemy counters captured and number of current counters on the board.
        /// </summary>
        public int Score
        {
            get { return currentScore; }
        }

        public Colors PlayerColor
        {
            get { return color; }
        }

        /// <summary>
        /// The player draws a card from the game's Deck
        /// </summary>
        public void DrawCard(int drawCount)
        {
            for (int i = 0; i < drawCount; i++)
            {
                Hand.Add(Game.Deck[Game.Deck.Count - 1]);           //Retrieves the last card in the deck
                Game.Deck.Remove(Game.Deck[Game.Deck.Count - 1]);   //Removes that card from the deck

                DisplayCard();
            }

            
        }

        /// <summary>
        /// Displays the newly-drawn card to the player.
        /// Requires user input to exit the function.
        /// </summary>
        private void DisplayCard()
        {

        }

        public void AddToken(TokenTypes tokenType)
        {
            TokenInventory.Add(new PowerToken(tokenType));
        }

        public void Discard(int discardCount)
        {
            Card[] selectedCards = new Card[discardCount];

            //Display the UI segment that allows the player to discard cards of their choosing

            //Retrieve user input

            //Change length of selectedCards if user chooses not to discard full amount

            for (int i = 0; i < selectedCards.Length; i++)
            {
                Hand.Remove(selectedCards[i]);
            }
            
        }

    }

}

