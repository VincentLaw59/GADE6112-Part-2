using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gade_1B_part_1
{
    public class GameEngine
    {

        private Map map;


        //private static Hero hero = new Hero(5, 5, 20, 20, 2, HeroChar); //fix char
        private static char heroChar = (char)208;
        private static char empty = (char)44;
        private static char swampCreature = (char)199;
        private static char obstacle = (char)42;
        

        public Map Map { get { return map; } set { map = value; } }
        public static char HeroChar { get { return heroChar; } }
        public char Empty { get { return empty; } }
        public char SwampCreature { get { return swampCreature; } }
        public char Obstacle { get { return obstacle; } }
        //public static Hero Hero { get { return hero; } set { hero = value; } }

        public GameEngine()
        {
            map = new Map(10, 10, 10, 10, 2); 
        }
        public bool MovePlayer(Character.MovementEnum direction)
        {
            if (Map.Player.ReturnMove(direction) == direction)
            {
                Map.player.Move(direction);

                switch (direction)
                {
                    case Character.MovementEnum.NoMovement:
                        Map.gameMap[Map.Player.Y, Map.Player.X] = new EmptyTile(Map.Player.X, Map.Player.Y);
                        // map.UpdateVision();
                        break;

                    case Character.MovementEnum.Up:
                        Map.gameMap[Map.Player.Y + 1, Map.Player.X] = new EmptyTile(Map.Player.X, Map.Player.Y);
                        map.UpdateVision();
                        break;

                    case Character.MovementEnum.Down:
                        Map.gameMap[Map.Player.Y - 1, Map.Player.X] = new EmptyTile(Map.Player.X, Map.Player.Y);
                        map.UpdateVision();
                        break;

                    case Character.MovementEnum.Left:
                        Map.gameMap[Map.Player.Y, Map.Player.X + 1] = new EmptyTile(Map.Player.X, Map.Player.Y);
                        map.UpdateVision();
                        break;

                    case Character.MovementEnum.Right:
                        Map.gameMap[Map.Player.Y, Map.Player.X - 1] = new EmptyTile(Map.Player.X, Map.Player.Y);
                        map.UpdateVision();
                        break;
                }
                                   
            }

            return true;
        }
              
    }
}



    

