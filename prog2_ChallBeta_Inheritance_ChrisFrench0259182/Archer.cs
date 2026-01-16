using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace prog2_ChallBeta_Inheritance_ChrisFrench0259182
{
    internal class Archer : Character

    {
        public Archer(string name) : base(name, 120, 18, 8, 15)
        {

        }
        public override void Attack(Character target)
        {
            base.Attack(target);
         
            if (rando.Next(0, 100) < 30) // chance  for rapid shot 
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"{_name} is as quick as an oil covered snake shot from a cannon...and attacks a second time!");
                base.Attack(target);
                Console.ReadKey(true);
            }
        }

       
    }
}
