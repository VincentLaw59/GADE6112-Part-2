using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_POE
{
    abstract class Enemy: Character
    {
        protected Random random = new Random();

        public Enemy(int x,int y, char character, int damage, int startHP) : base(x, y, character)
        {
            Damage = damage;
            HP = startHP;
            maxHp = startHP;
               
        }

        public override string ToString()
        {
            if (isDead() == true)
                return GetType().Name + " at " + "[" + X + "," + Y + "](" + Damage + ")" + " [Dead]";
            else return GetType().Name + " at " + "[" + X + "," + Y + "](" + Damage + ")";
        }
    }
}
