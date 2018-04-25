using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using Pacman1.Properties;

namespace Pacman1
{
    public partial class Form1 : Form
    {
        Timer timer;
        Pacman pacman;
        static readonly int TIMER_INTERVAL = 250;
        static readonly int WORLD_WIDTH = 15;
        static readonly int WORLD_HEIGHT = 10;
        Image foodImage;
        bool[][] foodWorld;
        public Form1()
        {
            InitializeComponent();
            foodImage = Resources.peach;
            DoubleBuffered = true;
            newGame();
        }
        public void newGame()
        {
            pacman = new Pacman();
            this.Width = Pacman.Radius * 2 * (WORLD_WIDTH + 1);
            this.Height = Pacman.Radius * 2 * (WORLD_HEIGHT + 1);
            ////////////////////////////
            foodWorld = new bool[WORLD_HEIGHT][];
            for (int i = 0; i < WORLD_HEIGHT; i++)
                foodWorld[i] = new bool[WORLD_WIDTH];
            for (int i = 0; i < WORLD_HEIGHT; i++)
                for (int j = 0; j < WORLD_WIDTH; j++)
                    foodWorld[i][j] = true;
            ////////////////////////////
            timer = new Timer();
            timer.Interval = TIMER_INTERVAL;
            timer.Tick += new EventHandler(timer_tick);
            timer.Start();
        }

        private void timer_tick(object sender, EventArgs e)
        {
            foodWorld[pacman.y-1][pacman.x-1] = false;
            pacman.Move(WORLD_WIDTH, WORLD_HEIGHT);
            Invalidate();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Right:
                    pacman.ChangeDirection(1);
                    break;
                case Keys.Left:
                    pacman.ChangeDirection(2);
                    break;
                case Keys.Up:
                    pacman.ChangeDirection(3);
                    break;
                case Keys.Down:
                    pacman.ChangeDirection(4);
                    break;
                default:
                    break;
                
            }

            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            for (int i = 0; i < foodWorld.Length; i++)
            {
                for (int j = 0; j < foodWorld[i].Length; j++)
                {
                    if (foodWorld[i][j])
                    {
                        g.DrawImageUnscaled(foodImage, j * Pacman.Radius * 2 + (Pacman.Radius * 2 - foodImage.Height) / 2, i * Pacman.Radius * 2 + (Pacman.Radius * 2 - foodImage.Width) / 2);
                    }
                }
            }
            pacman.Draw(g);
        }
    }
}
