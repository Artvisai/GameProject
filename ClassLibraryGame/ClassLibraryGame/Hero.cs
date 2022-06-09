using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryGame
{
    public class Hero : ILifeBeing
    {
        public int health { get; set; }
        public int attack { get; set; }
        public string photoPath { get; set; }
        public int heal { get; set; }
        public int healTimes { get; set; }
        public int hitRange { get; set; }


        public Hero(string photoPath, int health = 40, int attack = 8, int heal = 15, int healTimes = 5, int hitRange = 2)
        {
            this.photoPath = photoPath;
            this.health = health;
            this.attack = attack;
            this.heal = heal;
            this.healTimes = healTimes;
            this.hitRange = hitRange;
        }
    }
}
