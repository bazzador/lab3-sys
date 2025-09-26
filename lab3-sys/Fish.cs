using System;
using System.Collections.Generic;

namespace lab3_sys
{
    public class Fish
    {
        protected int x;
        protected int y;

        protected int ageToBreed;
        protected int currentAge;

        protected int breedInterval;
        protected int lastTimeBreeding;

        protected static Random rand = new Random();
        public Fish(int x, int y, int ageToBreed, int currentAge, int breedInterval, int lastTimeBreeding)
        {
            this.x = x;
            this.y = y;
            this.ageToBreed = ageToBreed;
            this.currentAge = currentAge;
            this.breedInterval = breedInterval;
            this.lastTimeBreeding = lastTimeBreeding;
        }
        public int X => x;
        public int Y => y;
        public int CurrentAge => currentAge;
        public int AgeToBreed => ageToBreed;
        public int BreedInterval => breedInterval;
        public int LastTimeBreeding => lastTimeBreeding;
        protected int[,] SearchAvailableSpaces(int width, int height)
        {
            int[,] availableDirections = new int[4, 2];

            if (x > 0) availableDirections[0, 0] = x - 1; // left
            else availableDirections[0, 0] = width - 1;
            availableDirections[0, 1] = y;

            if (x < width - 1) availableDirections[1, 0] = x + 1; // right
            else availableDirections[1, 0] = 0;
            availableDirections[1, 1] = y;

            if (y > 0) availableDirections[2, 1] = y - 1; // up
            else availableDirections[2, 1] = height - 1;
            availableDirections[2, 0] = x;

            if (y < height - 1) availableDirections[3, 1] = y + 1; // down
            else availableDirections[3, 1] = 0;
            availableDirections[3, 0] = x;

            return availableDirections;
        }
        protected List<(int, int)> SearchFreeSpaces(FishGrid fishGrid) // left right up down
        {
            int[,] availableDirections = SearchAvailableSpaces(fishGrid.FishPositions.GetLength(0), fishGrid.FishPositions.GetLength(1));

            List<(int, int)> freeDirections = new List<(int, int)>();

            for (int i = 0; i < 4; i++)
            {
                if (!fishGrid.isOccupied(availableDirections[i, 0], availableDirections[i, 1]))
                {
                    freeDirections.Add((availableDirections[i, 0], availableDirections[i, 1]));
                }
            }
            return freeDirections;
        }
        public void Move(FishGrid fishGrid)
        {
            List<(int, int)> freeDirections = SearchFreeSpaces(fishGrid);

            if (freeDirections.Count > 0)
            {
                fishGrid.SetPosition(x, y, ' ');
                int direction = rand.Next(0, freeDirections.Count);
                x = freeDirections[direction].Item1;
                y = freeDirections[direction].Item2;
                fishGrid.SetPosition(x, y, 'f');
            }
        }
        public virtual void TickFish() // риба кожен тік росте або рахує час з останнього розмноження
        {
            if(currentAge < ageToBreed)
                currentAge++;
            else lastTimeBreeding++;
        }
        public virtual bool CanBreed()
        {
            return currentAge >= ageToBreed && lastTimeBreeding >= breedInterval;
        }

        public virtual Fish Breed(FishGrid fishGrid)
        {
            List<(int, int)> freeDirections = SearchFreeSpaces(fishGrid);
            if (CanBreed())
            {
                if (freeDirections.Count > 0)
                {
                    int direction = rand.Next(0, freeDirections.Count);
                    lastTimeBreeding = 0;
                    return new Fish(freeDirections[direction].Item1, freeDirections[direction].Item2, ageToBreed, 0, breedInterval, 0);
                }
                return null;
            }
            return null;
        }
    }
}
