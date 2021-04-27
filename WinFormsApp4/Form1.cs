using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        Pen p;
        public int x1 = 0, x2 = 0, y1 = 0, y2 = 0;
        public int shapeID;
        Graphics mg;
        public bool drag;
        public Form1()
        {
            InitializeComponent();
            shapeID = 0;
            mg = this.CreateGraphics();
            p = new Pen(Color.Black);
            drag = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonl2_Click(object sender, EventArgs e)
        {
            shapeID = 4;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = colorDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                p.Color = colorDialog1.Color;

            }
        }
        private void Line_Click(object sender, EventArgs e)
        {
            shapeID = 3;
        }

        private void Circle_Click(object sender, EventArgs e)
        {
            shapeID = 2;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            switch (shapeID)
            {
                case 2: mg.DrawEllipse(p, x1, y1, x2 - x1, y2 - y1);
                        break;
                case 3: mg.DrawLine(p, x1, y1, x2, y2);
                        break;
                case 4: mg.DrawRectangle(p, x1, y1, x2 - x1, y2 - y1);
                        break;
            }
    
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            x2 = e.X;
            y2 = e.Y;

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (radioButton1.Checked) p.Width = 5;
            else if (radioButton2.Checked) p.Width = 10;
            else if (radioButton3.Checked) p.Width = 15;
            if(radioButton5.Checked) p.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            

        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x1 = e.X;
            y1 = e.Y;
        }
    }
}
