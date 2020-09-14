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
    public partial class usControlEnd : UserControl
    {
        private static usControlEnd _ucEnd;
        public static usControlEnd ucEnd
        {
            get
            {
                if (_ucEnd == null)
                    _ucEnd = new usControlEnd();
                return _ucEnd;
            }
            set
            {
                _ucEnd = null;
            }
        }
        public usControlEnd()
        {
            InitializeComponent();
        }
        Questions q = new Questions();
        BLLClass bll = new BLLClass();
        List<Answers> answers = new List<Answers>();
        private void usControlEnd_Load(object sender, EventArgs e)
        {
            q = bll.end6();
            lblQuestion.Text = q.QuestionText;
            mark.Text = q.Percent.ToString();

            answers = bll.end6answers(q.ID);
            radioButton1.Text = answers[0].AnswerValue.ToString();
            radioButton2.Text = answers[1].AnswerValue.ToString();
            radioButton3.Text = answers[2].AnswerValue.ToString();
            radioButton4.Text = answers[3].AnswerValue.ToString();
        }
        public int getAnswer()
        {
            if (answers[0].ID == q.QuestionAnswer && radioButton1.Checked)
                return Convert.ToInt32(q.Percent);
            else if (answers[1].ID == q.QuestionAnswer && radioButton2.Checked)
                return Convert.ToInt32(q.Percent);
            else if (answers[2].ID == q.QuestionAnswer && radioButton3.Checked)
                return Convert.ToInt32(q.Percent);
            else if (answers[3].ID == q.QuestionAnswer && radioButton4.Checked)
                return Convert.ToInt32(q.Percent);
            return 0;

            // if (radioButton1.Checked&& answers[1].ID==q.QuestionAnswer)
        }
        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }
    }
}
