using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing_Object
{
    public class Square : Shape
    {
        public float Height { get; set; }
        public float Width { get; set; }
        public Square(float x, float y, float width, float height, Color color) : base(x,y,color)
        {
            Width = width;
            Height = height;
        }
        public override void Drawing(Graphics g)
        {
            Brush b = new SolidBrush(Color);
            RectangleF recf = new RectangleF(X - Width / 2, Y - Height / 2, Width, Height);
            g.FillRectangle(b, recf);
            if(Selected)
            {
                Pen pen = new Pen(Color.Azure, 4);
                g.DrawRectangle(pen, X - Width / 2, Y - Height / 2, Width, Height);
                pen.Dispose();
            }
            b.Dispose();
        }
        public override bool IsHit(float x, float y)
        {
            return Math.Abs(X - x) <= Width / 2 && Math.Abs(Y - y) <= Height / 2;
        }
    }
}
