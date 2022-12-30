using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PERFORMANS_ÖDEVİ_SAMET_GÜRYILDIRIM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } 
        int hak  =0 ;
        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            string kelime = "ÇADIR";
            
            textBox1.Text = textBox1.Text.ToUpper();
            if (textBox1.Text == "")
            {
                MessageBox.Show("BİR HARF GİRİNİZ");
            }
            if (label1.Text == "Ç" && label2.Text == "A" && label3.Text == "D" && label4.Text == "I" && label5.Text == "R")
            {
                MessageBox.Show("Kazandınız");
                button1.Enabled = false;
            }
            else
            {
                if (textBox1.Text == kelime[0].ToString())
                {
                    label1.Text = "Ç";
                    label1.BackColor = Color.Green;
                }


                if (textBox1.Text == kelime[1].ToString())
                {
                    label2.Text = "A";
                    label1.BackColor = Color.Green;
                }


                if (textBox1.Text == kelime[2].ToString())
                {
                    label3.Text = "D";
                    label1.BackColor = Color.Green;
                }


                if (textBox1.Text == kelime[3].ToString())
                {
                    label4.Text = "I";
                    label1.BackColor = Color.Green;
                }

                if (textBox1.Text == kelime[4].ToString())
                {
                    label5.Text = "R";
                    label1.BackColor = Color.Green;
                }
                else
                {


                    hak++;
                    if (hak == 1)
                    {
                        pictureBox1.Visible = true;
                    }
                    if (hak == 2)
                    {
                        pictureBox2.Visible = true;
                    }
                    if (hak == 3)
                    {
                        pictureBox3.Visible = true;
                    }
                    if (hak == 4)
                    {
                        pictureBox4.Visible = true;
                    }
                    if (hak == 5)
                    {
                        pictureBox5.Visible = true;
                    }
                    if (hak == 6)
                    {
                        pictureBox6.Visible = true;
                    }
                    if (hak == 7)
                    {
                        pictureBox7.Visible = true;
                    }
                    if (hak == 8)
                    {
                        pictureBox8.Visible = true;
                        button1.Enabled = false;
                        MessageBox.Show("Oyunu kaybetiniz");
                    }









                }







            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            button1.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string kelime = "ÇADIR";

            textBox1.Text = textBox1.Text.ToUpper();
            if (textBox1.Text == "")
            {
                MessageBox.Show("oyun baslıyo kemerlerinizi takın");
            }
            button1.Visible =true;
        }
    }
}
