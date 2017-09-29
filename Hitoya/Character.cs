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
    class Character : Card
    {
        String cName, fText;

        private Dictionary<String, int> ModifyHand;
        private Dictionary<Program.PowerTokens, int> PowerTokens;

        private Character()
        {
            //Load character information from file

            //Assign ModifyHand values

            //Assign Power Token values
        }

        public String Name
        {
            get { return cName; }
        }

        public String FlavorText
        {
            get { return fText; }
        }

    }
}
