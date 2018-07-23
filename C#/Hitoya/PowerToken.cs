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
