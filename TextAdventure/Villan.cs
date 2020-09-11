using System;
using System.Collections.Generic;
using System.Text;

namespace TextAdventure
{
    class Villan : ICharacter
    {

        public Villan(string name, string _class, int att, int def, int hp)
        {
            Name = name;
            Class = _class;
            Attack = att;
            Defend = def;
            HitPoints = hp;
        }

        public string Name { get; set; }
        public string Class { get; set; }
        public int Attack { get; set; }
        public int Defend { get; set; }
        public int HitPoints { get; set; }
    }

}
