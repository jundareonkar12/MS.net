using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


     
        Color shapecolor;

        int shape = 0;
        Point start=new Point(100,100);
        Point end=new Point(300,300);
        int Eraser = 0;
        int Free = 0;
        private void onExit(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Are you sure?", "Paint", MessageBoxButtons.OKCancel);
            this.Close();
        }


        private void ColorPen_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                shapecolor = dlg.Color;
            }
           
        }
        private void OnLine(object sender, EventArgs e)
        {
            shape = 1;
        }

        private void OnFOrmMOuseDown(object sender, MouseEventArgs e)
        {
            this.start = new Point(e.X, e.Y);
        }

        private void OnFormMouseup(object sender, MouseEventArgs e)
        {
            this.end = new Point(e.X, e.Y);
            Graphics g = this.CreateGraphics();
            Pen p1 = new Pen(shapecolor, 2);
            
            if (shape == 1)
            {
                g.DrawLine(p1, start, end);
            }
            if(shape==2)
            {
                int width = end.X - start.X;
                int height = end.Y - start.Y;
                g.DrawRectangle(p1, start.X,start.Y, width, height);


            }
            if(shape==3)
            {
                int width = end.X - start.X;
                int height = end.Y - start.Y;
                g.DrawEllipse(p1, start.X, start.Y, width, height);
            }
            if(Eraser==1)
            {
                p1 = new Pen(Color.White, 0);
                SolidBrush sb = new SolidBrush(Color.White);
                g.FillRectangle(sb, start.X, start.Y, 20, 20);
                               
            }
            if (Eraser == 2)
            {
                
                int width = end.X - start.X;
                int height = end.Y - start.Y;
                SolidBrush sb = new SolidBrush(Color.White);             
                g.FillRectangle(sb, start.X, start.Y, width, height);

            }

        }

        private void OnShapeClick(object sender, EventArgs e)
        {
            shape = 2;
        }

        private void OnShapeEllipseClick(object sender, EventArgs e)
        {
            shape = 3;
        }

       
        private void OnEraserDown(object sender, MouseEventArgs e)
        {
            Eraser = 1;           
        }

        private void OnCleanWindow(object sender, EventArgs e)
        {
            Graphics g1 = this.CreateGraphics();
            g1.Clear(Color.White);
        }

        private void OnClickFreeHandEraser(object sender, EventArgs e)
        {
            Eraser = 2;
        }

       /* private void OnHandFreeMouseDown(object sender, MouseEventArgs e)
        {
            while(Free!=1)
            { 
            Point p1 = new Point(e.X,e.Y);
                
            }
        }

        private void OnHandFreeMouseUp(object sender, MouseEventArgs e)
        {
            Free= 1;
        }*/
    }
}
