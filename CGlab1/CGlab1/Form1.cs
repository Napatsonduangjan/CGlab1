﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGlab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nd_Click(object sender, EventArgs e)
        {
            System.Drawing.Graphics myGraphic;
            myGraphic = this.CreateGraphics();

            Pen myPen1 = new Pen(System.Drawing.Color.Brown, 5);
            Pen myPen2 = new Pen(System.Drawing.Color.Black, 5);
            Pen myPen3 = new Pen(System.Drawing.Color.Pink, 5);
            Pen myPen4 = new Pen(System.Drawing.Color.Wheat, 5);
            Pen myPen5 = new Pen(System.Drawing.Color.Red, 5);





            //myGraphic.DrawLine(myPen1, 50, 50, 200, 50); //จุดเร่ิ่ม จุดสิ้นสุด 
            //myGraphic.DrawRectangle(myPen1, 15, 35, 170, 140); //จุดมุมบนซ้าย ความกว้าง ความสูงของสี่เหลี่ยม
            //myGraphic.DrawEllipse(myPen2, 15, 35, 170, 140); //จุดมุมบนซ้าย ความกว้าง ความสูงของกรอบสี่เหลี่ยม
            //myGraphic.DrawArc(myPen1, 100, 100, 450, 450, 0, 45); //จุดมุมบนซ้าย ความกว้าง ความสูง องศาเริ่ม องศาสิ้นสุด ตามเข็ม

            myGraphic.DrawRectangle(myPen1, 100, 150, 140, 140);


            myGraphic.DrawLine(myPen3, 170, 288, 170, 153);
            myGraphic.DrawLine(myPen3, 103, 220,238, 220);

            myGraphic.DrawEllipse(myPen3, 120, 100, 50,50);
         
            myGraphic.DrawEllipse(myPen3, 170, 100, 50, 50);

            myGraphic.DrawArc(myPen3, 150, 10, 40, 280, 0, 50);
            myGraphic.DrawArc(myPen3, 100, 10, 40,280, 0,50);

            myGraphic.DrawRectangle(myPen4, 80, 293, 100,100);
            myGraphic.DrawRectangle(myPen5, 186, 293, 100, 100);

            myGraphic.DrawLine(myPen1, 490, 400, 490, 200);
            myGraphic.DrawLine(myPen1, 540, 400, 540, 200);
            myGraphic.DrawLine(myPen1, 500, 300, 200, 200);






        }
    }
}
