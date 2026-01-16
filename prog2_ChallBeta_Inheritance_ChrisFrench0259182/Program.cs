using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2_ChallBeta_Inheritance_ChrisFrench0259182
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

  

    public class Character
    {
        public string _name { get; set; }
        public int _health { get; set; }
        public int _speed { get; set; }
        public int _minAttack { get; set; }
        public int _maxAttack { get; set; }

        protected Random rando = new Random();
       
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
