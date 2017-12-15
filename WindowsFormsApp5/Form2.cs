using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form2 : Form
    {               
        string ok;                      //กำหนดตัวแปลมาคำนวณ
        public Form2()
        {
            InitializeComponent();
        }

        int dice1, dice2,dice3;         //กำหนดตัวแปลมาคำนวณ

        private void button4_Click(object sender, EventArgs e)
        {
            ok = "กบ";                                     //กำหนดตัวแปลมาคำวณ
            button10.Enabled = true;                       //เมื่อคลิกรูปสัตว์ปุ่มสุ่มจะเปิด
            button5.Enabled = false;                       //เมื่อคลิกรูปกบรูปสัตว์จะถูกปิด
            button6.Enabled = false;                       //เมื่อคลิกรูปกบรูปสัตว์จะถูกปิด
            button7.Enabled = false;                       //เมื่อคลิกรูปกบรูปสัตว์จะถูกปิด
            button8.Enabled = false;                       //เมื่อคลิกรูปกบรูปสัตว์จะถูกปิด
            button9.Enabled = false;                       //เมื่อคลิกรูปกบรูปสัตว์จะถูกปิด
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ok = "ปู";                                      //กำหนดตัวแปลมาคำวณ
            button10.Enabled = true;                       //เมื่อคลิกรูปสัตว์ปุ่มสุ่มจะเปิด
            button4.Enabled = false;                       //เมื่อคลิกรูปปูรูปสัตว์จะถูกปิด
            button6.Enabled = false;                       //เมื่อคลิกรูปปูรูปสัตว์จะถูกปิด
            button7.Enabled = false;                       //เมื่อคลิกรูปปูรูปสัตว์จะถูกปิด
            button8.Enabled = false;                       //เมื่อคลิกรูปปูรูปสัตว์จะถูกปิด
            button9.Enabled = false;                       //เมื่อคลิกรูปปูรูปสัตว์จะถูกปิด
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ok = "ปลา";                                     //กำหนดตัวแปลมาคำวณ
            button10.Enabled = true;                        //เมื่อคลิกรูปสัตว์ปุ่มสุ่มจะเปิด
            button4.Enabled = false;                        //เมื่อคลิกรูปปลารูปสัตว์จะถูกปิด
            button5.Enabled = false;                        //เมื่อคลิกรูปปลารูปสัตว์จะถูกปิด
            button7.Enabled = false;                        //เมื่อคลิกรูปปลารูปสัตว์จะถูกปิด
            button8.Enabled = false;                        //เมื่อคลิกรูปปลารูปสัตว์จะถูกปิด
            button9.Enabled = false;                        //เมื่อคลิกรูปปลารูปสัตว์จะถูกปิด
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ok = "กุ้ง";                                      //กำหนดตัวแปลมาคำวณ
            button10.Enabled = true;                        //เมื่อคลิกรูปสัตว์ปุ่มสุ่มจะเปิด
            button4.Enabled = false;                        //เมื่อคลิกรูปกุ้งรูปสัตว์จะถูกปิด
            button5.Enabled = false;                        //เมื่อคลิกรูปกุ้งรูปสัตว์จะถูกปิด
            button6.Enabled = false;                        //เมื่อคลิกรูปกุ้งรูปสัตว์จะถูกปิด
            button8.Enabled = false;                        //เมื่อคลิกรูปกุ้งรูปสัตว์จะถูกปิด
            button9.Enabled = false;                        //เมื่อคลิกรูปกุ้งรูปสัตว์จะถูกปิด
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ok = "ไก่";                                      //กำหนดตัวแปลมาคำวณ
            button10.Enabled = true;                        //เมื่อคลิกรูปสัตว์ปุ่มสุ่มจะเปิด
            button4.Enabled = false;                        //เมื่อคลิกรูปไก่รูปสัตว์จะถูกปิด
            button5.Enabled = false;                        //เมื่อคลิกรูปไก่รูปสัตว์จะถูกปิด
            button6.Enabled = false;                        //เมื่อคลิกรูปไก่รูปสัตว์จะถูกปิด
            button7.Enabled = false;                        //เมื่อคลิกรูปไก่รูปสัตว์จะถูกปิด
            button9.Enabled = false;                        //เมื่อคลิกรูปไก่รูปสัตว์จะถูกปิด
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ok = "น้ำเต้า";                                   //กำหนดตัวแปลมาคำวณ
            button10.Enabled = true;                       //เมื่อคลิกรูปสัตว์ปุ่มสุ่มจะเปิด
            button4.Enabled = false;                       //เมื่อคลิกรูปน้ำเต้ารูปสัตว์จะถูกปิด
            button5.Enabled = false;                       //เมื่อคลิกรูปน้ำเต้ารูปสัตว์จะถูกปิด
            button6.Enabled = false;                       //เมื่อคลิกรูปน้ำเต้ารูปสัตว์จะถูกปิด
            button7.Enabled = false;                       //เมื่อคลิกรูปน้ำเต้ารูปสัตว์จะถูกปิด
            button8.Enabled = false;                       //เมื่อคลิกรูปน้ำเต้ารูปสัตว์จะถูกปิด
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;                        //เมื่อคลิกรูปเงินรูปสัตว์จะเปิด
            button5.Enabled = true;                        //เมื่อคลิกรูปเงินรูปสัตว์จะเปิด
            button6.Enabled = true;                        //เมื่อคลิกรูปเงินรูปสัตว์จะเปิด
            button7.Enabled = true;                        //เมื่อคลิกรูปเงินรูปสัตว์จะเปิด
            button8.Enabled = true;                        //เมื่อคลิกรูปเงินรูปสัตว์จะเปิด
            button9.Enabled = true;                        //เมื่อคลิกรูปเงินรูปสัตว์จะเปิด
            textBox1.Text = "5";                           //แสดงเลข5ที่tb1
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;                        //เมื่อคลิกรูปเงินรูปสัตว์จะเปิด
            button5.Enabled = true;                        //เมื่อคลิกรูปเงินรูปสัตว์จะเปิด
            button6.Enabled = true;                        //เมื่อคลิกรูปเงินรูปสัตว์จะเปิด
            button7.Enabled = true;                        //เมื่อคลิกรูปเงินรูปสัตว์จะเปิด
            button8.Enabled = true;                        //เมื่อคลิกรูปเงินรูปสัตว์จะเปิด
            button9.Enabled = true;                        //เมื่อคลิกรูปเงินรูปสัตว์จะเปิด
            textBox1.Text = "10";                          //แสดงเลข10ที่tb1
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;                        //เมื่อคลิกรูปเงินรูปสัตว์จะเปิด
            button5.Enabled = true;                        //เมื่อคลิกรูปเงินรูปสัตว์จะเปิด
            button6.Enabled = true;                        //เมื่อคลิกรูปเงินรูปสัตว์จะเปิด
            button7.Enabled = true;                        //เมื่อคลิกรูปเงินรูปสัตว์จะเปิด
            button8.Enabled = true;                        //เมื่อคลิกรูปเงินรูปสัตว์จะเปิด
            button9.Enabled = true;                        //เมื่อคลิกรูปเงินรูปสัตว์จะเปิด
            textBox1.Text = "20";                          //แสดงเลข20ที่tb1
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;                        //เมื่อคลิกรูปเงินรูปสัตว์จะเปิด
            button5.Enabled = true;                        //เมื่อคลิกรูปเงินรูปสัตว์จะเปิด
            button6.Enabled = true;                        //เมื่อคลิกรูปเงินรูปสัตว์จะเปิด
            button7.Enabled = true;                        //เมื่อคลิกรูปเงินรูปสัตว์จะเปิด
            button8.Enabled = true;                        //เมื่อคลิกรูปเงินรูปสัตว์จะเปิด
            button9.Enabled = true;                        //เมื่อคลิกรูปเงินรูปสัตว์จะเปิด
            textBox1.Text = "50";                          //แสดงเลข50ที่tb1
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;                        //เมื่อคลิกรูปเงินรูปสัตว์จะเปิด
            button5.Enabled = true;                        //เมื่อคลิกรูปเงินรูปสัตว์จะเปิด
            button6.Enabled = true;                        //เมื่อคลิกรูปเงินรูปสัตว์จะเปิด
            button7.Enabled = true;                        //เมื่อคลิกรูปเงินรูปสัตว์จะเปิด
            button8.Enabled = true;                        //เมื่อคลิกรูปเงินรูปสัตว์จะเปิด
            button9.Enabled = true;                        //เมื่อคลิกรูปเงินรูปสัตว์จะเปิด
            textBox1.Text = "100";                         //แสดงเลข100ที่tb1
        }
        private void reset()                               //สร้างmethod reset
        {
            this.reset();                                  //กำหนดให้ reset
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            button4.Enabled = false;                       //เมื่อเปิดโปรแกรมปุ่มจะถูกปิด
            button5.Enabled = false;                       //เมื่อเปิดโปรแกรมปุ่มจะถูกปิด
            button6.Enabled = false;                       //เมื่อเปิดโปรแกรมปุ่มจะถูกปิด
            button7.Enabled = false;                       //เมื่อเปิดโปรแกรมปุ่มจะถูกปิด
            button8.Enabled = false;                       //เมื่อเปิดโปรแกรมปุ่มจะถูกปิด
            button9.Enabled = false;                       //เมื่อเปิดโปรแกรมปุ่มจะถูกปิด
            button10.Enabled = false;                      //เมื่อเปิดโปรแกรมปุ่มจะถูกปิด
        }
        bool t = true;                    //กำหนดตัวแปลมาเพื่อเปิดปิดปุ่ม
        private void button10_Click(object sender, EventArgs e)
        {
            {
                button11.Enabled = false;                        //เมื่อกดปุ่มสุ่มรูปเงินจะถูกปิด
                button12.Enabled = false;                        //เมื่อกดปุ่มสุ่มรูปเงินจะถูกปิด
                button13.Enabled = false;                        //เมื่อกดปุ่มสุ่มรูปเงินจะถูกปิด
                button14.Enabled = false;                        //เมื่อกดปุ่มสุ่มรูปเงินจะถูกปิด
                button15.Enabled = false;                        //เมื่อกดปุ่มสุ่มรูปเงินจะถูกปิด
            }
            if (t == true)                                      //กำหนดt=true
            {
                Random random = new Random();                   //กำตัวแปลสุ่มมาคำนวณ
                string[] copy = new string[3];                  //กำตัวแปลarrayมาคำนวณ
                //int okcopy = int.Parse(textBox1.Text);        //กำหนดตัวแปลมาแทนตัวเลขในtb1
                dice1 = random.Next(1, 7);                      //กำหนดขนาดการสุ่มของ dice1
                dice2 = random.Next(1, 7);                      //กำหนดขนาดการสุ่มของ dice2
                dice3 = random.Next(1, 7);                      //กำหนดขนาดการสุ่มของ dice3
                button4.Enabled = false;                        //เมื่อกดปุ่มสุ่มรูปสัตว์จะถูกปิด
                button5.Enabled = false;                        //เมื่อกดปุ่มสุ่มรูปสัตว์จะถูกปิด
                button6.Enabled = false;                        //เมื่อกดปุ่มสุ่มรูปสัตว์จะถูกปิด
                button7.Enabled = false;                        //เมื่อกดปุ่มสุ่มรูปสัตว์จะถูกปิด
                button8.Enabled = false;                        //เมื่อกดปุ่มสุ่มรูปสัตว์จะถูกปิด
                button9.Enabled = false;                        //เมื่อกดปุ่มสุ่มรูปสัตว์จะถูกปิด

                switch (dice1)                  //กำหนดเหตุการณ์ของdice1
                {
                    case 1:
                        {
                            pictureBox1.ImageLocation = Application.StartupPath + "\\kai.png";         //ให้ picbox1 แสดงรูปไก่
                            copy[0] = "ไก่";                                                            //แสดง array ในตำแหน่งที่ 0 
                            break;
                        }
                    case 2:
                        {
                            pictureBox1.ImageLocation = Application.StartupPath + "\\numtao.png";       //ให้ picbox1 แสดงรูปน้ำเต้า
                            copy[0] = "น้ำเต้า";                                                           //แสดง array ในตำแหน่งที่ 0 
                            break;
                        }
                    case 3:
                        {
                            pictureBox1.ImageLocation = Application.StartupPath + "\\par.png";          //ให้ picbox1 แสดงรูปปลา
                            copy[0] = "ปลา";                                                            //แสดง array ในตำแหน่งที่ 0 
                            break;
                        }
                    case 4:
                        {
                            pictureBox1.ImageLocation = Application.StartupPath + "\\kung.png";         //ให้ picbox1 แสดงรูปกุ้ง
                            copy[0] = "กุ้ง";                                                             //แสดง array ในตำแหน่งที่ 0 
                            break;
                        }
                    case 5:
                        {
                            pictureBox1.ImageLocation = Application.StartupPath + "\\poo.png";          //ให้ picbox1 แสดงรูปปู
                            copy[0] = "ปู";                                                              //แสดง array ในตำแหน่งที่ 0 
                            break;
                        }
                    case 6:
                        {
                            pictureBox1.ImageLocation = Application.StartupPath + "\\korb.png";         //ให้ picbox1 แสดงรูปกบ
                            copy[0] = "กบ";                                                             //แสดง array ในตำแหน่งที่ 0 
                            break;
                        }
                }

                switch (dice2)          //กำหนดเหตุการณ์ของdice2
                {
                    case 1:
                        {
                            pictureBox2.ImageLocation = Application.StartupPath + "\\kai.png";              //ให้ picbox2 แสดงรูปไก่
                            copy[1] = "ไก่";                                                                 //แสดง array ในตำแหน่งที่ 1 
                            break;
                        }
                    case 2:
                        {
                            pictureBox2.ImageLocation = Application.StartupPath + "\\numtao.png";           //ให้ picbox2 แสดงรูปน้ำเต้า
                            copy[1] = "น้ำเต้า";                                                               //แสดง array ในตำแหน่งที่ 1 
                            break;
                        }
                    case 3:
                        {
                            pictureBox2.ImageLocation = Application.StartupPath + "\\par.png";              //ให้ picbox2 แสดงรูปปลา
                            copy[1] = "ปลา";                                                                //แสดง array ในตำแหน่งที่ 1 
                            break;
                        }
                    case 4:
                        {
                            pictureBox2.ImageLocation = Application.StartupPath + "\\kung.png";             //ให้ picbox2 แสดงรูปกุ้ง 
                            copy[1] = "กุ้ง";                                                                 //แสดง array ในตำแหน่งที่ 1 
                            break;
                        }
                    case 5:
                        {
                            pictureBox2.ImageLocation = Application.StartupPath + "\\poo.png";              //ให้ picbox2 แสดงรูปปู
                            copy[1] = "ปู";                                                                  //แสดง array ในตำแหน่งที่ 1 
                            break;
                        }
                    case 6:
                        {
                            pictureBox2.ImageLocation = Application.StartupPath + "\\korb.png";             //ให้ picbox2 แสดงรูปกบ
                            copy[1] = "กบ";                                                                 //แสดง array ในตำแหน่งที่ 1 
                            break;
                        }
                }

                switch (dice3)              //กำหนดเหตุการณ์ของdice3
                {
                    case 1:
                        {
                            pictureBox3.ImageLocation = Application.StartupPath + "\\kai.png";             //ให้ picbox3 แสดงรูปไก่
                            copy[2] = "ไก่";                                                                //แสดง array ในตำแหน่งที่ 2 
                            break;
                        }
                    case 2:
                        {
                            pictureBox3.ImageLocation = Application.StartupPath + "\\numtao.png";           //ให้ picbox3 แสดงรูปน้ำเต้า
                            copy[2] = "น้ำเต้า";                                                               //แสดง array ในตำแหน่งที่ 2 
                            break;
                        }
                    case 3:
                        {
                            pictureBox3.ImageLocation = Application.StartupPath + "\\par.png";              //ให้ picbox3 แสดงรูปปลา
                            copy[2] = "ปลา";                                                                //แสดง array ในตำแหน่งที่ 2 
                            break;
                        }
                    case 4:
                        {
                            pictureBox3.ImageLocation = Application.StartupPath + "\\kung.png";             //ให้ picbox3 แสดงรูปกุ้ง
                            copy[2] = "กุ้ง";                                                                 //แสดง array ในตำแหน่งที่ 2 
                            break;
                        }
                    case 5:
                        {
                            pictureBox3.ImageLocation = Application.StartupPath + "\\poo.png";              //ให้ picbox3 แสดงรูปปู
                            copy[2] = "ปู";                                                                  //แสดง array ในตำแหน่งที่ 2 
                            break;
                        }
                    case 6:
                        {
                            pictureBox3.ImageLocation = Application.StartupPath + "\\korb.png";             //ให้ picbox3 แสดงรูปกบ
                            copy[2] = "กบ";                                                                 //แสดง array ในตำแหน่งที่ 2 
                            break;
                        }
                }
                int okcopy = int.Parse(textBox1.Text);            //กำหนดตัวแปลมาแทนตัวเลขในtb1
                int i = 0, num = 0, p = 0;                        //กำหนดตัวแปลมาคำนวณ
                while (i < copy.Length)                           //กำหนดเงื่อนไข i น้อยกว่าความยาว array
                {
                    if (copy[i] == ok)                            //กำหนดเงื่อนไขให้ ok อยู่ในความยาวของ array
                    {
                        num += 1;                                 //ให้ num เพิ่มที่ละ 1
                        p = 1;                                    //ให้ p=1
                    }
                    i++;                                          //ให้ i บวกขึ้นไปเรื่อยๆ
                }
                if (p == 1)                                       //กำหนดเงื่อนไข p=1
                    okcopy = (okcopy * num) + okcopy;             //นำเลขในtb1 ไปคูณจำนวนรูปสัตว์ที่ทายถูกแล้วนำไปบวกเลขในtb1
                else okcopy = okcopy * num;                       //กำหนดว่าถ้าไม่ได้อยู่ในเงื่อนไขifให้นำเลขในtb1ไปคูณกับจำนวณรูปที่ทายถูก
                textBox2.Text = okcopy.ToString();                //กำหนดให้ okcopy แสดงที่tb2 
                t = false;                                        //ปุ่มสุ่มจะไม่สามารถคลิกได้
                button10.Text = "เล่น";                          //แสดงปุ่มเล่นใหม่ที่ button10
                
            }
            
            else
            {
                this.Close();                                     //ปิดฟอร์ม2
                refresh();                                        //แล้วรัน method refresh
            }
        }
        public void refresh()                                     //เรียกใช้ method refresh
        {
            Form2 f2 = new Form2();                               //รับค่าฟอร์มสอง
            f2.Show();                                            //เปิดฟอร์ม
        }
    }
}
