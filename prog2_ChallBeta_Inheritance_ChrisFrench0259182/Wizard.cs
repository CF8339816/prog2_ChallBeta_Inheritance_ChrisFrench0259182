using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace prog2_ChallBeta_Inheritance_ChrisFrench0259182
{
    internal class Wizard : Character

    {
        public Wizard(string name) : base(name, 75, 8, 15, 40)
        {
         // Console.WriteLine($"\n wizard attacks maybe");
        }
           

        public override void TakeDamage(int damage)// cool ability spell:damage reflect, reflects damage back to attacker
        {
           //int reflect = damage;
            if (rando.Next(0, 100) < 20)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"{_name} casts a spell to asorbe , empower and reflect Damage  back to attacker");
                int reducedDamage = 0;
                base.TakeDamage(reducedDamage);
                Console.ReadKey(true);
            }
           //Reflect(Character target);

        }

        //public void Reflect(Character target)
        //{
        //    Console.Write("Spellblast attack! ");
        //    base.Attack(target);
        //    base.Attack(target);
        //    base.Attack(target);


        //    //target._health-damage;
        //}


        public override void Attack(Character target)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Spellblast attack! ");
            base.Attack(target);
            Console.ReadKey(true);

            //target._health-damage;
        }
    


    }
       
}

