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
    /// The field has 16 open slots, labeled A - P.
    /// </summary>
    static class PlayingField
    {

        public enum rotation { xpos, xneg, ypos, yneg }
        public static BattleTile A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P;
        public static BattleTile[] Field = new BattleTile[] { A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P };

        static PlayingField()
        {

            for (int i = 0; i < Field.Length; i++)
            {
                Field[i] = null;
            }
        }

        /// <summary>
        /// A slot bears a label, and may contain a Battle Tile. A Battle Tile must be assigned with a North Direction
        /// </summary>
        public class Slot
        {
            BattleTile placed;
            rotation nDir;
            char name;

            public BattleTile PlacedTile
            { get { return placed; } }

            public rotation NorthDirection
            { get { return nDir; } }

            public Char Name
            { get { return name; } }

        }


    }
}
