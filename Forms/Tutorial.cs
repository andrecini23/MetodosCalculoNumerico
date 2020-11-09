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
    public partial class Tutorial : Form
    {
        public int page = 1;
        public bool final = false;

        public Tutorial()
        {
            InitializeComponent();
            pic1.Visible = true;
            rb1.Checked = true;
            pic2.Visible = false;
            pic3.Visible = false;
            pic4.Visible = false;
            pic5.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Tutorial_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            page++;
            if (page == 1)
            {
                pic1.Visible = true;
                pic2.Visible = false;
                pic3.Visible = false;
                pic4.Visible = false;
                pic5.Visible = false;
                rb1.Checked = true;

            }
            else if (page == 2)
            {
                pic1.Visible = false;
                pic2.Visible = true;
                pic3.Visible = false;
                pic4.Visible = false;
                pic5.Visible = false;
                rb2.Checked = true;

            }
            else if (page == 3)
            {
                pic1.Visible = false;
                pic2.Visible = false;
                pic3.Visible = true;
                pic4.Visible = false;
                pic5.Visible = false;
                rb3.Checked = true;

            }
            else if (page == 4)
            {
                pic1.Visible = false;
                pic2.Visible = true;
                pic3.Visible = false;
                pic4.Visible = true;
                pic5.Visible = false;
                rb4.Checked = true;

            }
            else if (page == 5)
            {
                button2.Enabled = false;
                pic1.Visible = false;
                pic2.Visible = false;
                pic3.Visible = false;
                pic4.Visible = false;
                pic5.Visible = true;
                rb5.Checked = true;
                final = true;
            }
            
            if(final)
            {
                button3.Text = "Iniciar";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            page--;
            if (page == 1)
            {
                button1.Enabled = false;
                pic1.Visible = true;
                pic2.Visible = false;
                pic3.Visible = false;
                pic4.Visible = false;
                pic5.Visible = false;
                rb1.Checked = true;

            }
            else if (page == 2)
            {
                pic1.Visible = false;
                pic2.Visible = true;
                pic3.Visible = false;
                pic4.Visible = false;
                pic5.Visible = false;
                rb2.Checked = true;

            }
            else if (page == 3)
            {
                pic1.Visible = false;
                pic2.Visible = false;
                pic3.Visible = true;
                pic4.Visible = false;
                pic5.Visible = false;
                rb3.Checked = true;

            }
            else if (page == 4)
            {
                pic1.Visible = false;
                pic2.Visible = true;
                pic3.Visible = false;
                pic4.Visible = true;
                pic5.Visible = false;
                rb4.Checked = true;

            }
            else if (page == 5)
            {
                pic1.Visible = false;
                pic2.Visible = false;
                pic3.Visible = false;
                pic4.Visible = false;
                pic5.Visible = true;
                rb4.Checked = true;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 calculadora = new Form1();
            calculadora.ShowDialog();
            this.Hide();
        }
    }
}
