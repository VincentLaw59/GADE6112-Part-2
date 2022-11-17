using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gade_1B_part_1
{
    public class Shop
    {
        private Character buyer;
        private Weapon randWeapons;
        private string[] weaponArray = new string[3];
        public Random random1 = new Random();
        Random random2 = new Random();  
        Random random3 = new Random();
      public Shop(Character character)
      {
        this.buyer = character;
       
        for(int i = 0; i < weaponArray.Length; i++)
            {
                weaponArray[i] = weaponArray[i].ToString();
            }

      }

        private void RandomWeapon()
        {   
            weaponArray[0] = Convert.ToString(random1.Next(0, 3));
            weaponArray[1] = Convert.ToString(random2.Next(0, 3));
            weaponArray[2] = Convert.ToString(random3.Next(0, 3));

            

        }

        
    }
}
