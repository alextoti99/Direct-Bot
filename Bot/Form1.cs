using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Utils.init();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            Utils.getInstance.mainForm = frm;
            Utils.getInstance.isInLaptop = true;
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Utils.exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            Utils.getInstance.mainForm = frm;
            Utils.getInstance.isInLaptop = false;
            frm.Show();
            this.Hide();
        }
    }
}
