using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hitoya
{
    /// <summary>
    /// A character card object. Information about the character is loaded from file.
    /// </summary>
    class CharacterCard : Card
    {
        public static String SAVEFILENAME = "CharacterCards.bin";

        String cName, fText;

        private Dictionary<String, int> ModifyHand;
        private Dictionary<PowerTokens, int> PowerTokens;

        public CharacterCard()
        {
            //Load character information from file (performed in the superclass)
        }

        public CharacterCard(Dictionary<String, int> modifyValues, Dictionary<PowerTokens, int> tokenValues)
        {
            //Assign ModifyHand values (how many cards the card will discard or draw)
            ModifyHand = modifyValues;

            //Assign Power Token values (how many power tokens the card will take)
            PowerTokens = tokenValues;
        }

        public String Name
        {
            get { return cName; }
        }

        public String FlavorText
        {
            get { return fText; }
        }

        public static void PlayCharacterCard(Player activePlayer, CharacterCard playCard)
        {
            switch (playCard.Name)
            {
                case "Isaac":
                    activePlayer.Discard(1);
                    activePlayer.DrawCard(4);
                    activePlayer.AddToken(TokenTypes.rotate);
                    break;
                case "Meng":
                    activePlayer.Discard(5);
                    for (int i = 0; i < 2; i++)
                    {
                        activePlayer.AddToken(TokenTypes.chaos);
                    }
                    activePlayer.AddToken(TokenTypes.death);
                    break;
                case "Evan":
                    break;
                case "Cecil":
                    break;
                case "Pierre":
                    break;
                case "Sidney":
                    break;
                case "Lisa":
                    break;
                case "Duncan":
                    break;
                case "Steve":
                    break;
                case "Burt":
                    break;
                case "CAIIT":
                    break;
                case "Ella":
                    break;
                case "Ada":
                    break;
                case "Hoshi":
                    break;
                case "Jay":
                    break;
                case "John":
                    break;
                case "Abe":
                    break;
                case "Pete":
                    break;
                case "Raymond":
                    break;
                case "Daisy":
                    break;
            }
        }

    }
}
