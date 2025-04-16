using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C__ExaminationDepartment_1._0.Users;

namespace C__ExaminationDepartment_1._0.QuizFeature
{
    internal class Quiz
    {
        public string name;
        public string themeQuiz;
        public string nameOwner;
        public List<Question> questions;
        public List<User> top20user;

        public Quiz(string name, string themeQuiz, string nameOwner, List<Question> questions)
        {
            this.name = name;
            this.themeQuiz = themeQuiz;
            this.nameOwner = nameOwner;
            this.questions = questions;
            top20user = new List<User>();
        }
    }

}
