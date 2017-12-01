using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Diagnostics;

namespace Hitoya
{
    [Serializable()]
    class Card
    {


        public Card()
        {
            //Load card information from file

            
        }

        public static void LoadGameFile(Program game)
        {
            XmlDocument file = new XmlDocument();
            file.Load("cards.xml");

            XmlNodeList CharCards = file.GetElementsByTagName("CharCard");
            FillCharDeck(game, CharCards);


            XmlNodeList BattleTiles = file.GetElementsByTagName("BattleTile");
            FillTileDeck(game, BattleTiles);

        }

        /// <summary>
        /// Fills the game's character deck from the values in the XML node list
        /// </summary>
        /// <param name="game">The current game</param>
        /// <param name="CharCards">The list of XML nodes containing character card information</param>
        private static void FillCharDeck(Program game, XmlNodeList CharCards)
        {
            Stack<Card> deck = game.CharDeck;
            List<Card> charPile = new List<Card>();

            for (int i = 0; i < CharCards.Count; i++)
            {
                CharacterCard newcard = new CharacterCard(CharCards[i]);
                charPile.Add(newcard);
                //deck.Push(newcard);
            }

            //Shuffle the deck
            ShuffleDeck(deck, charPile);
        }

        private static void FillTileDeck(Program game, XmlNodeList BattleTiles)
        {

            Stack<Card> deck = game.TileDeck;
            List<Card> tilePile = new List<Card>();

            for (int i = 0; i < BattleTiles.Count; i++)
            {
                BattleTile newcard = new BattleTile(BattleTiles[i]);
                tilePile.Add(newcard);
                //deck.Push(newcard);
            }

            //Shuffle the deck
            ShuffleDeck(deck, tilePile);

        }

        /// <summary>
        /// Shuffles the pile of cards and adds them to the deck.
        /// </summary>
        private static void ShuffleDeck(Stack<Card> deck, List<Card> cardPile)
        {

            shuffleCard(new Random(), cardPile, deck);

        }

        /// <summary>
        /// Selects a card at random from the provided List, pushes it onto the deck Stack, and removes that card from the List.
        /// Returns true when cardPile has been reduced to 0 items.
        /// </summary>
        private static bool shuffleCard(Random random, List<Card> cardPile, Stack<Card> deck)
        {

            if (cardPile.Count <= 0)
            {
                return true;
            }

            int index = random.Next(0, cardPile.Count);
            deck.Push(cardPile[index]);
            cardPile.RemoveAt(index);

            return shuffleCard(random, cardPile, deck);

        }

    }
}
