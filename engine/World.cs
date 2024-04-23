using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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
        public static int[,] RoomMap = PopulateRoomMap(NUMBER_OF_ROOMS_X, NUMBER_OF_ROOMS_Y);

        public const int NUMBER_OF_MONSTERS = 3;
        public const int NUMBER_OF_ESCAPE_PODS = 1;
        public const int NUMBER_OF_ROOMS_X = 3;
        public const int NUMBER_OF_ROOMS_Y = 3;
        public const int PLAYERS_STARTING_OXYGEN = 100;
        public const int PLAYERS_STARTING_SUITINTEGRITY = 100;
        public const int PLAYERS_STARTING_ROOM_X = 0;
        public const int PLAYERS_STARTING_ROOM_Y = 0;

        //Constructor
        public static void WorldCreation()
        {
            populateMonsterList();
            populateEscapePodLocations();
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
        public static int[,] PopulateRoomMap(int roomsWide, int roomsHigh)
        {
            int[,] roomMap = new int[roomsWide, roomsHigh];
            int roomCounter = 0;

            for (int width = 0; width < roomsWide; width++)
            {
                for (int height = 0; height < roomsHigh; height++) 
                {
                    roomMap[width, height] = roomCounter;
                    roomCounter++;
                }
            }
            return roomMap;
        }
    }
}  