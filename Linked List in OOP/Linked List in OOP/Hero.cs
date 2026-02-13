using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List_in_OOP
{
    internal class Hero
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Power { get; set; }

        public Hero(int id, string name, string power)
        {
            Id = id;
            Name = name;
            Power = power;
        }
    }
}
