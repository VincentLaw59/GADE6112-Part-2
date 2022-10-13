using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gade_1B_part_1
{
    public class Hero : Character
    {

        public Hero(int x, int y, int hp, int maxHp, int damage, char character): base(x, y, character) 
        {
            damage = 2;
        }

       

        public override MovementEnum ReturnMove(MovementEnum move = MovementEnum.NoMovement)
        {
            // If 
            
            if(move == MovementEnum.Up)
            {
                if ((vision[0] is EmptyTile) || (vision[0] is Gold)) //(vision[0] is Gold)) is a temporary fix
                {
                    //Move up
                    return move;
                }
                else
                {
                    move = MovementEnum.NoMovement;
                    return move;
                }

            }

            else if (move == MovementEnum.Down)
            {
                if ((vision[1] is EmptyTile) || (vision[1] is Gold)) //
                {
                    //Move down
                    return move;
                }
                else
                {
                    move = MovementEnum.NoMovement;
                    return move;
                }
            }

            else if (move == MovementEnum.Left) 
            {
                if ((vision[3] is EmptyTile) || (vision[3] is Gold)) //
                {
                    //Move down
                    return move;
                }
                else
                {
                    move = MovementEnum.NoMovement;
                    return move;
                }
            }

           else if (move == MovementEnum.Right)
            {
                if ((vision[2] is EmptyTile) || (vision[2] is Gold)) //
                {
                    //Move down
                    return move;
                }
                else
                {
                    move = MovementEnum.NoMovement;
                    return move;
                }
            }
            else
            {
                move = MovementEnum.NoMovement;
            }
            return move;
            
        }

        public override string ToString()
        {
            //string hp = "";
            //string maxHp = "";
            //string damage = "2";
            //string x = "";
            //string y = "";
                      

            //throw new NotImplementedException();

            return "Player Stats: \n" + "HP: " + hp + "/" + maxHp +
                "\nDamage: " + damage + "[" + x + "," + y + "]";
        }

       
        
    }
}
