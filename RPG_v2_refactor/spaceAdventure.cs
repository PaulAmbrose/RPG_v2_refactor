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

            _PlayerNumber1 = new Player(World.PLAYERS_STARTING_OXYGEN,
                                        World.PLAYERS_STARTING_SUITINTEGRITY,
                                        World.PLAYERS_STARTING_ROOM_X,
                                        World.PLAYERS_STARTING_ROOM_Y,
                                        false,
                                        false);
            updateOxygenLevelOnScreen(_PlayerNumber1.OxygenLevel);
            updatePlayerSuitIntegrityOnScreen(_PlayerNumber1.SuitIntegrity);
            updatePlayersCurrentRoomOnScreen(_PlayerNumber1.CurrentLocation);


        }

        private void updateOxygenLevelOnScreen(int oxyGenLevel)
        {
            oxygenLevel.Text = oxyGenLevel.ToString() + "%";
        }

        private void updatePlayerSuitIntegrityOnScreen(int suitIntegrityPercent)
        {
            suitIntegrity.Text = suitIntegrityPercent.ToString() + "%";
        }

        private void updatePlayersCurrentRoomOnScreen(string room)
        {
            outputScreen.Text = outputScreen.Text + "You are in " + room.ToString() + "\n";
        }

        private void forwardsButton_Click(object sender, EventArgs e)
        {
            movePlayerTo(0,0);
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            movePlayerTo(0, 0);
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            movePlayerTo(0, 0);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            movePlayerTo(0, 0);
        }

        private void FIRE_Click(object sender, EventArgs e)
        {

        }
        private void movePlayerTo(int currentLocation, int newLocation)
        {
            updatePlayersCurrentRoomOnScreen(_PlayerNumber1.CurrentLocation);
        }

    }
}
