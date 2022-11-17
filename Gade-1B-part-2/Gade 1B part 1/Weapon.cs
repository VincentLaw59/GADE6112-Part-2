using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gade_1B_part_1
{
    public abstract class Weapon : Item
    {
        protected int damage;
       
        protected int durability;
        protected int cost;
        protected string weaponType = "";

        public int Damage { get { return damage; } set { damage = value; } }
        //public virtual int Range { get { return range(); } set { range = value; } }
        public int Durability { get { return durability; } set { durability = value; } }
        public int Cost { get { return cost; } set { cost = value; } }
        public string WeaponType { get { return weaponType; } set { weaponType = value; } }

        public Weapon(int X, int Y) : base(X, Y)
        {
        }

        public virtual int Range(int weaponDist) { return weaponDist;  }

        
    }
}
