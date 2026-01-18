using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace prog2_ChallBeta_Inheritance_ChrisFrench0259182
{
    internal class Program
    {

        //static Random combatant1 = new Random(1, 4);
        //static Random combatant2 = new Random(1, 4);
        static Character attacker = null; //declares attacker character so it can be referenced outside of  if statements
        static Character defender = null; //declares defender character so it can be referenced outside of  if statements

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
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"\n {attacker._name} is the attacker this  round");
            Console.ReadKey(true);

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
            //Console.WriteLine($"\n {attacker._name} is the attacker this  round");
            //Console.ReadKey(true);
            Console.WriteLine($"\n {defender._name} is the defender this  round");
            Console.ReadKey(true);

        }

        //m2
        static void ThunderDome()
        {
            Console.WriteLine($" {attacker._name} vs {defender._name}");
            Console.WriteLine("FIGHT\n\n");
            while (attacker._health > 0 && defender._health > 0)
            {

                if (attacker._speed >= defender._speed)
                {

                    Console.WriteLine($"\n Attacker first");
                    if (defender._health > 0)
                    {
                        Console.WriteLine($"\n defender second");

                    }
                }
                else
                {
                    Console.WriteLine($"\n defender first");

                    if (attacker._health > 0)
                    {
                        Console.WriteLine($"\n Attacker second");

                    }
                }
                Console.ReadKey(true);
            }

            string winner = attacker._health > 0 ? attacker._name : defender._name;
            Console.WriteLine($"{winner} is the  last one  standing...  winner, winner, chicken  dinner.");
            Console.ReadKey(true);
        }

        //m3 
        static void TurnOrder(Character attacker, Character defender)
        {
            Console.WriteLine($"\n turn order call  test attacker to strike defender");
            Console.ReadKey(true);
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

        public int _attackPower;




        public Character(string name, int health, int speed, int minAtk, int maxAtk)
        {
            _name = name;
            _health = health;
            _speed = speed;
            _minAttack = minAtk;
            _maxAttack = maxAtk;
            _attackPower = rando.Next(_minAttack, _maxAttack + 1);

        }

        public virtual void Attack(Character target)
        {
            int damage = _attackPower;
            Console.WriteLine($"{_name} attacks {target._name} for {damage} damage!");
            target.TakeDamage(damage);

            Console.ReadKey(true);
        }

        public virtual void TakeDamage(int damage)
        {
            _health -= damage;
            if (_health < 0)
            {
                _health = 0;
            }
            Console.WriteLine($"{_name} has {_health} hp left.");
            Console.ReadKey(true);
        }
    }
    class Orc : Character
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

    class Archer : Character

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


    class Wizard : Character

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
                Console.WriteLine($"{_name} casts a spell to asorbe, empower and reflect Damage  back to attacker");
                int reducedDamage = 0;
                //base.TakeDamage(reducedDamage);
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
