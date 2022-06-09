using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryGame
{
    public class Enemy : ILifeBeing
    {
        public int health { get; set; }
        public int attack { get; set; }
        public string photoPath { get; set; }
        public int heal { get; set; }
        public string name { get; set; }

        public Enemy(string photoPath, string name = "Monster", int health = 60, int attack = 5, int heal = 0)
        {
            this.photoPath = photoPath;
            this.name = name;
            this.health = health;
            this.attack = attack;
            this.heal = heal;
        }
    }
}
