using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GodHandObjects
{
    class Race
    {
        public AttributesContainer Modifier { get; private set; }
        private HashSet<SkillID>[] _skillsPerLvl = new HashSet<SkillID>[30];

        public HashSet<SkillID> GetSkillsOnLevel(int level)
        {
                return _skillsPerLvl[level];
        }
    }
}
