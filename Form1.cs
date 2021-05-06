using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernLoginFORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

 
        private void Form1_Load(object sender, EventArgs e)
        {
            frm2.Show();
        }

        
        Form2 frm2 = new Form2();
       
        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            picuser.BackgroundImage = Properties.Resources.user1;
            panel1.BackColor = Color.FromArgb(78, 184, 206);
            textBox1.ForeColor = Color.FromArgb(78, 184, 206);

            
            picpass.BackgroundImage = Properties.Resources.pass1;
            panel2.ForeColor = Color.White;
            textBox2.ForeColor = Color.White;

           
            picemail.BackgroundImage = Properties.Resources.email1;
            panel3.ForeColor = Color.WhiteSmoke;
            textBox3.ForeColor = Color.WhiteSmoke;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            picemail.BackgroundImage = Properties.Resources.email1;
            panel3.BackColor = Color.FromArgb(78, 184, 206);
            textBox3.ForeColor = Color.FromArgb(7, 184, 206);

            picuser.BackgroundImage = Properties.Resources.user1;
            panel1.ForeColor = Color.WhiteSmoke;
            textBox1.ForeColor = Color.WhiteSmoke;

            picpass.BackgroundImage = Properties.Resources.pass1;
            panel2.ForeColor = ForeColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;

        }
        

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox2.PasswordChar = '*';
            picpass.BackgroundImage = Properties.Resources.pass1;
            panel2.BackColor = Color.FromArgb(78, 184, 206);
            textBox2.ForeColor = Color.FromArgb(78, 184, 206);

            picuser.BackgroundImage = Properties.Resources.user1;
            panel1.BackColor = Color.WhiteSmoke;
            textBox1.ForeColor = Color.WhiteSmoke;


            picemail.BackgroundImage = Properties.Resources.email1;
            panel3.BackColor = Color.WhiteSmoke;
            textBox3.ForeColor = Color.WhiteSmoke;                  
        }

        private void picfb_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           // label2.Text = frm2.Left.ToString();
            frm2.Left += 10;
            if(frm2.Left >= 830)
            {
                timer1.Stop();
                this.TopMost = false;
                frm2.TopMost = true;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //label2.Text = frm2.Left.ToString();
            frm2.Left -= 10;
            if(frm2.Left <=525)
            {
                timer2.Stop();
            }
        } 

        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
