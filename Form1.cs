using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zags
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void openchild(Panel pen, Form emptyF)
        {
            emptyF.TopLevel = false;
            emptyF.FormBorderStyle = FormBorderStyle.None;
            emptyF.Dock = DockStyle.Fill;
            pen.Controls.Add(emptyF);
            emptyF.BringToFront();
            emptyF.Show();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openchild(panel2, new Clients());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openchild(panel2, new Contract());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openchild(panel2, new Structure());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openchild(panel2, new Type());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openchild(panel2, new Workers());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openchild(panel2, new Acts());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openchild(panel2, new Post());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            openchild(panel2, new Department());
        }
    }
}
