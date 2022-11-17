using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gade_1B_part_1
{
    public class Leader : Enemy
    {   
        public bool playerInRange = false;
        public bool enemyInRamge = false;
        public Random random = new Random();
        private static GameEngine gameEngine = new GameEngine();
        private static Hero ?player;
        private static Enemy ?enemy;
        public static GameEngine GameEngine { get { return gameEngine; } set { gameEngine = value; } }
        public static Hero Player { get { return player!; } set { player = value; } }
        private static Enemy Enemy { get { return enemy!; } set { enemy = value; } }
        private Tile[] ?leadertarget;
        Character ?target;

        public Tile[] Leaderertarget { get { return leadertarget!;} set { leadertarget = value;} }
        public Leader(int x, int y, int damage, int hp, char character) : base(x, y, damage, character)
        {
            hp = 20;
            damage = 2;

        }
                
        public override MovementEnum ReturnMove(MovementEnum move = MovementEnum.NoMovement)
        {   //not sure why this does not return an error.
            for(int i = 0; i < gameEngine.Map.Enemies.Length; i++)
            {
                playerInRange = GameEngine.Map.Enemies[i].CheckRange(gameEngine.Map.Player);
                enemyInRamge = GameEngine.Map.Enemies[i].CheckRange(gameEngine.Map.Enemies[i]);

                if(playerInRange == false)
                {
                   Math.Abs(this.X =- Player.X);
                   Math.Abs(this.Y = - Player.Y);
                }
                //come back todouble check logic
                if(enemyInRamge == true)
                {
                    int generateDirection;
                    do
                    {
                        generateDirection = random.Next(0, 5);
                    }
                    while (vision[generateDirection] is not EmptyTile);

                    do
                    {
                        generateDirection = random.Next(0, 5);
                    }
                    while(vision[generateDirection] is SwampCreature);


                    return (MovementEnum)generateDirection;

                    //switch (random)
                    //{
                    //    case 1:

                    //        break;
                    //}


                }

            }

           



            throw new NotImplementedException();
        }

       
    }
}
