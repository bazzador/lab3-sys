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
        private int sizeX = 80; 
        private int sizeY = 60;
        private int pixelSize = 5;
        private Random rand = new Random();

        private static Lake lake;


        private static int initialFishCount = 600;
        private static int initialPredatorCount = 80;

        private static int ageToBreed = 6;
        private static int breedInterval = 2;

        private static int predatorAgeToBreed = 5;
        private static int predatorBreedInterval = 4;
        private static int predatorStarvationInterval = 6;

        private int evolutionStage;

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
            lake.PredatorFishes.ForEach(predatorFish =>
            {
                predatorFish.TickFish();
                (int, int) preyPosition = predatorFish.SearchAndEatPrey(lake.FishGrid);
                if (preyPosition != (-1, -1))
                {
                    lake.RemoveFishByPosition(preyPosition.Item1, preyPosition.Item2);
                }
            });
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
        }

        private void Step5() // хижаки вмирають з голоду
        {
            var deadPredators = lake.PredatorFishes.Where(p => !p.IsAlive).ToList();

            foreach (var predator in deadPredators)
            {
                lake.RemovePredatorFish(predator);
            }
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
            if(lake == null)
            {
                InitializeBuffer();
                InitializeLake(initialFishCount, initialPredatorCount);
                evolutionStage = 0;
            }
            timer1.Start();
            
            startBtn.Enabled = false;
            stopBtn.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Simulate();
            evolutionStage++;
            evolutionStageLabel.Text = evolutionStage.ToString();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            stopBtn.Enabled = false;
            startBtn.Enabled = true;
            restartBtn.Enabled = true;
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            InitializeBuffer();
            evolutionStage = 0;
            evolutionStageLabel.Text = "0";
            lake = null;
            restartBtn.Enabled = false;
            startBtn.Enabled = true;
        }
    }
}
