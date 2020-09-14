using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace project
{
    public partial class usControlTop : UserControl
    {
        private static usControlTop _ucTop;
        public static usControlTop ucTop
        {
            get
            {
                if (_ucTop == null)
                    _ucTop = new usControlTop();
                return _ucTop;
            }
            set {
                _ucTop = null;
            }
        }
        public static int cnt = 1;
        Questions q = new Questions();
        public usControlTop()
        {
            InitializeComponent();
        }
        BLLClass bll = new BLLClass();

        private void usControlTop_Load(object sender, EventArgs e)
        {
            if (cnt <= 5)
            {
                q = bll.top5();
                lblQuestion.Text = q.QuestionText;
            }
            else
            {
                q = bll.next4();
                lblQuestion.Text = q.QuestionText;
            }
            mark.Text = q.Percent.ToString();
            cnt++;
        }
        public int getAnswer()
        {
            if(q.QuestionAnswer==Convert.ToInt32(txtAnswer.Text))
                return Convert.ToInt32(q.Percent);
            return 0;
        }
    }

}
