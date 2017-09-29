using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hitoya
{
    /// <summary>
    /// A board card object. Each of the board card's four edges is labeled with a value, indicating its offensive/defensive capabilities.
    /// A board card may only be placed adjacent to another board card.
    /// </summary>
    class Board : Card
    {
            
        /// <summary>
        /// Indicating the value of a board card's attack function
        /// </summary>
        public enum AttackTypes
        { one, two, three, four, five, six, spear, shield }

        /// <summary>
        /// Indicating the type of marker that may populate the board card
        /// </summary>
        public enum MarkerTypes
        { blank, token, chaos, death, rotate }

        //TODO: The dual names of "token" and "PowerToken" are ambiguous and will get confusing. Change one of them to a better name.

        const int NORTHINDEX = 0;
        const int EASTINDEX = 1;
        const int SOUTHINDEX = 2;
        const int WESTINDEX = 3;

        CardEdge[] Edges;
        bool isOpen;

        private Board()
        {
            //Load board card information from file
        }

        public AttackTypes NorthValue
        {
            get { return Edges[NORTHINDEX].AttackValue; }
        }

        public AttackTypes EastValue
        {
            get { return Edges[EASTINDEX].AttackValue; }
        }

        public AttackTypes SouthValue
        {
            get { return Edges[SOUTHINDEX].AttackValue; }
        }

        public AttackTypes WestValue
        {
            get { return Edges[WESTINDEX].AttackValue; }
        }

        /// <summary>
        /// Indicates whether the board card may have a token placed on it.
        /// </summary>
        public bool IsOpen
        {
            get { return isOpen; }
            set { isOpen = value; }
        }

        /// <summary>
        /// Contains a cardinal direction and an attack value, defining the card's directional attributes
        /// </summary>
        private class CardEdge
        {

            public enum Cardinal { N, E, S, W }

            Cardinal cDir;
            AttackTypes attack;

            private CardEdge(String dir, AttackTypes type)
            {
                switch (dir)
                {
                    case "N":
                        cDir = Cardinal.N;
                        break;
                    case "E":
                        cDir = Cardinal.E;
                        break;
                    case "S":
                        cDir = Cardinal.S;
                        break;
                    case "W":
                        cDir = Cardinal.W;
                        break;
                }

                attack = type;
            }

            public Cardinal Direction
            {
                get { return cDir; }
            }

            public AttackTypes AttackValue
            {
                get { return attack; }
            }
        }

    }

    

}
