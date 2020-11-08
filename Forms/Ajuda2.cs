using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Trabalho_Marcio
{
    public partial class Ajuda2 : Form
    {
        public Ajuda2()
        {
            InitializeComponent();
            slide1.Visible = true;
            slide2.Visible = false;
            slide3.Visible = false;
            slide4.Visible = false;
            slide5.Visible = false;
            slide6.Visible = false;
            slide7.Visible = false;
            slide8.Visible = false;
            slide9.Visible = false;
            button1.Enabled = false;
        }
        public int contador = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (contador > 0)
            {
                button2.Enabled = true;
                contador--;

                {
                    slide9.Visible = true;
                }

            }
            else
            {
                button1.Enabled = false;
            }

            if (contador == 0)
            {
                slide1.Visible = true;
                slide2.Visible = false;
                slide3.Visible = false;
                slide4.Visible = false;
                slide5.Visible = false;
                slide6.Visible = false;
                slide7.Visible = false;
                slide8.Visible = false;
                slide9.Visible = false;
            }
            else if (contador == 1)
            {
                slide2.Visible = true;
                slide1.Visible = false;
                slide3.Visible = false;
                slide4.Visible = false;
                slide5.Visible = false;
                slide6.Visible = false;
                slide7.Visible = false;
                slide8.Visible = false;
                slide9.Visible = false;
            }
            else if (contador == 2)
            {
                slide3.Visible = true;
                slide2.Visible = false;
                slide1.Visible = false;
                slide4.Visible = false;
                slide5.Visible = false;
                slide6.Visible = false;
                slide7.Visible = false;
                slide8.Visible = false;
                slide9.Visible = false;
            }
            else if (contador == 3)
            {
                slide4.Visible = true;
                slide2.Visible = false;
                slide3.Visible = false;
                slide1.Visible = false;
                slide5.Visible = false;
                slide6.Visible = false;
                slide7.Visible = false;
                slide8.Visible = false;
                slide9.Visible = false;
            }
            else if (contador == 4)
            {
                slide5.Visible = true;
                slide2.Visible = false;
                slide3.Visible = false;
                slide4.Visible = false;
                slide5.Visible = false;
                slide6.Visible = false;
                slide7.Visible = false;
                slide8.Visible = false;
                slide9.Visible = false;
            }
            else if (contador == 5)
            {
                slide6.Visible = true;
                slide2.Visible = false;
                slide3.Visible = false;
                slide4.Visible = false;
                slide5.Visible = false;
                slide1.Visible = false;
                slide7.Visible = false;
                slide8.Visible = false;
                slide9.Visible = false;
            }
            else if (contador == 6)
            {
                slide7.Visible = true;
                slide2.Visible = false;
                slide3.Visible = false;
                slide4.Visible = false;
                slide5.Visible = false;
                slide6.Visible = false;
                slide1.Visible = false;
                slide8.Visible = false;
                slide9.Visible = false;
            }
            else if (contador == 7)
            {
                slide8.Visible = true;
                slide2.Visible = false;
                slide3.Visible = false;
                slide4.Visible = false;
                slide5.Visible = false;
                slide6.Visible = false;
                slide7.Visible = false;
                slide1.Visible = false;
                slide9.Visible = false;
            }
            else if (contador == 8)
            {
                slide9.Visible = true;
                slide2.Visible = false;
                slide3.Visible = false;
                slide4.Visible = false;
                slide5.Visible = false;
                slide6.Visible = false;
                slide7.Visible = false;
                slide8.Visible = false;
                slide1.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (contador < 8)
            {
                button1.Enabled = true;
                contador++;
              
            }
            else
            {
                button2.Enabled = false;
            }

            if (contador == 0)
            {
                slide1.Visible = true;
                slide2.Visible = false;
                slide3.Visible = false;
                slide4.Visible = false;
                slide5.Visible = false;
                slide6.Visible = false;
                slide7.Visible = false;
                slide8.Visible = false;
                slide9.Visible = false;
            }
            else if (contador == 1)
            {
                slide2.Visible = true;
                slide1.Visible = false;
                slide3.Visible = false;
                slide4.Visible = false;
                slide5.Visible = false;
                slide6.Visible = false;
                slide7.Visible = false;
                slide8.Visible = false;
                slide9.Visible = false;
            }
            else if (contador == 2)
            {
                slide3.Visible = true;
                slide2.Visible = false;
                slide1.Visible = false;
                slide4.Visible = false;
                slide5.Visible = false;
                slide6.Visible = false;
                slide7.Visible = false;
                slide8.Visible = false;
                slide9.Visible = false;
            }
            else if (contador == 3)
            {
                slide4.Visible = true;
                slide2.Visible = false;
                slide3.Visible = false;
                slide1.Visible = false;
                slide5.Visible = false;
                slide6.Visible = false;
                slide7.Visible = false;
                slide8.Visible = false;
                slide9.Visible = false;
            }
            else if (contador == 4)
            {
                slide5.Visible = true;
                slide2.Visible = false;
                slide3.Visible = false;
                slide4.Visible = false;
                slide1.Visible = false;
                slide6.Visible = false;
                slide7.Visible = false;
                slide8.Visible = false;
                slide9.Visible = false;
            }
            else if (contador == 5)
            {
                slide6.Visible = true;
                slide2.Visible = false;
                slide3.Visible = false;
                slide4.Visible = false;
                slide5.Visible = false;
                slide1.Visible = false;
                slide7.Visible = false;
                slide8.Visible = false;
                slide9.Visible = false;
            }
            else if (contador == 6)
            {
                slide7.Visible = true;
                slide2.Visible = false;
                slide3.Visible = false;
                slide4.Visible = false;
                slide5.Visible = false;
                slide6.Visible = false;
                slide1.Visible = false;
                slide8.Visible = false;
                slide9.Visible = false;
            }
            else if (contador == 7)
            {
                slide8.Visible = true;
                slide2.Visible = false;
                slide3.Visible = false;
                slide4.Visible = false;
                slide5.Visible = false;
                slide6.Visible = false;
                slide7.Visible = false;
                slide1.Visible = false;
                slide9.Visible = false;
            }
            else if (contador == 8)
            {
                slide9.Visible = true;
                slide2.Visible = false;
                slide3.Visible = false;
                slide4.Visible = false;
                slide5.Visible = false;
                slide6.Visible = false;
                slide7.Visible = false;
                slide8.Visible = false;
                slide1.Visible = false;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process pStart = new System.Diagnostics.Process();
            pStart.StartInfo = new System.Diagnostics.ProcessStartInfo(@"https://docs.google.com/document/d/1YiZfNUpdTs-ymK8DQK03kVKbvGBo-cbHhDRKlzN-lHU/edit");
            pStart.Start();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

    }

}


