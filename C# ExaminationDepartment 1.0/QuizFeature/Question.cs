using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__ExaminationDepartment_1._0.QuizFeature
{
    public class Question
    {
        public string question;
        private List<string> answers;
        private List<string> incorrectAnswers;

        public Question(string question, List<string> answers, List<string> incorrectAnswers)
        {
            this.question = question;
            this.answers = answers;
            this.incorrectAnswers = incorrectAnswers;
        }
    }

}
