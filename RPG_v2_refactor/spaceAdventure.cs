﻿using System;
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
            World.WorldCreation();
            _PlayerNumber1 = new Player(World.PLAYERS_STARTING_OXYGEN,
                                        World.PLAYERS_STARTING_SUITINTEGRITY,
                                        World.PLAYERS_STARTING_ROOM_X,
                                        World.PLAYERS_STARTING_ROOM_Y,
                                        false,
                                        false);
            updateOxygenLevelOnScreen(_PlayerNumber1.OxygenLevel);
            updatePlayerSuitIntegrityOnScreen(_PlayerNumber1.SuitIntegrity);
            updatePlayersCurrentRoomOnScreen();
        }

        private void updateOxygenLevelOnScreen(int oxyGenLevel)
        {
            oxygenLevel.Text = oxyGenLevel.ToString() + "%";
        }

        private void updatePlayerSuitIntegrityOnScreen(int suitIntegrityPercent)
        {
            suitIntegrity.Text = suitIntegrityPercent.ToString() + "%";
        }

        public void updatePlayersCurrentRoomOnScreen()
        {
            outputScreen.Text = "You are in room " + World.RoomMap[_PlayerNumber1.CurrentLocation_x, _PlayerNumber1.CurrentLocation_y].ToString();
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
            
        }

    }
}
