using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch17Inheritance
{
    public class Dolphin:Mammal_inwater_
    {
       public override void Eating ()
        {
            Console.WriteLine("Food : JellyFish and Octopus");
        }
        public override void Breathing()
        {
            Console.WriteLine("Breath : They don't breath in underwater,only breath on watersurface.");
        }
        public override void Sleeping()
        {
            Console.WriteLine("Sleep :  While Dophil sleep with half of their brain shut out , other brain is active.");
        }
    }
}
