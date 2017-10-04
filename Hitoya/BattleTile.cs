using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hitoya
{
    /// <summary>
    /// A battle tile object. Each of the battle tile's four edges is labeled with a value, indicating its offensive/defensive capabilities.
    /// A battle tile may only be placed adjacent to another battle tile.
    /// </summary>
    class BattleTile : Card
    {

        public static String SAVEFILENAME = "BattleTiles.bin";
            
        /// <summary>
        /// Indicating the value of a battle tile's attack function
        /// </summary>
        public enum AttackTypes
        { one, two, three, four, five, six, spear, shield }

        /// <summary>
        /// Indicating the type of marker that may populate the battle tile
        /// </summary>
        public enum MarkerTypes
        { blank, counter, chaos, death, rotate }

        const int NORTHINDEX = 0;
        const int EASTINDEX = 1;
        const int SOUTHINDEX = 2;
        const int WESTINDEX = 3;

        CardEdge[] Edges;
        bool occupied;
        public bool isOccupyable;
        Player occupiedBy;

        public BattleTile()
        {
            //Load battle tile information from file (performed in the superclass)
        }

        /// <summary>
        /// Constructor for initial game data saving
        /// </summary>
        /// <param name="nValue">North edge value</param>
        /// <param name="eValue">East edge value</param>
        /// <param name="sValue">South edge value</param>
        /// <param name="wValue">West edge value</param>
        /// <param name="occupyable">Is tile occupyable by default</param>
        public BattleTile(AttackTypes nValue, AttackTypes eValue, AttackTypes sValue, AttackTypes wValue, bool occupyable)
        {

            Edges = new CardEdge[4];

            Edges[0] = new CardEdge("N", nValue);
            Edges[1] = new CardEdge("E", eValue);
            Edges[2] = new CardEdge("S", sValue);
            Edges[3] = new CardEdge("W", wValue);

            isOccupyable = occupyable;

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
        /// Places a counter on the tile
        /// </summary>
        public void OccupyTile(Player occupier)
        {
            occupiedBy = occupier;
            occupied = true;
        }

        /// <summary>
        /// Remove all counters from the tile (as when the Death card is played)
        /// </summary>
        private void DeoccupyTile()
        {
            occupiedBy = null;
            occupied = false;
        }

        /// <summary>
        /// Indicates whether the battle tile has a counter placed on it
        /// </summary>
        public bool IsOccupied
        {
            get { return occupied; }
        }

        /// <summary>
        /// Contains a cardinal direction and an attack value, defining the card's directional attributes
        /// </summary>
        private class CardEdge
        {

            public enum Cardinal { N, E, S, W }

            Cardinal cDir;
            AttackTypes attack;


            public CardEdge(String dir, AttackTypes type)
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
