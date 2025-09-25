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


        private void InitializeLake(int fishCount)
        {
            lake = new Lake(sizeX, sizeY);
                do
                {
                    int x = rand.Next(0, sizeX);
                    int y = rand.Next(0, sizeY);
                    if(!lake.IsOccupied(x, y))
                    {
                        Fish fish = new Fish(x, y);
                        lake.AddFish(fish);
                        
                    }
                } while (lake.Fishes.Count < fishCount);
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
            }
            pictureBox1.Invalidate();
        }


        private void Step1() // карасі рухаються
        {
            lake.Fishes.ForEach(fish =>
            {
                fish.Move(lake.FishPos);
            });

            lake.ReloadFishPositions();

        }

        private void Simulate()
        {
            Step1();
            DrawLake();
        }


        private void startBtn_Click(object sender, EventArgs e)
        {
            InitializeBuffer();
            InitializeLake(40);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Simulate();
        }
    }
}
