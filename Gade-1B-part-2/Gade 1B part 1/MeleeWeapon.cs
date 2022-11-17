using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gade_1B_part_1
{
    public class MeleeWeapon: Weapon
    {
        
        public MeleeWeapon(string icon, int damage, int durability, int cost, int range, int X, int Y) : base(X, Y)
        {
           
        }

        MeleeWeapon Dagger = new MeleeWeapon("dag", 3, 10, 3, 1, 2, 1);
        MeleeWeapon LongSword = new MeleeWeapon("LS", 4, 6, 5, 2, 2, 2);

        public enum WeaponType
        {
            Dagger,
            LongSword
        }

        public override int Range(int dist)
        {
            dist = 1;
            return dist;
            //base.Range();
        }



        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
