using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gade_1B_part_1
{
    public class RangedWeapon : Weapon
    {
        public RangedWeapon(string icon, int damage,int durability, int cost, int range,int X, int Y) : base(X, Y)
        {

        }


        RangedWeapon rifle = new RangedWeapon("rfl", 5, 3, 3, 7 , 1,1);
        RangedWeapon longBow = new RangedWeapon("lb", 4, 4, 6, 2, 1, 2);
        public enum Ranged
        {
            Rifle,
            Longbow
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
