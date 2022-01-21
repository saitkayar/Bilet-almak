using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seyahatacentasıform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
           
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
          

            listBox2.Items.Add(ad.Text);
            listBox3.Items.Add(soyad.Text);
            listBox4.Items.Add(comboBox2.Text);
            progressBar1.Value++;
          
          
          
                if (progressBar1.Value==9)
                {
                    MessageBox.Show("Otobüs dolmuştur.");
                    progressBar1.BackColor = Color.Red;
                button10.Enabled = false;
                }

            for (int i = 0; i < 8; i++)
            {
                if (but[i].Text == comboBox2.Text)
                {
                    but[i].BackColor = Color.Red;
                }
            }

            //if (textBox3.Text)
            //{

            //}

            comboBox2.Items.RemoveAt(comboBox2.SelectedIndex);

            var nesneler = groupBox2.Controls.OfType<TextBox>();

            foreach (var nesne in nesneler)
            {
                nesne.Clear();
            }

        }

        List<Button> but = new List<Button>();
        
       
        private void Form1_Load(object sender, EventArgs e)
        {
            Random rsg = new Random();
            Random rsg2 = new Random();
           
            but.Add(k1);
            but.Add(k2);
            but.Add(k3);
            but.Add(k4);
            but.Add(k5);
            but.Add(k6);
            but.Add(k7);
            but.Add(k8);

            for (int i =0; i < rsg2.Next(3,8); i++)
            {
                
                but[rsg.Next(0,8)].BackColor = Color.Red;
                progressBar1.Value ++;

            }
            
            for (int i = 0; i < 8; i++)
            {
                but[i].Enabled = false;
                if (but[i].BackColor != Color.Red)
                {
                    comboBox2.Items.Add(but[i].Text);
                    but[i].BackColor = Color.Green;
                    
                }
               
            }


        


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }
    }
}
