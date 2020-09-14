using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BLLClass bll = new BLLClass();
        private void button1_Click(object sender, EventArgs e)
        {
            if(bll.Exist(txtname.Text, Convert.ToInt32(txtpassword.Text)))
            {
                MessageBox.Show("okay");
                Test t = new Test(Convert.ToInt32(txtpassword.Text));
                t.Show();
            }
            else
            {
                MessageBox.Show("try again");
            }
        }
    }
}
