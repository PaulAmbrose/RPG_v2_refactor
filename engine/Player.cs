using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace engine
{
    public class Player
    {
        public int OxygenLevel { get; set; }
        public int SuitIntegrity { get; set; }
        public int CurrentLocation_x { get; set; }
        public int CurrentLocation_y { get; set; }
        public bool InFight { get; set; }
        public bool WithEscapePod { get; set; }

        public Player(int oxygenLevel, int suitIntegrity, int currentLocation_x, int currentLocation_y, bool inFight, bool withEscapePod)
        {
            OxygenLevel = oxygenLevel;
            SuitIntegrity = suitIntegrity;
            CurrentLocation_x = currentLocation_x;
            CurrentLocation_y = currentLocation_y;
            InFight = inFight;
            WithEscapePod = withEscapePod;
        }
    }
}
