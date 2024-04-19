using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using engine;

namespace RPG_v2_refactor
{
    public partial class spaceAdventure : Form
    {
        private Player _PlayerNumber1;
        public spaceAdventure()
        {
            InitializeComponent();
            _PlayerNumber1 = new Player(100, 100, "Room1", false, false);

            oxygenLevel.Text = _PlayerNumber1.OxygenLevel.ToString() + "%";
            suitIntegrity.Text = _PlayerNumber1.SuitIntegrity.ToString() + "%";

            World.PopulateRooms();
            actionWindow.Text = World.RoomMap.ToString();
        }
    }
}
