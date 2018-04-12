using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;



namespace Drawing_Object
{
    public class Circle : Shape
    {
        public float Radius { get; set; }
        public Circle(float x, float y, float radius, Color color) : base(x,y,color)
        {
            Radius = radius;
        }
        public override void Drawing(Graphics g)
        {
            Brush b = new SolidBrush(Color);
            RectangleF rec = new RectangleF(X - Radius, Y - Radius, 2 * Radius, 2 * Radius);
            g.FillEllipse(b, rec);
            if (Selected)
            {
                Pen pen = new Pen(Color.Aqua, 3);
                g.DrawEllipse(pen, rec);
                pen.Dispose();
            }
            b.Dispose();
        }
        public override bool IsHit(float x, float y)
        {

            double d = Math.Sqrt(Math.Pow((X - x), 2) - Math.Pow((Y - y), 2));
            return d <= Radius;
        }

    }
}
