using System.Collections.Generic;

namespace GodHandObjects
{
    internal class AttributesContainer
    {
        private Dictionary<Attribute, int> _attribDict = new Dictionary<Attribute, int>(6)
        {
            {Attribute.Strenght, 10},
            {Attribute.Agility, 10},
            {Attribute.Resilience, 10},
            {Attribute.Concentration, 10},
            {Attribute.Knowledge, 10},
            {Attribute.Intelligence , 10}
        };

        public int this[Attribute attrib]
        {
            get { return _attribDict[attrib]; }
            set { _attribDict[attrib] = value; }
        }
    }

    internal class SubAttributesContainer
    {
        private Dictionary<SubAttribute, float> _subAttribDict = new Dictionary<SubAttribute, float>
        {
            
        };

        public float this[SubAttribute attrib]
        {
            get { return _subAttribDict[attrib]; }
            set { _subAttribDict[attrib] = value; }
        }
    }
}