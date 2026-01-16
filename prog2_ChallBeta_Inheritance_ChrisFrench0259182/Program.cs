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

            RandomizeCharacter();
            Console.ReadKey(true);

            RandomizeCharacter();
            Console.ReadKey(true);

            RandomizeCharacter();
            Console.ReadKey(true);

        }
        
        //m1
        static void RandomizeCharacter()
        {
            Character player1 = new Archer("PewPew Pointystick");
            Character player2 = new Orc("Smashie McStabface");
            Character player3 = new Wizard("Bearddress Zappyfingers");

            Random combatant1 = new Random();
            Random combatant2 = new Random();
            Character attacker = null; //declares attacker character so it can be referenced outside of  if statements
            Character defender = null; //declares defender character so it can be referenced outside of  if statements

            if (combatant1.Next(1, 4) == 1)
            {
                //Character attacker = player1;   // was the way i had this coded  prior to trying to access attacker for  check outside of  if statement
                attacker = player1;
            }

            if (combatant1.Next(1, 4) == 2)
            {
                attacker = player2;
            }

            if (combatant1.Next(1, 4) == 3)
            {
                attacker = player3;
            }

            if (combatant2.Next(1, 4) == 1)
            {
                //Character defender = player1;   // was the way i had this coded  prior totrying to access  defender for  check outside of  if statement
                defender = player1;
            }

            if (combatant2.Next(1, 4) == 2)
            {
                defender = player2;
            }

            if (combatant2.Next(1, 4) == 3)
            {
                defender = player3;
            }


            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"\n {attacker} is the attacker this  round");
            Console.WriteLine($"\n {defender} is the defender this  round");
            
        }
        
        //m2







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
