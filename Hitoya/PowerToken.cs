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
    { blank, counter, chaos, death, rotate }

    class PowerToken
    {

        public TokenTypes type;

        public PowerToken(TokenTypes tokenType)
        {
            type = tokenType;
        }

    }
}
