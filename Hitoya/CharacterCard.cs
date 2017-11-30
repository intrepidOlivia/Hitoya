using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Hitoya
{

    public enum SpecialTypes
    {
        DrawCharCard,
        ClearTokens,
        SelectToken
    }

    /// <summary>
    /// A character card object. Information about the character is loaded from file.
    /// </summary>
    class CharacterCard : Card
    {
        public static String SAVEFILENAME = "CharacterCards.bin";

        Program Game;
        public int Draws, Discards;
        public List<PowerToken> TokensGet = new List<PowerToken>();
        public List<SpecialTypes> Specials = new List<SpecialTypes>();
        public String Name, FlavorText;

        //private Dictionary<String, int> ModifyHand;
        //private Dictionary<PowerTokens, int> PowerTokens;

        public CharacterCard()
        {
            //Load character information from file (performed in the superclass)
        }

        /// <summary>
        /// Retrieves all attributes of a character card from an XML node
        /// </summary>
        public CharacterCard(XmlNode xmlCard)
        {
            Name = xmlCard["Name"].InnerText;
            XmlNodeList elements = xmlCard.ChildNodes;

            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i].Name == "Draw")
                {
                    int.TryParse(elements[i].InnerText, out Draws);
                }

                if (elements[i].Name == "Discard")
                {
                    int.TryParse(elements[i].InnerText, out Discards);
                }

                if (elements[i].Name == "AddToken")
                {
                    TokensGet.Add(new PowerToken(elements[i].InnerText));
                }

                if (elements[i].Name == "Special")
                {
                    switch (elements[i].InnerText)
                    {
                        case "DrawCharCard":
                            Specials.Add(SpecialTypes.DrawCharCard);
                            break;
                        case "ClearTokens":
                            Specials.Add(SpecialTypes.ClearTokens);
                            break;
                        case "SelectToken":
                            Specials.Add(SpecialTypes.SelectToken);
                            break;
                    }
                }
            }


        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="activePlayer">The active character</param>
        /// <param name="playCard">The card being played</param>
        public static void PlayCharacterCard(Player activePlayer, CharacterCard playCard)
        {
            //Handle draws

            //Handle discards

            //Handle token acquisition

            //Handle any specials
            
        }

    }
}
