using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

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


        }

        /// <summary>
        /// Fills the game's character deck from the values in the XML node list
        /// </summary>
        /// <param name="game">The current game</param>
        /// <param name="CharCards">The list of XML nodes containing character card information</param>
        private static void FillCharDeck(Program game, XmlNodeList CharCards)
        {
            Stack<CharacterCard> deck = game.CharDeck;

            for (int i = 0; i < CharCards.Count; i++)
            {
                CharacterCard newcard = new CharacterCard(CharCards[i]);
                deck.Push(newcard);
                Console.WriteLine(newcard.Name + " added to Character Deck");
            }

        }

        private void FillTileDeck(Program game, XmlNodeList BattleTiles)
        {

        }

    }
}
