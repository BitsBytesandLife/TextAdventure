using System;
using System.Collections.Generic;
using System.Text;

namespace TextAdventure
{
    interface ICharacter
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public int Attack { get; set; }
        public int Defend { get; set; }
        public int HitPoints { get; set; }
    }
}
