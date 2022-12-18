using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch17Inheritance
{
    public class Cat:Mammal_inland_
    {
        public override void Eating() 
        {
            Console.WriteLine("Food : Only meat");
        }
    }
}
