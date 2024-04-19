using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace engine
{
    public static class World
    {
        //Config

        public static List<Room> RoomMap = new List<Room>();
        public static List<Monster> MonsterList = new List<Monster>();
        public static List<int> EscapePodLocations = new List<int>();

        public const int NUMBER_OF_ROOMS = 9;
        public const int NUMBER_OF_MONSTERS = 3;
        public const int NUMBER_OF_ESCAPE_PODS = 1;

        static World()
        {
            populateMonsterList();
            populateEscapePodLocations();
            populateRoomMap();
        }

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


        }
    }
}  