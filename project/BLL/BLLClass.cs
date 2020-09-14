using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLClass
    {
        projectdbEntities2 db = new projectdbEntities2();
        public bool Exist(string u, int p)
        {
            var answer = db.Users.Where(x => x.UserName == u && x.Userpassword == p).Select(x => x.UserName).Any();
            if (answer)
            {
                return true;
            }
            else
                return false;
        }
        public Questions top5()
        {
            Questions l = db.Questions.Where(y => y.ID < 11 && y.Percent == 6).Select(y => y).OrderBy(y => Guid.NewGuid()).FirstOrDefault();
            return l;
        }
        public Questions next4()
        {
            Questions l = db.Questions.Where(y => y.ID < 11 && y.Percent == 10).Select(y => y).OrderBy(y => Guid.NewGuid()).FirstOrDefault();
            return l;
        }
        public Questions end6()
        {
            Questions l = db.Questions.Where(y => y.ID > 11).Select(y => y).OrderBy(y => Guid.NewGuid()).FirstOrDefault();
            return l;
        }
        public List<Answers> end6answers(int id)
        {
            List<Answers> a = db.Answers.Where(y => y.QuestionID == id).ToList();
            return a;
        }
        public void save(int uP, int m)
        {
            using (projectdbEntities2 d = new projectdbEntities2())
            {
                History history = new History();
                history.idTest = 0;
                history.Userpassword = uP;
                history.TestDate = DateTime.Now;
                history.Mark = m;
                d.History.Add(history);
                d.Entry(history).State = System.Data.Entity.EntityState.Modified;
                d.SaveChanges();
            }
        }
    }
}


