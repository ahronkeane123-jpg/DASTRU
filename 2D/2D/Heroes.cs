using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D
{
    class Heroes
    {
        public string Name { get; set; }
        public string Power { get; set; }
        public string Universe { get; set; }
        public string Alignment { get; set; }
        public string Team { get; set; }

        public Heroes (string name, string power, string universe, string alignment, string team)
        {
            Name = name;
            Power = power;
            Universe = universe;
            Alignment = alignment;
            Team = team;
        }
    }
}
