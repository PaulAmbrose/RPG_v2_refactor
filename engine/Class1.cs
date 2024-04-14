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
        public int suitIntegrity { get; set; }
        public string currentLocation { get; set; }
        public bool inAFight { get; set; }
        public bool withTheEscapePod { get; set; }
    }
}
