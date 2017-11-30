using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hitoya
{
    /// <summary>
    /// The playing field on which battle tiles will be placed.
    /// This object contains location data for all placed cards.
    /// 
    /// </summary>
    static class PlayingField
    {

        //public enum rotation { xpos, xneg, ypos, yneg }
        //public static BattleTile A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P;
        //public static BattleTile[] Field = new BattleTile[] { A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P };
        public static Slot[,] Field = new Slot[4,4];

        /// <summary>
        /// Sets up the playing field with empty slots
        /// </summary>
        static PlayingField()
        {

            for (int i = 0; i < Field.GetLength(0); i++)
            {
                for (int j = 0; j < Field.GetLength(0); j++)
                {
                    Field[i, j] = new Slot(i, j);
                }
            }
        }

        /// <summary>
        /// Places a battle tile in a slot.
        /// </summary>
        public static void PlaceTile(BattleTile tile, int y, int x)
        {
            Field[y, x].Tile = tile;
        }

        /// <summary>
        /// A slot may contain a Battle Tile.
        /// </summary>
        public class Slot
        {
            BattleTile placed;
            bool isEmpty;
            int x, y;

            public Slot(int row, int col)
            {
                placed = null;
                isEmpty = true;
                y = row;
                x = col;
            }

            public int[] location
            {
                get { return new int[] { y, x }; }
            }

            public BattleTile Tile
            { get { return placed; }
                set {
                    placed = value;
                    isEmpty = false;
                }
            }

            public rotation NorthDirection
            { get { return nDir; } }


        }


    }
}
