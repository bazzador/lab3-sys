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
        private List<PredatorFish> predatorFishes;
        private FishGrid fishGrid;
        public Lake(int width, int height)
        {
            this.width = width;
            this.height = height;
            fishes = new List<Fish>();
            predatorFishes = new List<PredatorFish>();
            fishGrid = new FishGrid(width, height);
        }
        public int Width => width;
        public int Height => height;
        public List<Fish> Fishes => fishes;
        public List<PredatorFish> PredatorFishes => predatorFishes;
        public FishGrid FishGrid => fishGrid;
        public void AddFish(Fish fish)
        {
            fishes.Add(fish);
            fishGrid.SetPosition(fish.X, fish.Y, 'f');
        }
        public void AddPredatorFish(PredatorFish predatorFish)
        {
            predatorFishes.Add(predatorFish);
            fishGrid.SetPosition(predatorFish.X, predatorFish.Y, 'p');
        }
        public void RemoveFish(Fish fish)
        {
            fishes.Remove(fish);
            fishGrid.SetPosition(fish.X, fish.Y, ' ');
        }
        public void RemoveFishByPosition(int x, int y)
        {
            Fish fishToRemove = fishes.FirstOrDefault(fish => fish.X == x && fish.Y == y);
            if (fishToRemove != null)
            {
                RemoveFish(fishToRemove);
            }
        }
        public void RemovePredatorFish(PredatorFish predatorFish)
        {
            predatorFishes.Remove(predatorFish);
            fishGrid.SetPosition(predatorFish.X, predatorFish.Y, ' ');
        }
        public void ReloadFishPositions()
        {
            fishGrid.ClearFishPositions();
            foreach (var fish in fishes)
            {
                fishGrid.SetPosition(fish.X, fish.Y, 'f');
            }
            foreach (var predatorFish in predatorFishes)
            {
                fishGrid.SetPosition(predatorFish.X, predatorFish.Y, 'p');
            }
        }
    }
}
