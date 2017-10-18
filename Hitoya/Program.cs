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

        void Main(string[] args)
        {

            InitiateGame();    

            while (gameOver == false)
            {

                //Determine whose turn it is
                //Initiate that player's turn
                PlayRound(activePlayer);

                //Make changes to the player's hands or the playing field

                //Switch to the next player's turn

            }

        }

        /// <summary>
        /// Initiates the game variables, loads the cards, and creates the two Player objects.
        /// </summary>
        void InitiateGame()
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

        private void PlayRound(Player activePlayer)
        {
            Card cardToPlay;

            //Receive player's input about what card they want to play
            cardToPlay = SelectedCard();

            if (cardToPlay.GetType() == typeof(BattleTile))
            {
                //play battle tile
                PlayBattleTile((BattleTile)cardToPlay);
            }
            else if (cardToPlay.GetType() == typeof(CharacterCard))
            {
                //play character card
                PlayCharacterCard((CharacterCard)cardToPlay);
            }

        }

        /// <summary>
        /// Placeholder method for retrieving user input of card selection
        /// </summary>
        /// <returns></returns>
        private Card SelectedCard()
        {
            return SelectedCard();
        }

        /// <summary>
        /// Performs battle tile activity after user has selected the spot to place the tile.
        /// </summary>
        /// <param name="selectedTile"></param>
        private void PlayBattleTile(BattleTile selectedTile)
        {
            //Player selects spot to place tile

            //Player selects any battle tokens

            //Perform attack, or perform token

            //Finish up any remaining token actions (add counters?)

            //Check to see if the game is over

            //switch active player
        }

        /// <summary>
        /// User selects where on the field to place the tile, from the available options
        /// </summary>
        private void PlaceTile()
        {

        }

        /// <summary>
        /// The active card performs an attack in all cardinal directions
        /// </summary>
        private void PerformAttack(BattleTile activeCard)
        {
            //Determine which directions are defeated

        }

        /// <summary>
        /// Performs an attack by the provided Attacking Card in the given direction
        /// </summary>
        /// <param name="direction"></param>
        /// <param name="attackingCard"></param>
        private void SecondaryAttack(Cardinal direction, BattleTile attackingCard)
        {

            //Check to see if any existing power token is activated (i.e. Rotate)
            if (attackingCard.ActiveToken == "ROTATE")
            {

            }

            //Determines whether the attack will be successful. If it is, call this method again with the next card

            //Capture/exchanges any counters

        }

        /// <summary>
        /// Performs any action based on the character.
        /// </summary>
        /// <param name="selectedCard"></param>
        private void PlayCharacterCard(CharacterCard selectedCard)
        {
            CharacterCard.PlayCharacterCard(activePlayer, selectedCard);

        }

    }
}
