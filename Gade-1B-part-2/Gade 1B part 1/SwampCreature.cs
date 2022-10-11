using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gade_1B_part_1
{
    class SwampCreature : Enemy
    {
        public SwampCreature(int x, int y, int hp, int maxHp, int damage, char character): base(x, y, character)
        {
            hp = 10;
            damage = 1;
        }

        public override MovementEnum ReturnMove(MovementEnum move = MovementEnum.NoMovement)
        {
            int generateDirection;
            do
            {
                generateDirection = random.Next(0, 5);
            }
            while (vision[generateDirection] is not EmptyTile); //While chosen direction is not empty

            return (MovementEnum)generateDirection;
        }
        
    }
}
