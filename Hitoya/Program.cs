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
        public Stack<Card> TileDeck = new Stack<Card>();
        public Stack<Card> CharDeck = new Stack<Card>();
        public Player activePlayer;

        private delegate void RoundCallBack(Card cardToPlay);

        public static void Main(string[] args)
        {

            Program Game = new Program();

            Game.InitiateGame();

            while (gameOver == false)
            {

                //Initiate the active player's turn
                Game.StartRound(Game.activePlayer);

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
            playerOne = new Player("playerOne", this);
            playerTwo = new Player("playerTwo", this);

            //Loads the game file with card information
            Card.LoadGameFile(this);

            //Set up the playing field:
            //Add blank tile to first slot
            BattleTile.PlaceTile(new BattleTile(), PlayingField.Field[0, 0]);

            //Deal hands to players
            DealPlayerHands(playerOne, playerTwo);

            //Select the first player
            activePlayer = playerOne;

        }

        /// <summary>
        /// Each player eventually gets three character cards
        /// </summary>
        private void DealPlayerHands(Player playerOne, Player playerTwo)
        {
            //TODO: Set it up the proper way, dealing six character cards to each player and then swapping between them until each player has three cards

            for (int i = 0; i < 3; i++)
            {
                playerOne.CharHand.Add(this.CharDeck.Pop());
                playerTwo.CharHand.Add(this.CharDeck.Pop());
            }

            TestCharHands(playerOne);
            TestCharHands(playerTwo);

        }

        //Used for testing
        private void TestCharHands(Player player)
        {
            String cardString = "";
            Console.WriteLine(player.Name + "'s hand of character cards:");
            for (int i = 0; i < player.CharHand.Count; i++)
            {
                CharacterCard thiscard = (CharacterCard)player.CharHand[i];
                cardString += thiscard.Name + ", ";
            }
            Console.WriteLine(cardString);
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
        /// Returns an array of all participating players.
        /// </summary>
        /// <returns></returns>
        public Player[] GetPlayers()
        {
            Player[] pList = new Player[2];
            pList[0] = playerOne;
            pList[1] = playerTwo;

            return pList;
        }

        private void StartRound(Player activePlayer)
        {

            //Determine whether player will draw a card or play a character card
            //Temporary
            Console.WriteLine(activePlayer.Name + ": Would you like to draw a card or play a character card? Type D for Draw or C for Character card.");
            string result = Console.ReadLine();

            switch (result)
            {
                case "D":
                    //Player will draw a card
                    activePlayer.TileHand.Add(TileDeck.Pop());

                    //Display Tile Hand to player

                    break;
                case "C":
                    //Player will play a character card
                    CharacterCard.PlayCharacterCard(activePlayer, SelectCard(activePlayer));
                    break;
            }

            Card cardToPlay;

            

        }

        private void PlayCard(Card cardToPlay)
        {
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
        private CharacterCard SelectCard(Player activePlayer)
        {
            //Retrieve card input from the Player
            Console.WriteLine("Please enter the name of character you'd like to play:");
            String charstring = Console.ReadLine();

            foreach (CharacterCard c in activePlayer.CharHand)
            {
                if (c.Name == charstring)
                {
                    Console.WriteLine("You selected card " + c.Name);
                    return c;
                }
            }

            Console.WriteLine("Character Card was not correctly selected.");
            return null;
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

        ///// <summary>
        ///// Performs an attack by the provided Attacking Card in the given direction
        ///// </summary>
        ///// <param name="direction"></param>
        ///// <param name="attackingCard"></param>
        //private void SecondaryAttack(Cardinal direction, BattleTile attackingCard)
        //{

        //    //Check to see if any existing power token is activated (i.e. Rotate)
        //    if (attackingCard.ActiveToken == "ROTATE")
        //    {

        //    }

        //    //Determines whether the attack will be successful. If it is, call this method again with the next card

        //    //Capture/exchanges any counters

        //}

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
