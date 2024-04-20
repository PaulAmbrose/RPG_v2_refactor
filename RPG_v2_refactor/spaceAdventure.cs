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
            _PlayerNumber1 = new Player(200, 200, "Room1", false, false);
            updateOxygenLevelOnScreen(_PlayerNumber1.OxygenLevel);
            updatePlayerSuitIntegrityOnScreen(_PlayerNumber1.SuitIntegrity);
            


        }

        private void updateOxygenLevelOnScreen(int oxyGenLevel) 
        {
            oxygenLevel.Text = _PlayerNumber1.OxygenLevel.ToString() + "%";
        }

        private void updatePlayerSuitIntegrityOnScreen(int suitIntegrityPercent)
        {
            suitIntegrity.Text = _PlayerNumber1.SuitIntegrity.ToString() + "%";
        }

    }
}
