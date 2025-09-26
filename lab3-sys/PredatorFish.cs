using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_sys
{
    public class PredatorFish : Fish
    {
        private int starvationInterval;
        private int lastTimeEating;
        private bool isAlive = true;

        public PredatorFish(int x, int y, int ageToBreed, int currentAge, int breedInterval, int lastTimeBreeding, int starvationInterval, int lastTimeEating)
            : base(x, y, ageToBreed, currentAge, breedInterval, lastTimeBreeding)
        {
            this.starvationInterval = starvationInterval;
            this.lastTimeEating = lastTimeEating;
        }

        public int StarvationInterval => starvationInterval;
        public int LastTimeEating => lastTimeEating;
        public bool IsAlive => isAlive;
        private List<(int, int)> SearchForPrey(FishGrid fishGrid) // private (int, int)
        {
            int[,] availableDirections = SearchAvailableSpaces(fishGrid.FishPositions.GetLength(0), fishGrid.FishPositions.GetLength(1));

            List<(int, int)> preyDirections = new List<(int, int)>();

            for (int i = 0; i < 4; i++)
            {
                if(fishGrid.IsOccupiedByFish(availableDirections[i, 0], availableDirections[i, 1]))
                {
                    preyDirections.Add((availableDirections[i, 0], availableDirections[i, 1]));
                }
            }
            return preyDirections; // return preyDirections.Count > 0 ? preyDirections[rand.Next(preyDirections.Count)] : null;
        }

        public (int, int) SearchAndEatPrey(FishGrid fishGrid)
        {
            List<(int, int)> preyDirections = SearchForPrey(fishGrid);

            if (preyDirections.Count > 0)
            {
                fishGrid.SetPosition(x, y, ' ');
                int direction = rand.Next(0, preyDirections.Count);
                x = preyDirections[direction].Item1;
                y = preyDirections[direction].Item2;
                fishGrid.SetPosition(x, y, 'p');
                lastTimeEating = 0;
                return (x, y);
            }
            else
            {
                List<(int, int)> freeDirections = SearchFreeSpaces(fishGrid);
                if (freeDirections.Count > 0)
                {
                    fishGrid.SetPosition(x, y, ' ');
                    int direction = rand.Next(0, freeDirections.Count);
                    x = freeDirections[direction].Item1;
                    y = freeDirections[direction].Item2;
                    fishGrid.SetPosition(x, y, 'p');
                }
            }
            return (-1, -1); // null
        }

        public override bool CanBreed()
        {
            return base.CanBreed() && isAlive;
        }
        public new PredatorFish Breed(FishGrid fishGrid)
        {
            List<(int, int)> freeDirections = SearchFreeSpaces(fishGrid);
            if(CanBreed())
            {
                if (freeDirections.Count > 0)
                {
                    int direction = rand.Next(0, freeDirections.Count);
                    lastTimeBreeding = 0;
                    return new PredatorFish(freeDirections[direction].Item1, freeDirections[direction].Item2, ageToBreed, 0, breedInterval, 0, starvationInterval, 0);
                }
                return null;
            }
            return null;
        }

        public override void TickFish()
        {
            base.TickFish();
            lastTimeEating++;
            if (IsStarving())
            {
                Die();
            }
        }
        private bool IsStarving()
        {
            return lastTimeEating >= starvationInterval;
        }
        private void Die()
        {
            isAlive = false;
        }
    }
}
