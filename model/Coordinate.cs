using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Coordinate
    {
        private int y;
        private int x;

        public Coordinate(int y, int x)
        {
            this.Y = y;
            this.X = x;
        }

        /// <summary>
        /// Position Y
        /// </summary>
        public int Y { get => y; set => y = value; }

        /// <summary>
        /// Position X
        /// </summary>
        public int X { get => x; set => x = value; }
    }
}
