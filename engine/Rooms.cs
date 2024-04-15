using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace engine
{
    public class Rooms
    {
        public string RoomName { get; set; }
        public bool IsMonsterPresent { get; set; }
        public bool IsEscapePodPresent { get; set; }

        public Rooms(string roomName, bool isMonsterPresent, bool isEscapePodPresent)
        {
            RoomName = roomName;
            IsMonsterPresent = isMonsterPresent;
            IsEscapePodPresent = isEscapePodPresent;
        }
    }
}
