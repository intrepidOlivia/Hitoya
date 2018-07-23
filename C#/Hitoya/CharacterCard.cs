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

        Program Game;
        String cName, fText;

        //private Dictionary<String, int> ModifyHand;
        //private Dictionary<PowerTokens, int> PowerTokens;

        public CharacterCard()
        {
            //Load character information from file (performed in the superclass)
        }

        //public CharacterCard(Dictionary<String, int> modifyValues, Dictionary<PowerTokens, int> tokenValues)
        //{
        //    //Assign ModifyHand values (how many cards the card will discard or draw)
        //    ModifyHand = modifyValues;

        //    //Assign Power Token values (how many power tokens the card will take)
        //    PowerTokens = tokenValues;
        //}

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
                    activePlayer.AddToken(TokenTypes.life);
                    activePlayer.AddToken(TokenTypes.chaos);
                    activePlayer.AddToken(TokenTypes.rotate);
                    activePlayer.AddToken(TokenTypes.death);
                    break;
                case "Cecil":
                    activePlayer.DrawCard(5);
                    break;
                case "Pierre":
                    activePlayer.Discard(1);
                    activePlayer.DrawCard(4);
                    activePlayer.AddToken(TokenTypes.life);
                    break;
                case "Sidney":
                    activePlayer.Discard(1);
                    activePlayer.DrawCard(3);
                    activePlayer.AddToken(TokenTypes.death);
                    activePlayer.AddToken(TokenTypes.death);
                    break;
                case "Lisa":
                    activePlayer.DrawCard(3);
                    activePlayer.AddToken(TokenTypes.death);
                    activePlayer.AddToken(TokenTypes.life);
                    break;
                case "Duncan":
                    activePlayer.DrawCard(3);
                    activePlayer.AddToken(TokenTypes.rotate);
                    activePlayer.AddToken(TokenTypes.chaos);
                    break;
                case "Steve":
                    activePlayer.DrawCard(3);
                    activePlayer.AddToken(PowerToken.SelectToken().type);
                    break;
                case "Burt":
                    activePlayer.DrawCard(3);
                    activePlayer.AddToken(TokenTypes.chaos);
                    activePlayer.AddToken(TokenTypes.life);
                    break;
                case "CAIIT":
                    activePlayer.DrawCharCard(2);
                    break;
                case "Ella":
                    activePlayer.Discard(1);
                    activePlayer.DrawCard(4);
                    activePlayer.AddToken(TokenTypes.death);
                    break;
                case "Ada":
                    activePlayer.Discard(1);
                    activePlayer.DrawCard(3);
                    activePlayer.AddToken(TokenTypes.life);
                    activePlayer.AddToken(TokenTypes.life);
                    break;
                case "Hoshi":
                    activePlayer.Discard(1);
                    activePlayer.DrawCard(4);
                    activePlayer.AddToken(TokenTypes.chaos);
                    break;
                case "Jay":
                    activePlayer.DrawCard(3);
                    activePlayer.AddToken(TokenTypes.rotate);
                    activePlayer.AddToken(TokenTypes.life);
                    break;
                case "John":
                    activePlayer.DrawCard(3);
                    activePlayer.AddToken(TokenTypes.chaos);
                    activePlayer.AddToken(TokenTypes.death);
                    break;
                case "Abe":
                    activePlayer.DrawCard(1);
                    Player[] players = activePlayer.Game.GetPlayers();
                    for (int i = 0; i < players.Length; i++)
                    {
                        players[i].TokenInventory.Clear();
                    }
                    break;
                case "Pete":
                    //TODO: Figure out what to do with Pete: should there be a finite amount of
                    //power tokens available? or should Pete be utilized to do something else?
                    break;
                case "Raymond":
                    activePlayer.Discard(1);
                    activePlayer.DrawCard(3);
                    activePlayer.AddToken(TokenTypes.rotate);
                    activePlayer.AddToken(TokenTypes.rotate);
                    break;
                case "Daisy":
                    activePlayer.Discard(3);
                    activePlayer.DrawCard(4);
                    break;
            }
        }

    }
}
