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

            RandomWeapon();

      }

        private void RandomWeapon()
        {
            //weaponArray[0] = Convert.ToString(random1.Next(0, 3));
            //weaponArray[1] = Convert.ToString(random2.Next(0, 3));
            //weaponArray[2] = Convert.ToString(random3.Next(0, 3));
           

            for (int i = 0; i < weaponArray.Length; i++)
            {
                weaponArray[i] = weaponArray[Convert.ToInt32(random1.Next(0,4))];
               
                 bool CanBuy(int amount)
                 {  
                    if(amount == randWeapons.Cost)
                    {
                        switch (Convert.ToInt32(random1))
                        {
                            case 1:


                                MeleeWeapon Dagger = new MeleeWeapon("Dag", 3, 10, 3, 1, 2, 1);
                                break;

                            case 2:
                                MeleeWeapon LongSword = new MeleeWeapon("LS", 4, 6, 5, 2, 2, 2);
                                break;

                            case 3:
                                RangedWeapon Rifle = new RangedWeapon("Rfl", 5, 3, 3, 7, 1, 1);
                                break;

                            case 4:
                                RangedWeapon LongBow = new RangedWeapon("LB", 4, 4, 6, 2, 1, 2);
                                break;
                        }
                    }

                    

                    return true;
                 }

               

            }



        }

        
    }
}
