using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace prog2_ChallBeta_Inheritance_ChrisFrench0259182
{
    internal class Orc : Character
    {
        public Orc(string name) : base(name, 150, 5, 10, 25)
        {
           // Console.WriteLine($"\n Orc attacks maybe");
        }

        public override void Attack(Character target)
        {
            base.Attack(target);
           
            int heal = 10; //Thrill of combat adrenaline healing
            _health += heal;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Adreanaline, rage, and the thrill of battle invigorates {_name}, they heal for {heal}!");
            Console.ReadKey(true);
        }

    

    }
}
