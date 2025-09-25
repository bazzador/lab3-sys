using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_sys
{
    public class FishGrid
    {
        private char[,] fishPositions;

        public FishGrid(int width, int height)
        {
            fishPositions = new char[width, height];
        }

        public char[,] FishPositions => fishPositions;

        public bool IsOccupiedByFish(int x, int y)
        {
            return fishPositions[x, y] == 'f';
        }
        public bool isOccupiedByPredatorFish(int x, int y)
        {
            return fishPositions[x, y] == 'p';
        }
        public bool isOccupied(int x, int y)
        {
            return fishPositions[x, y] == 'f' || fishPositions[x, y] == 'p';
        }

        public void SetPosition(int x, int y, char symbol)
        {
            fishPositions[x, y] = symbol;
        }
        public void ClearFishPositions()
        {
            Array.Clear(fishPositions, 0, fishPositions.Length);
        }
    }
}
