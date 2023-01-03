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
            Pen myPen11 = new Pen(System.Drawing.Color.Green, 5);



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

            //กล่องเล็ก
            myGraphic.DrawRectangle(myPen2, 25, 295, 68, 68);
            myGraphic.DrawRectangle(myPen9, 100, 295, 68,68);
            myGraphic.DrawRectangle(myPen5, 176, 295, 68, 68);
            myGraphic.DrawRectangle(myPen8, 254, 295, 68, 68); 
            myGraphic.DrawRectangle(myPen1, 327, 295, 68, 68); 
            myGraphic.DrawRectangle(myPen3, 402, 295, 68, 68); 
            myGraphic.DrawRectangle(myPen6, 475, 295, 68, 68);


            //ตัวH
            myGraphic.DrawLine(myPen10, 40, 305, 40, 355);
            myGraphic.DrawLine(myPen10, 40, 330, 80, 330);
            myGraphic.DrawLine(myPen10, 80, 305, 80, 355);

            //ตัวN
            myGraphic.DrawLine(myPen10, 115, 305, 115, 355);
            myGraphic.DrawLine(myPen10, 115, 305, 155, 355);
            myGraphic.DrawLine(myPen10, 155, 305, 155, 355);

            //ตัวY
            myGraphic.DrawLine(myPen10, 190, 305, 210, 335);
            myGraphic.DrawLine(myPen10, 230, 305, 210, 335);
            myGraphic.DrawLine(myPen10, 210, 335, 210, 355);

            //2 023
            myGraphic.DrawLine(myPen10, 270, 305, 310, 305);
            myGraphic.DrawLine(myPen10, 270, 327, 310, 327);
            myGraphic.DrawLine(myPen10, 270, 350, 310, 350);
            myGraphic.DrawLine(myPen10, 310, 303, 310, 330);
            myGraphic.DrawLine(myPen10, 270, 325, 270, 352);

            // 2 0 23
            myGraphic.DrawRectangle(myPen10, 337, 305, 48, 48);

            //20 2 3
            myGraphic.DrawLine(myPen10, 412, 305, 460, 305);
            myGraphic.DrawLine(myPen10, 412, 327, 460, 327);
            myGraphic.DrawLine(myPen10, 412, 350, 460, 350);
            myGraphic.DrawLine(myPen10, 457, 305, 457, 325);
            myGraphic.DrawLine(myPen10, 414, 325, 414, 350);

            //202 3
            myGraphic.DrawLine(myPen10, 485, 305, 535, 305);
            myGraphic.DrawLine(myPen10, 485, 327, 535, 327);
            myGraphic.DrawLine(myPen10, 485, 350, 535, 350);
            myGraphic.DrawLine(myPen10, 532, 305, 532, 350);

            //ต้นคริสต์มาส
            myGraphic.DrawRectangle(myPen1, 380, 250, 30, 30);
            myGraphic.DrawLine(myPen11, 325, 250, 465, 250);
            myGraphic.DrawLine(myPen11, 325, 250, 395, 70);
            myGraphic.DrawLine(myPen11, 465, 250, 395, 70);
            


            myGraphic.DrawLine(myPen9, 550, 50, 550, 500); //เส้นตรง
            myGraphic.DrawEllipse(myPen3, 50, 30, 20, 20);//ประดับข้างบน
            myGraphic.DrawEllipse(myPen1, 30, 30, 20, 20);
            myGraphic.DrawEllipse(myPen8, 70, 30, 20, 20);
            myGraphic.DrawEllipse(myPen5, 90, 30, 20, 20);
            myGraphic.DrawEllipse(myPen2, 110, 30, 20, 20);
            myGraphic.DrawEllipse(myPen10, 130, 30, 20, 20);
            myGraphic.DrawEllipse(myPen7, 150, 30, 20, 20);
            myGraphic.DrawEllipse(myPen6, 170, 30, 20, 20);
            myGraphic.DrawEllipse(myPen2, 190, 30, 20, 20);
            myGraphic.DrawEllipse(myPen4, 210, 30, 20, 20);
            myGraphic.DrawEllipse(myPen5, 10, 30, 20, 20);
            myGraphic.DrawRectangle(myPen8, 230, 30, 20, 20);
            myGraphic.DrawRectangle(myPen4, 250, 30, 20, 20);
            myGraphic.DrawRectangle(myPen7, 270, 30, 20, 20);
            myGraphic.DrawRectangle(myPen6, 290, 30, 20, 20);
            myGraphic.DrawRectangle(myPen10, 310, 30, 20, 20);
            myGraphic.DrawRectangle(myPen3, 330, 30, 20, 20);
            myGraphic.DrawEllipse(myPen5, 350, 30, 20, 20);
            myGraphic.DrawRectangle(myPen6, 370, 30, 20, 20);
            myGraphic.DrawEllipse(myPen3, 390, 30, 20, 20);
            myGraphic.DrawRectangle(myPen8, 410, 30, 20, 20);
            myGraphic.DrawEllipse(myPen3, 430, 30, 20, 20);
            myGraphic.DrawRectangle(myPen1, 450, 30, 20, 20);
            myGraphic.DrawEllipse(myPen6, 470, 30, 20, 20);
            myGraphic.DrawRectangle(myPen4, 490, 30, 20, 20);
            myGraphic.DrawEllipse(myPen2, 510, 30, 20, 20);
            myGraphic.DrawRectangle(myPen10, 530, 30, 20, 20);

            












        }
    }
}
