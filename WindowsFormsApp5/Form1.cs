﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);                //ออกจากทรัพยากรทั้งหมด
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();             //กำหนดตัวแปล f2
            f2.Show();                          //เปิดฟอร์ม2
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();             //กำหนดตัวแปล f3
            f3.Show();                          //เปิดฟอร์ม3
        }
    }
}
