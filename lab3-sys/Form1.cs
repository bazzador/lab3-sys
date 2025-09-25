using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_sys
{
    public partial class Form1 : Form
    {
        private Bitmap buffer;
        private int sizeX = 50; 
        private int sizeY = 50;
        private int pixelSize = 5;
        private Random rand = new Random();

        private static Lake lake;

        private static int ageToBreed = 3;
        private static int breedInterval = 3;

        private static int predatorAgeToBreed = 4;
        private static int predatorBreedInterval = 4;
        private static int predatorStarvationInterval = 6;
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeBuffer()
        {
            pictureBox1.Width = sizeX * pixelSize;
            pictureBox1.Height = sizeY * pixelSize;
            buffer = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            ClearBuffer();
            pictureBox1.Image = buffer;
        }
        private void ClearBuffer()
        {
            using (Graphics g = Graphics.FromImage(buffer))
            {
                g.Clear(Color.LightBlue);
            }
        }


        private void InitializeLake(int fishCount, int predatorCount)
        {
            lake = new Lake(sizeX, sizeY);
                do // карасі
                {
                    int x = rand.Next(0, sizeX);
                    int y = rand.Next(0, sizeY);
                    if(!lake.FishGrid.IsOccupiedByFish(x,y))
                    {
                        Fish fish = new Fish(x, y, ageToBreed, rand.Next(0, ageToBreed), breedInterval, 0);
                        lake.AddFish(fish);
                    }
                } while (lake.Fishes.Count < fishCount);
                do // щуки
                {
                    int x = rand.Next(0, sizeX);
                    int y = rand.Next(0, sizeY);
                    if (!lake.FishGrid.IsOccupiedByFish(x, y))
                    {
                        PredatorFish predatorFish = new PredatorFish(x, y, predatorAgeToBreed, rand.Next(0, predatorAgeToBreed), predatorBreedInterval, 0, predatorStarvationInterval, 0);
                        lake.AddPredatorFish(predatorFish);
                    }

                } while (lake.PredatorFishes.Count < predatorCount);
            DrawLake();
        }

        private void DrawLake()
        {
            ClearBuffer();
            using (Graphics g = Graphics.FromImage(buffer))
            {
                lake.Fishes.ForEach(fish =>
                {
                    g.FillRectangle(Brushes.Orange, fish.X * pixelSize, fish.Y * pixelSize, pixelSize, pixelSize);
                });
                lake.PredatorFishes.ForEach(predatorFish =>
                {
                    g.FillRectangle(Brushes.Red, predatorFish.X * pixelSize, predatorFish.Y * pixelSize, pixelSize, pixelSize);
                });
            }
            pictureBox1.Invalidate();
        }


        private void Step1() // карасі рухаються
        {
            lake.Fishes.ForEach(fish =>
            {
                fish.Move(lake.FishGrid);
                fish.TickFish();
            });

            lake.ReloadFishPositions();
        }

        private void Step2() // карасі розмножуються
        {
            List<Fish> newFishes = new List<Fish>();
            lake.Fishes.ForEach(fish =>
            {
                Fish newFish = fish.Breed(lake.FishGrid);
                if (newFish != null)
                {
                    newFishes.Add(newFish);
                }
            });
            newFishes.ForEach(fish => lake.AddFish(fish));
        }

        private void Step3() // хижаки рухаються та їдять карасів
        {
            List<(int, int)> deadFishes = new List<(int, int)>();
            lake.PredatorFishes.ForEach(predatorFish =>
            {
                predatorFish.TickFish();
                (int, int) preyPosition = predatorFish.SearchAndEatPrey(lake.FishGrid);
                if (preyPosition != (-1, -1))
                {
                    deadFishes.Add(preyPosition);
                }
            });
            deadFishes.ForEach(position => lake.RemoveFishByPosition(position.Item1, position.Item2));
            lake.ReloadFishPositions();
        }

        private void Step4() // хижаки розмножуються 
        {
            List<PredatorFish> newPredatorFishes = new List<PredatorFish>();
            
            lake.PredatorFishes.ForEach(predatorFish =>
            {
                PredatorFish newPredatorFish = predatorFish.Breed(lake.FishGrid);
                if (newPredatorFish != null)
                {
                    newPredatorFishes.Add(newPredatorFish);
                }
            });
            newPredatorFishes.ForEach(predatorFish => lake.AddPredatorFish(predatorFish));
            lake.ReloadFishPositions();
        }

        private void Step5() // хижаки вмирають з голоду
        {
            var deadPredatorFishes = lake.PredatorFishes.Where(p => !p.IsAlive).ToList();
            deadPredatorFishes.ForEach(predatorFish => lake.RemovePredatorFish(predatorFish));
            lake.ReloadFishPositions();
        }


        private void Simulate()
        {
            Step1();
            Step2();
            Step3();
            Step4();
            Step5();
            DrawLake();
        }


        private void startBtn_Click(object sender, EventArgs e)
        {
            InitializeBuffer();
            InitializeLake(50, 10);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Simulate();
        }
    }
}
