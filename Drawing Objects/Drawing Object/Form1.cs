using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing_Object
{
    public partial class Form1 : Form
    {
        private ShapesList shapeList;
        private bool mousedown;
        private Shape CurrentShape;
        private Color CurrentColor;
        private SHAPE_TYPE CurrentType;
        private float prevX;
        private float prevY;

        private enum SHAPE_TYPE
        {
            CIRCLE,
            SQUARE
        }
        public Form1()
        {
            InitializeComponent();
            shapeList = new ShapesList();
            CurrentType = SHAPE_TYPE.CIRCLE;
            CurrentColor = Color.Aqua;
            this.DoubleBuffered = true;
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void SHAPE_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (sender == circle)
            {
                circle.Checked = true;
                square.Checked = false;
                CurrentType = SHAPE_TYPE.CIRCLE;
            }
            else if (sender == square)
            {
                circle.Checked = false;
                square.Checked = true;
                CurrentType = SHAPE_TYPE.SQUARE;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (CurrentType == SHAPE_TYPE.CIRCLE)
                shapeList.AddShape(e.X, e.Y, CurrentColor, ShapesList.SHAPE_TYPE.CIRCLE);
            else if (CurrentType == SHAPE_TYPE.SQUARE)
                shapeList.AddShape(e.X, e.Y, CurrentColor, ShapesList.SHAPE_TYPE.SQUARE);
            Invalidate();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            shapeList.Select(e.X, e.Y);
            Invalidate();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
            CurrentShape = shapeList.Select(e.X, e.Y);
            prevX = e.X;
            prevY = e.Y;

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(mousedown)
            {
                float dx = e.X - prevX;
                float dy = e.Y - prevY;
                CurrentShape.Move(dx, dy);
                Invalidate();
            }
            prevX = e.X;
            prevY = e.Y;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            shapeList.Draw(e.Graphics);
        }

        private void color_Click(object sender, EventArgs e)
        {
            if (sender == color)
            {
                ColorDialog colordialog = new ColorDialog();
                DialogResult result = colordialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    CurrentColor = colordialog.Color;
                }
            }
        }

        private void circle_Click(object sender, EventArgs e)
        {
            circle.Checked = true;
            square.Checked = false;
            CurrentType = SHAPE_TYPE.CIRCLE;
        }

        private void square_Click(object sender, EventArgs e)
        {
            circle.Checked = false;
            square.Checked = true;
            CurrentType = SHAPE_TYPE.SQUARE;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                Application.Exit();
        }
    }
}
