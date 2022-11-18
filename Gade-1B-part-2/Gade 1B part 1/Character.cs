using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_POE
{
    abstract internal class Character: Tile
    {
        protected int hp;
        protected int maxHp;
        protected int damage;

        protected int goldPurse;
        
        public Tile[] vision = new Tile[5];
        
        protected int weaponReach;

        public int HP { get { return hp; } set { hp = value; } }
        public int MaxHp {get { return maxHp; } set { maxHp = value; } }
        public int Damage { get { return damage; } set { damage = value; } }
        public int GoldPurse { get { return goldPurse; } set { goldPurse = value; } }
        public int WeaponReach { get { return weaponReach; } set { weaponReach = value; } }
        public enum MovementEnum
        {
            NoMovement = 0,
            Up,
            Down,
            Left,
            Right
        }

        public enum VisionEnum
        {
            North = 1,
            South,
            West,
            East
        }

        public string[] characterVision = new string[]
        {
            "NoMovement", "Up", "Down", "Left", "Right"
        };

        public Character(int x, int y, char character): base(x, y)
        {
            hp = HP;
            maxHp = MaxHp;
            damage = Damage;
        }

        public virtual void Attack(Character target)
        {
            target.hp = target.hp - damage;
            //MessageBox.Show( GetType().Name + " at (" + x + "," + y + ") attacked target " + target.GetType().Name);
        }

        public bool isDead()
        {
            if (hp <= 0)
                return true;
            else return false;
        }

        public virtual bool CheckRange(Character target)
        {
            if (DistanceTo(target) <= weaponReach)
            {
                //within range of weapon
                return true;
            }
            //not within range
            return false;
        }

        private int DistanceTo(Character target)
        {
            return Math.Abs((target.x - x) + (target.y - y));
        }

        public void Move(MovementEnum move)
        {
            switch (move)
            {
                case MovementEnum.Up: x = x - 1;
                    break;
                case MovementEnum.Down: x = x + 1;
                    break;
                case MovementEnum.Left: y = y - 1;
                    break;
                case MovementEnum.Right: y = y + 1;
                    break;
                default: return;
            }
        }
        public void Pickup(Item i)
        {
            if (i is Gold)
            {
                Gold g = (Gold)i;
                goldPurse += g.GoldAmount; 
            }
        }

        public abstract MovementEnum ReturnMove(MovementEnum move);

        public abstract override string ToString();
    }
}
