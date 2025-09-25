using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_sys
{
    public class Fish
    {
        protected int x;
        protected int y;
        protected static Random rand = new Random();
        public Fish(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int X => x;
        public int Y => y;

        public virtual void Move(bool[,] fishPos) // left right up down
        {
            int[,] availableDirections = new int[4, 2];

            if (x > 0) availableDirections[0, 0] = x - 1; // left
            else availableDirections[0, 0] = fishPos.GetLength(0) - 1;
            availableDirections[0, 1] = y;

            if (x < fishPos.GetLength(0) - 1) availableDirections[1, 0] = x + 1; // right
            else availableDirections[1, 0] = 0;
            availableDirections[1, 1] = y;

            if (y > 0) availableDirections[2, 1] = y - 1; // up
            else availableDirections[2, 1] = fishPos.GetLength(1) - 1;
            availableDirections[2, 0] = x;

            if (y < fishPos.GetLength(1) - 1) availableDirections[3, 1] = y + 1; // down
            else availableDirections[3, 1] = 0;
            availableDirections[3, 0] = x;

            List<(int, int)> freeDirections = new List<(int, int)>();

            for (int i = 0; i < 4; i++)
            {
                if (!fishPos[availableDirections[i, 0], availableDirections[i, 1]])
                {
                    freeDirections.Add((availableDirections[i, 0], availableDirections[i, 1]));
                }
            }

            if (freeDirections.Count > 0)
            {
                int direction = rand.Next(0, freeDirections.Count);
                x = freeDirections[direction].Item1;
                y = freeDirections[direction].Item2;
            }
            
        }

    }
}
