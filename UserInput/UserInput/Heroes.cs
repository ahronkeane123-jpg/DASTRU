using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput
{
    internal class Heroes
    {
        public string Name { get; set; }
        public string Power { get; set; }
        
       

        public Heroes(string name, string power)
        {
            Name = name;
            Power = power;        
      
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Hero Name: {Name}");
            Console.WriteLine($"Power: {Power}");
        }
    }

    class Marvel : Heroes
    {
        public string RealName { get; set; }

        public Marvel(string name, string power, string realName)
            : base(name, power)
        {
            RealName = realName;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("Details of Heroes");
            Console.WriteLine();
            Console.WriteLine($"RealName: {RealName}");
            base.DisplayInfo();
        }


    }
    class DC : Heroes
    {
        public int Age { get; set; }

        public DC (string name, string power, int age )
            : base(name, power)
        {
            Age = age;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("Details of Heroes");
            Console.WriteLine();
            Console.WriteLine($"Age: {Age} ");
            base.DisplayInfo();

        }
    }
}
