using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gade_1B_part_1
{
    abstract internal class Gold: Item
    {
        private int goldAmount;
        public int GoldAmount { get { return goldAmount; } set { goldAmount = value; } }

        public Gold(int X, int Y) : base(X, Y)
        {

        }
    }
}
