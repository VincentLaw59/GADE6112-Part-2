﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_POE
{
    internal class Map
    {
        private Tile[,] map;
        public Hero player;

        private Item[] items;

        private Enemy[] enemies;
        private const int TYPES_OF_ENEMIES = 2;
        private int chosenEnemy = 0;

        private int mapWidth;
        private int mapHeight;
        private Random rand = new Random();

        public Hero Player { get { return player; } set { player = value; } }
        public int MapWidth { get { return mapWidth; } set { mapWidth = value; } }
        public int MapHeight { get { return mapHeight; } set { mapHeight = value; } }
        public Tile[,] gameMap { get { return map; } set { map = value; } }
        public Enemy[] Enemies { get { return enemies; } set { enemies = value; } }

        public Map(int minWidth, int maxWidth, int minHeight, int maxHeight, int amtOfEnemies, int amtOfGold)
        {
            mapWidth = rand.Next(minWidth, maxWidth + 1);
            mapHeight = rand.Next(minHeight, maxHeight + 1);

            map = new Tile[mapHeight, mapWidth];
            enemies = new Enemy[amtOfEnemies];
            items = new Item[amtOfGold];

            //Spawn Border and fill Empty Tiles
            for (int k = 0; k < mapHeight; k++)
            {
                for (int j = 0; j < mapWidth; j++)
                {
                    if ((k == 0) || (j == 0) || (k == mapHeight - 1) || (j == mapWidth - 1))
                    {
                        map[k, j] = new Obstacle(k, j);
                    }
                    else map[k, j] = new EmptyTile(k, j);
                }
            }

            //Creating Hero
            player = (Hero)Create(Tile.TileType.Hero);
            //Spawn Hero
            map[player.X, player.Y] = player;


            //Spawn enemies  
            for (int p = 0; p < enemies.Length; p++)
            {
                chosenEnemy = rand.Next(1, TYPES_OF_ENEMIES + 1);

                if (chosenEnemy == 1)
                {
                    enemies[p] = (SwampCreature)Create(Tile.TileType.Enemy);
                }
                else if (chosenEnemy == 2)
                {
                    enemies[p] = (Mage)Create(Tile.TileType.Enemy);
                }
                map[enemies[p].X, enemies[p].Y] = enemies[p];
            }

            //Spawn Gold
            for (int p = 0; p < items.Length; p++)
            {
                items[p] = (Item)Create(Tile.TileType.Gold);
                map[items[p].X, items[p].Y] = items[p];
            }

            UpdateVision();
        }
        
        public void UpdateVision()
        {
            player.vision[1] = map[player.X - 1, player.Y];
            player.vision[2] = map[player.X + 1, player.Y];
            player.vision[3] = map[player.X, player.Y - 1];
            player.vision[4] = map[player.X, player.Y + 1];

            for (int m = 0; m < enemies.Length; m++)
            {
                enemies[m].vision[1] = map[enemies[m].X - 1, enemies[m].Y];
                enemies[m].vision[2] = map[enemies[m].X + 1, enemies[m].Y];
                enemies[m].vision[3] = map[enemies[m].X, enemies[m].Y - 1];
                enemies[m].vision[4] = map[enemies[m].X, enemies[m].Y + 1];

            }
        }

        private Tile Create(Tile.TileType type)
        {
            //Generate position for object
            int xCoord, yCoord;
            do
            {
                xCoord = rand.Next(1, mapHeight - 1);
                yCoord = rand.Next(1, mapWidth - 1);
            }
            while (map[xCoord, yCoord] is not EmptyTile);

            //Create Entity
            if (type == Tile.TileType.Hero)
                return new Hero(xCoord, yCoord);
            else if (type == Tile.TileType.Enemy)
            {
                //Spawn Specific Enemy
                if (chosenEnemy == 1)
                {
                    SwampCreature sc = new SwampCreature(xCoord, yCoord);
                    AddEnemyToArray(sc);
                    return sc;
                }
                else if (chosenEnemy == 2)
                {
                    Mage mage = new Mage(xCoord, yCoord);
                    AddEnemyToArray(mage);
                    return mage;
                }
                else return new EmptyTile(xCoord, yCoord);
            }
            //Spawn Gold
            else if (type == Tile.TileType.Gold)
                return new Gold(xCoord, yCoord);
            else return new EmptyTile(xCoord, yCoord);
        }

        private void AddEnemyToArray(Enemy e)
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                if (enemies[i] is null)
                {
                    enemies[i] = e;
                    return;
                }
            }
        }

        public Item? GetItemAtPosition(int x, int y)
        {
            for (int k = 0; k < items.Length; k++)
            {
                if (items[k] != null)
                {
                    if ((items[k].X == x) && (items[k].Y == y))
                    {
                        Item item = items[k];
                        items[k] = null;
                        return item;
                    }
                }
            }
            return null;
        }

        public override string ToString()
        {
            string stringOutput = "";

            for (int k = 0; k < map.GetLength(0); k++)
            {
                for (int i = 0; i < map.GetLength(1); i++)
                {
                    switch (map[k, i])
                    {
                        case Obstacle:
                            stringOutput += " X " + "\t";
                            break;

                        case Hero:
                            stringOutput += " H " + "\t";
                            break;

                        case SwampCreature:
                            stringOutput += " S " + "\t";
                            break;

                        case Mage:
                            stringOutput += "M" + "\t";
                            break;

                        case Gold:
                            stringOutput += "G" + "\t";
                            break;

                        case EmptyTile:
                            stringOutput += " . " + "\t";
                            break;
                    }
                }
                stringOutput += "\n";
            }
            return stringOutput;

        }
    }
}
