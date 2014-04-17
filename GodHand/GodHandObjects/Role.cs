using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GodHandObjects
{
    class Role
    {
        private HashSet<SkillID>[] _skillsPerLvl = new HashSet<SkillID>[30];

        public HashSet<SkillID> GetSkillsOnLevel(int level)
        {
            return _skillsPerLvl[level];
        }
        public MagicEnergy EnergyType { get; private set; }

    }
}
