using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2_ChallBeta_Inheritance_ChrisFrench0259182
{
    internal class Program
    {       
        
            //static Random combatant1 = new Random(1, 4);
            //static Random combatant2 = new Random(1, 4);
        
        
        static void Main(string[] args)
        {
            Character player1 = new Archer("PewPew Pointystick");
            Character player2 = new Orc("Smashie McStabface");
            Character player3 = new Wizard("Bearddress Zappyfingers");


             Random combatant1 = new Random(1, 4);
             Random combatant2 = new Random(1, 4);

            if (combatant1 =  1)
            {
                Character attacker = player1;
            }

            if (combatant1 = 2)
            {
                Character attacker = player2;
            }

            if (combatant1 = 3)
            {
                Character attacker = player3;
            }

            if (combatant2 = 1)
            {
                Character defender = player1;
            }

            if (combatant2 = 2)
            {
                Character defender = player2;
            }

            if (combatant2 = 3)
            {
                Character defender = player3;
            }



        }
    }

  

    public class Character
    {
        public string _name { get; set; }
        public int _health { get; set; }
        public int _speed { get; set; }
        public int _minAttack { get; set; }
        public int _maxAttack { get; set; }

        protected Random rando = new Random(); //allows rando to be accessed by inherators of the class character
       
     public Character(string name, int health, int speed, int minAtk, int maxAtk)
        {
            _name = name;
            _health = health;
            _speed = speed;
            _minAttack = minAtk;
            _maxAttack = maxAtk;
        }


  
    }
}
