using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hitoya
{
    /// <summary>
    /// There may only be two players at any given time. Each Player has a Hand, an Inventory, and a Score.
    /// </summary>
    class Player
    {

        String playerName;
        public ArrayList Hand;
        int captured;       //How many enemy tokens the player has captured

        public Player()
        {

        }

        public Player(String nameInput)
        {
            playerName = nameInput;
        }

        public String Name
        {
            get { return playerName; }
            set { playerName = value; }
        }

        /// <summary>
        /// Retrieves the player name from some source (either the user's input or some other identity attribute)
        /// </summary>
        private static String GetPlayerName()
        {

            String input = "";

            return input;
        }
    }

}

