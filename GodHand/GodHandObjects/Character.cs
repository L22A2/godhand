#region Using Statements
using System;
using System.Collections.Generic;
using WaveEngine.Common;
using WaveEngine.Common.Graphics;
using WaveEngine.Framework;
using WaveEngine.Framework.Services;
#endregion

namespace GodHandObjects
{
    internal class Character
    {
        public AttributesContainer Attribs { get; private set; }
        public SubAttributesContainer SubAttribs { get; private set; }
        public Race CharacterRace { get; set; }

        private HashSet<SkillID> Skills = new HashSet<SkillID>();
        public int HealthPoints { get; set; }

    }
}
