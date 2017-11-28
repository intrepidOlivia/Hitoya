using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hitoya
{
    /// <summary>
    /// Indicating the type of marker that may populate a battle tile
    /// </summary>
    public enum TokenTypes
    { blank, life, chaos, death, rotate }

    class PowerToken
    {

        public TokenTypes type;

        private PowerToken()
        { }

        public PowerToken(TokenTypes tokenType)
        {
            type = tokenType;
        }

        /// <summary>
        /// Creates a power token based on the provided string;
        /// </summary>
        /// <param name="tokenTypeStr"></param>
        public PowerToken(String tokenTypeStr)
        {
            switch (tokenTypeStr)
            {
                case "Life":
                    type = TokenTypes.life;
                    break;
                case "Chaos":
                    type = TokenTypes.chaos;
                    break;
                case "Death":
                    type = TokenTypes.death;
                    break;
                case "Rotate":
                    type = TokenTypes.rotate;
                    break;
                default:
                    type = TokenTypes.blank;
                    break;
            }
        }

        /// <summary>
        /// Prompts the player to select a power token
        /// </summary>
        public static PowerToken SelectToken()
        {
            PowerToken selectedToken = new PowerToken();

            //Temporary: replace with user input
            selectedToken.type = TokenTypes.blank;

            return selectedToken;
        }

    }


}
