using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace engine
{
    public static class World
    {
        //Config
        public static List<Monster> MonsterList = new List<Monster>();
        public static List<int> EscapePodLocations = new List<int>();
        public static List<Room> RoomMap = new List<Room>();
        
        public const int NUMBER_OF_MONSTERS = 3;
        public const int NUMBER_OF_ESCAPE_PODS = 1;
        public const int NUMBER_OF_ROOMS = 9;
        public const int PLAYERS_STARTING_OXYGEN = 100;
        public const int PLAYERS_STARTING_SUITINTEGRITY = 100;
        public const string PLAYERS_STARTING_ROOM = "Room_1";

        //Constructor
        static World()
        {
            populateMonsterList();
            populateEscapePodLocations();
            populateRoomMap();
        }

        //Methods
        private static void populateMonsterList ()
        {
            MonsterList.Clear();
        
            for (int i = 0; i < NUMBER_OF_MONSTERS; i++) 
            {
                MonsterList.Add(new Monster(100,i));
            }
        }
        private static void populateEscapePodLocations() 
        {
            EscapePodLocations.Clear();

            Random random = new Random();
            
            for (int i = 0; i < NUMBER_OF_ESCAPE_PODS; i++)
            {
                EscapePodLocations.Add(random.Next(8));
            }
        }
        private static void populateRoomMap() { 
        
            RoomMap.Clear();

            for (int i = 0; i < NUMBER_OF_ROOMS; i++)
            {
                RoomMap.Add(new Room("Room_" + i,null, false));
            }
        }
    }
}  