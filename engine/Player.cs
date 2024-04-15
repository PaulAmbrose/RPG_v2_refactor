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
        public string CurrentLocation { get; set; }
        public bool InFight { get; set; }
        public bool WithEscapePod { get; set; }

        public Player(int oxygenLevel, int suitIntegrity, string currentLocation, bool inFight, bool withEscapePod)
        {
            OxygenLevel = oxygenLevel;
            SuitIntegrity = suitIntegrity;
            CurrentLocation = currentLocation;
            InFight = inFight;
            WithEscapePod = withEscapePod;
        }
    }
}
