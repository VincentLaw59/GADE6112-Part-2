using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_POE
{
    internal class GameEngine
    {
        private Map gameMap;


        public Map GameMap { get { return gameMap; } set { gameMap = value; } }


        public GameEngine()
        {
            gameMap = new Map(10, 15, 10, 15, 3, 5);
        }

        public bool MovePlayer(Character.MovementEnum direction)
        {
            int old_x = gameMap.Player.X;
            int old_y = gameMap.Player.Y;

            gameMap.UpdateVision();
            gameMap.player.Move(gameMap.Player.ReturnMove(direction));

            //Turn previous spot into empty space
            gameMap.gameMap[old_x, old_y] = new EmptyTile(old_x, old_y);
            gameMap.UpdateVision();

            Item? temp = gameMap.GetItemAtPosition(gameMap.Player.X, gameMap.Player.Y);
            if (temp != null)
            {
                gameMap.Player.Pickup(temp);
            }
            
            return true;
                
        }

        public void AttackEnemy(Enemy target)
        {
            if (target != null)
            {
                if (GameMap.Player.CheckRange(target))
                {
                    GameMap.Player.Attack(target);
                    MessageBox.Show("You attacked enemy: " + target.ToString());
                }
                else MessageBox.Show("Not in range to attack");

                if (target.isDead() == true)
                {
                    gameMap.gameMap[target.X, target.Y] = new EmptyTile(target.X, target.Y);
                    MessageBox.Show("You killed enemy: " + target.ToString());
                }
            }
        }

        public void EnemiesMove()
        {
            for (int k = 0; k < GameMap.Enemies.Length; k++)
            {
                int old_x = gameMap.Enemies[k].X;
                int old_y = gameMap.Enemies[k].Y;

                SwampCreature sc;
                Mage mage;

                if (GameMap.Enemies[k] is SwampCreature)
                {
                    sc = (SwampCreature)gameMap.Enemies[k];
                    gameMap.UpdateVision();
                    Character.MovementEnum enemyMoveDirection = sc.ReturnMove();
                    gameMap.Enemies[k].Move(enemyMoveDirection);
                    GameMap.gameMap[GameMap.Enemies[k].X, GameMap.Enemies[k].Y] = GameMap.Enemies[k];


                    if (enemyMoveDirection != Character.MovementEnum.NoMovement)
                    {
                        gameMap.gameMap[old_x, old_y] = new EmptyTile(old_x, old_y);
                    }
                }
                else if (GameMap.Enemies[k] is Mage)
                {
                    mage = (Mage)gameMap.Enemies[k];
                    gameMap.UpdateVision();
                    Character.MovementEnum enemyMoveDirection = mage.ReturnMove();
                    gameMap.Enemies[k].Move(enemyMoveDirection);
                    GameMap.gameMap[GameMap.Enemies[k].X, GameMap.Enemies[k].Y] = GameMap.Enemies[k];

                    if (enemyMoveDirection != Character.MovementEnum.NoMovement)
                    {
                        gameMap.gameMap[old_x, old_y] = new EmptyTile(old_x, old_y);
                    }
                }

                gameMap.UpdateVision();

            }
        }

        public void EnemyAttacks1()
        {
            for (int k = 0; k < GameMap.Enemies.Length; k++)    //Loop through all enemies
            {
                    for (int m = 0; m < gameMap.gameMap.GetLength(0); m++)  //Loop through maps x values
                    {
                        for (int n = 0; n < gameMap.gameMap.GetLength(1); n++) //Loops through map y values
                        {
                            if (gameMap.gameMap[m, n] is Character) //if position on map is Character
                            {
                                Character target = (Character)gameMap.gameMap[m, n];    
                                
                                if (gameMap.Enemies[k].CheckRange(target) == true) 
                                {
                                    gameMap.Enemies[k].Attack(target);
                                }
                            }   
                        }
                    }
            }
        }

        public void EnemyAttacks()
        {
            foreach (Character target in GameMap.Enemies)
            {
                if (target is Mage)
                {
                    Mage enemy = (Mage)target;

                    for (int k = 0; k < gameMap.Enemies.Length; k++)
                    {
                        if ((enemy.CheckRange(GameMap.Enemies[k]) == true) && (enemy != gameMap.Enemies[k]))
                        {
                            //MessageBox.Show("Mage attacked " + gameMap.Enemies[k].ToString());
                            enemy.Attack(gameMap.Enemies[k]);
                        }
                    }
                    if (enemy.CheckRange(gameMap.Player) == true)
                    {
                        MessageBox.Show("Mage attacked player");
                        enemy.Attack(gameMap.Player);
                    }
                }
                else if (target is SwampCreature)
                {
                    SwampCreature enemy = (SwampCreature)target;

                    for (int k = 0; k < gameMap.Enemies.Length; k++)
                    {
                        if ((enemy.CheckRange(GameMap.Enemies[k]) == true) && (enemy != gameMap.Enemies[k]))
                        {
                            MessageBox.Show("Swamp Creature attacked" + gameMap.Enemies[k].ToString());
                            enemy.Attack(gameMap.Enemies[k]);
                        }
                    }
                    if (enemy.CheckRange(gameMap.Player) == true)
                    {
                        MessageBox.Show("SwampCreature attacked player");
                        enemy.Attack(gameMap.Player);
                    }
                }
            }
        }

        public void JSONSave(string savePath)
        {
            var jsonSettings = new Newtonsoft.Json.JsonSerializerSettings();
            jsonSettings.TypeNameHandling = Newtonsoft.Json.TypeNameHandling.All;

            var serializedObject = Newtonsoft.Json.JsonConvert.SerializeObject(gameMap, Newtonsoft.Json.Formatting.Indented, jsonSettings);

            string path = savePath;

            using (StreamWriter sw = new StreamWriter(savePath))
            {
                sw.Write(serializedObject);
            }
        }
        public void JSONLoad(string savePath)
        {
            var jsonSettings = new Newtonsoft.Json.JsonSerializerSettings();
            jsonSettings.TypeNameHandling = Newtonsoft.Json.TypeNameHandling.All;

            string data;

            using (StreamReader sr = new StreamReader(savePath))
            {
                data = sr.ReadToEnd();
            }

            var mapReturned = Newtonsoft.Json.JsonConvert.DeserializeObject<Map>(data, jsonSettings);
            gameMap = mapReturned;
        }
    }
}
