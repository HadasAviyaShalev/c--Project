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
    public partial class Test : Form
    {
        int mark = 0;
        int cnt = 1;
        int UserPassword;
        BLLClass bll = new BLLClass();
        public Test(int userPassword)
        {
            InitializeComponent();
            UserPassword = userPassword;

        }

        private void Test_Load(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(usControlTop.ucTop))
            {
                panel.Controls.Add(usControlTop.ucTop);
                usControlTop.ucTop.BringToFront();
            }
            else
            {
                usControlTop.ucTop.BringToFront();
            }
            cnt++;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (cnt<11)
            {
                if (usControlTop.ucTop.getAnswer()>-1)
                {
                    mark += usControlTop.ucTop.getAnswer();
                    lblmark.Text = mark.ToString();
                }
            }
            else
            {
                if (usControlEnd.ucEnd.getAnswer() > -1)
                {
                    mark += usControlEnd.ucEnd.getAnswer();
                    lblmark.Text = mark.ToString();
                }
            }
            if (cnt <= 9)
            {
                usControlTop.ucTop = null;
                if (!panel.Controls.Contains(usControlTop.ucTop))
                {
                    panel.Controls.Add(usControlTop.ucTop);
                    usControlTop.ucTop.BringToFront();
                }
                else
                {
                    usControlTop.ucTop.BringToFront();
                }
            }
            else if(cnt<=15)
            {
                panel.Controls.Clear();
                usControlEnd.ucEnd = null;
                if (!panel.Controls.Contains(usControlEnd.ucEnd))
                {
                    panel.Controls.Add(usControlEnd.ucEnd);
                    usControlEnd.ucEnd.BringToFront();
                }
                else 
                {
                    usControlEnd.ucEnd.BringToFront();
                }
            }
            else
            {
                MessageBox.Show("endddd");
                bll.save(UserPassword, mark);
            }
            cnt++;
        }
    }
}
