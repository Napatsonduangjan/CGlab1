using System;
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
            Pen myPen6 = new Pen(System.Drawing.Color.Indigo, 5);
            Pen myPen7 = new Pen(System.Drawing.Color.Khaki, 5);
            Pen myPen8 = new Pen(System.Drawing.Color.LawnGreen, 5);
            Pen myPen9 = new Pen(System.Drawing.Color.YellowGreen, 5);
            Pen myPen10 = new Pen(System.Drawing.Color.Violet, 5);




            //myGraphic.DrawLine(myPen1, 50, 50, 200, 50); //จุดเร่ิ่ม จุดสิ้นสุด 
            //myGraphic.DrawRectangle(myPen1, 15, 35, 170, 140); //จุดมุมบนซ้าย ความกว้าง ความสูงของสี่เหลี่ยม
            //myGraphic.DrawEllipse(myPen2, 15, 35, 170, 140); //จุดมุมบนซ้าย ความกว้าง ความสูงของกรอบสี่เหลี่ยม
            //myGraphic.DrawArc(myPen1, 100, 100, 450, 450, 0, 45); //จุดมุมบนซ้าย ความกว้าง ความสูง องศาเริ่ม องศาสิ้นสุด ตามเข็ม

            //กล่องใหญ่ซ้าย
            myGraphic.DrawRectangle(myPen1, 100, 150, 140, 140);
            myGraphic.DrawLine(myPen3, 170, 288, 170, 153);
            myGraphic.DrawLine(myPen3, 103, 220,238, 220);
            myGraphic.DrawEllipse(myPen3, 120, 100, 50,50);
            myGraphic.DrawEllipse(myPen3, 170, 100, 50, 50);
            myGraphic.DrawArc(myPen3, 150, 10, 40, 280, 0,50);
            myGraphic.DrawArc(myPen3, 100, 10, 40,280, 0,50);

            //กล่องเล็กซ้าย
            myGraphic.DrawRectangle(myPen2, 25, 295, 68, 68);
            myGraphic.DrawRectangle(myPen9, 100, 295, 68,68);
            myGraphic.DrawRectangle(myPen5, 176, 295, 68, 68);
           
           //ตัวH
           
            myGraphic.DrawRectangle(myPen6, 400, 220, 140, 140); //กล่องใหญ่ขวา
            myGraphic.DrawRectangle(myPen8, 450, 165, 50, 50); //กล่องเล็กซ้าย

            
            myGraphic.DrawLine(myPen9, 550, 50, 550, 500); //เส้นตรง
            myGraphic.DrawEllipse(myPen5, 30, 30, 20, 20); //ประดับข้างบน
            myGraphic.DrawEllipse(myPen3, 50, 30, 20, 20);
            myGraphic.DrawEllipse(myPen8, 70, 30, 20, 20);
            myGraphic.DrawEllipse(myPen5, 90, 30, 20, 20);
            myGraphic.DrawEllipse(myPen2, 110, 30, 20, 20);
            myGraphic.DrawEllipse(myPen3, 130, 30, 20, 20);
            myGraphic.DrawEllipse(myPen7, 150, 30, 20, 20);
            myGraphic.DrawEllipse(myPen6, 170, 30, 20, 20);
            myGraphic.DrawEllipse(myPen2, 190, 30, 20, 20);
            myGraphic.DrawEllipse(myPen4, 210, 30, 20, 20);
            myGraphic.DrawEllipse(myPen5, 10, 30, 20, 20);
            myGraphic.DrawRectangle(myPen8, 230, 30, 20, 20);
            myGraphic.DrawRectangle(myPen4, 250, 30, 20, 20);
            myGraphic.DrawRectangle(myPen7, 270, 30, 20, 20);
            myGraphic.DrawRectangle(myPen6, 290, 30, 20, 20);
            myGraphic.DrawRectangle(myPen5, 310, 30, 20, 20);
            myGraphic.DrawRectangle(myPen3, 330, 30, 20, 20);
            myGraphic.DrawEllipse(myPen5, 350, 30, 20, 20);
            myGraphic.DrawRectangle(myPen6, 370, 30, 20, 20);
            myGraphic.DrawEllipse(myPen3, 390, 30, 20, 20);
            myGraphic.DrawRectangle(myPen8, 410, 30, 20, 20);
            myGraphic.DrawEllipse(myPen3, 430, 30, 20, 20);
            myGraphic.DrawRectangle(myPen4, 450, 30, 20, 20);
            myGraphic.DrawEllipse(myPen6, 470, 30, 20, 20);
            myGraphic.DrawRectangle(myPen4, 490, 30, 20, 20);
            myGraphic.DrawEllipse(myPen2, 510, 30, 20, 20);
            myGraphic.DrawRectangle(myPen4, 530, 30, 20, 20);

            












        }
    }
}
