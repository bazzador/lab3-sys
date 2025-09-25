using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab3_sys
{
    public class Lake
    {
        private int width;
        private int height;
        private List<Fish> fishes;
        private bool[,] fishPos;
        public Lake(int width, int height)
        {
            this.width = width;
            this.height = height;
            fishes = new List<Fish>();
            fishPos = new bool[width, height];
        }
        public int Width => width;
        public int Height => height;
        public List<Fish> Fishes => fishes;
        public bool[,] FishPos => fishPos;
        public void AddFish(Fish fish)
        {
            fishes.Add(fish);
            fishPos[fish.X, fish.Y] = true;
        }
        public void RemoveFish(Fish fish)
        {
            fishes.Remove(fish);
            fishPos[fish.X, fish.Y] = false;
        }
        public bool IsOccupied(int x, int y)
        {
            return fishPos[x, y];
        }

        public void ReloadFishPositions()
        {
            fishPos = new bool[width, height];
            foreach (var fish in fishes)
            {
                fishPos[fish.X, fish.Y] = true;
            }
        }
    }
}
