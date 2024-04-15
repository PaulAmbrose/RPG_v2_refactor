using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace engine
{
    public class Room
    {
        public string RoomName { get; set; }
        public Monster MonsterLivingHere { get; set; }
        public bool IsEscapePodPresent { get; set; }

        public Room(string roomName, Monster monsterLivingHere, bool isEscapePodPresent)
        {
            RoomName = roomName;
            MonsterLivingHere = monsterLivingHere; 
            IsEscapePodPresent = isEscapePodPresent;
        }
    }
}
