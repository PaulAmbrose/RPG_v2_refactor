using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace engine
{
    public class Monster
    {
        public int MonsterSuitIntegrity { get; set; }
        public int MonsterName { get; set; }

        public Monster(int monsterSuitIntegrity, int monsterName)
        {
            MonsterSuitIntegrity = monsterSuitIntegrity;
            MonsterName = monsterName;
        }
    }
}
