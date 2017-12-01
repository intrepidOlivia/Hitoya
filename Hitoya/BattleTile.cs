using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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

        //const int NORTHINDEX = 0;
        //const int EASTINDEX = 1;
        //const int SOUTHINDEX = 2;
        //const int WESTINDEX = 3;

        public CardEdge[] Edges = new CardEdge[4];
        bool occupied;
        PlayingField.Slot Location;

        public bool isOccupyable;
        Player occupiedBy;
        String token = "";

        public BattleTile(XmlNode tile)
        {
            XmlNodeList edges = tile.ChildNodes;
            for (int i = 0; i < edges.Count; i++)
            {
                Edges[i] = new CardEdge(edges[i], this);
            }
        }

        public String ActiveToken
        {
            get { return token; }
            set { token = value; }
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
        /// Rotates the battle tile
        /// </summary>
        public void Rotate()
        {
            //Retrieve user input about whether to rotate clockwise or counterclockwise

            //Reassign the adjacent values of each card edge


        }

        public static void PlaceTile(BattleTile placedCard, PlayingField.Slot placedSlot)
        {
            //Place into PlayingField Slot
            placedCard.Location = placedSlot;

            //Retrieve information about which edges are placed where

            for (int i = 0; i < placedCard.Edges.Length; i++)
            {

                //Place each edge. Submit either a slot or an edge as an argument depending on whether adjacent slot is empty or not

            }

        }

        /// <summary>
        /// Contains an attack value and an opposite edge (on the same tile)
        /// Also contains an Adjacent Slot and and Adjacent Edge (after being placed)
        /// </summary>
        public class CardEdge
        {

            BattleTile parentTile;
            AttackTypes attack;
            public PlayingField.Slot AdjacentSlot;
            public BattleTile.CardEdge AdjacentEdge, OppositeEdge;
            
            //public enum orientation { xpos, xneg, ypos, yneg }
            //orientation rotationDir;

           /// <summary>
           /// Creates a new Card Edge and assigns it an attack value based on the XML information.
           /// </summary>
            public CardEdge(XmlNode xmlnode, BattleTile parent)
            {
                switch (xmlnode.InnerText)
                {
                    case "1":
                        attack = AttackTypes.one;
                        break;
                    case "2":
                        attack = AttackTypes.two;
                        break;
                    case "3":
                        attack = AttackTypes.three;
                        break;
                    case "4":
                        attack = AttackTypes.four;
                        break;
                    case "5":
                        attack = AttackTypes.five;
                        break;
                    case "6":
                        attack = AttackTypes.six;
                        break;
                    case "spear":
                        attack = AttackTypes.spear;
                        break;
                    case "shield":
                        attack = AttackTypes.shield;
                        break;
                }

                parentTile = parent;
            }

            /// <summary>
            /// Assigns a card edge to its connecting Slot. Call this PlaceEdge method if adjacent slot is empty
            /// </summary>
            public void PlaceEdge(PlayingField.Slot slot)
            {
                OppositeEdge = GetOppositeEdge();
                AdjacentSlot = slot;
            }

            /// <summary>
            /// Assigns a card edge to its connecting Edge. Call this PlaceEdge method if adjacent slot contains a battle tile
            /// </summary>
            public void PlaceEdge(CardEdge adjEdge)
            {
                AdjacentEdge = adjEdge;
                OppositeEdge = GetOppositeEdge();

                AdjacentSlot = adjEdge.parentTile.Location;
                AdjacentEdge.AdjacentEdge = this;           //The adjacent of my adjacent is me
            }

            /// <summary>
            /// Determines the opposite edge of this edge, based on the parent tile's configuration
            /// </summary>
            private CardEdge GetOppositeEdge()
            {
                switch (Array.IndexOf(parentTile.Edges, this))
                {
                    case 0:
                        return parentTile.Edges[2];
                    case 1:
                        return parentTile.Edges[3];
                    case 2:
                        return parentTile.Edges[0];
                    case 3:
                        return parentTile.Edges[1];
                }

                return null;
            }

            public AttackTypes AttackValue
            {
                get { return attack; }
            }

        }

        

    }

    

}
