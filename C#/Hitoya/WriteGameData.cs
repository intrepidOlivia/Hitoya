using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hitoya
{
    public partial class WriteGameData : Form
    {

        ArrayList charCards;
        ArrayList battleTiles;

        public WriteGameData()
        {
            InitializeComponent();
        }

        private void button_Next_Click(object sender, EventArgs e)
        {

            if (radio_Battle.Checked == true)
            {
                //

                BattleTile newcard = new BattleTile();


                battleTiles.Add(newcard);
            }
            else if (radio_Character.Checked == true)
            {

                //

                CharacterCard newcard = new CharacterCard();
                charCards.Add(newcard);
            }

        }
    }
}
