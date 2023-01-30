using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace At_Yarısı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rdm = new Random();
        int zaman=0;
        int boy;
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            label4.Text = zaman.ToString();
            zaman++;
            pictureBox1.Left = pictureBox1.Left + rdm.Next(4,10);
            pictureBox1.Width = pictureBox1.Width + rdm.Next(0, 2);

            pictureBox2.Left = pictureBox2.Left + rdm.Next(4, 10);
            pictureBox2.Width = pictureBox2.Width + rdm.Next(0, 2);

            pictureBox3.Left = pictureBox3.Left + rdm.Next(4, 10);
            pictureBox3.Width = pictureBox3.Width + rdm.Next(0, 2);

            if (pictureBox1.Left+pictureBox1.Width > label3.Left)
            { 
                timer1.Enabled = false; MessageBox.Show("Yarışı birinci at kazandı");
                pictureBox1.Left = 0;
                pictureBox2.Left = 0;
                pictureBox3.Left = 0;

                pictureBox1.Width = boy;
                pictureBox2.Width = boy;
                pictureBox3.Width = boy;
                zaman = 0;
                label4.Text = "0";
            }


            if (pictureBox2.Left+pictureBox2.Width > label3.Left) 
            { 
                timer1.Enabled = false; MessageBox.Show("Yarışı ikinci at kazandı");
                pictureBox1.Left = 0;
                pictureBox2.Left = 0;
                pictureBox3.Left = 0;

                pictureBox1.Width = boy;
                pictureBox2.Width = boy;
                pictureBox3.Width = boy;
                zaman = 0;
                label4.Text = "0";
            }


            if (pictureBox3.Left+pictureBox3.Width > label3.Left) 
            { 
                timer1.Enabled = false; MessageBox.Show("Yarışı üçüncü at kazandı");
                pictureBox1.Left = 0;
                pictureBox2.Left = 0;
                pictureBox3.Left = 0;

                pictureBox1.Width = boy;
                pictureBox2.Width = boy;
                pictureBox3.Width = boy;
                zaman = 0;
                label4.Text = "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            boy = pictureBox1.Width;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
