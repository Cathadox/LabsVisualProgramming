using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Pacman1
{
    public class Pacman
    {
        public enum Direction
        {
            LEFT,
            UP,
            RIGHT,
            DOWN
        }
        public Direction direction;
        private int X { get; set; }
        private int Y { get; set; }
        public static readonly int Radius = 20;
        private static int Velocity;
        private bool mouth { get; set; }
        public int x = 5;
        public int y = 7;
        Brush brush = new SolidBrush(Color.Yellow);
        public Pacman()
        {
            Velocity = Radius;
            X = 7;
            Y = 5;
            direction = Direction.RIGHT;
        }
        public void Draw(Graphics g)
        {
            Rectangle rec = new Rectangle(X - Radius, Y - Radius, 2 * Radius, 2 * Radius);
            if(mouth && direction == Direction.RIGHT)
            {
                g.FillPie(brush, rec, 135, 225);
            }
            if(mouth && direction == Direction.LEFT)
            {
                g.FillPie(brush, rec, 45, 315);
            }
            if(mouth && direction == Direction.UP)
            {
                g.FillPie(brush, rec, 225, 315);
            }
            if(mouth && direction == Direction.DOWN)
            {
                g.FillPie(brush, rec, 45, 135);
            }
            if(!mouth)
            {
                g.FillEllipse(brush, rec);
            }
        }
        public void Move(int i, int j)
        {
            if(direction == Direction.RIGHT)
            {
                if (X == i)
                {
                    X = 1;
                    
                }
                else
                { X += Velocity; }
                
            }
            if (direction == Direction.LEFT)
            {
                if (X == 1)
                { X = i; }
                else
                    X -= Velocity;
            }
            if (direction == Direction.DOWN)
            {
                if (Y == j)
                    Y = 1;
                else
                    Y++;
            }
            if (direction == Direction.UP)
            {
                if (Y == 1)
                    Y = j;
                else
                    Y--;
            }
            if(mouth)
            {
                mouth = false;
            }
            else
            {
                mouth = true;
            }

        }
        public void ChangeDirection(int i)
        {
            if (i == 1)
                direction = Direction.RIGHT;
            if (i == 2)
                direction = Direction.LEFT;
            if (i == 3)
                direction = Direction.UP;
            if (i == 4)
                direction = Direction.DOWN;
        }
    }
}
