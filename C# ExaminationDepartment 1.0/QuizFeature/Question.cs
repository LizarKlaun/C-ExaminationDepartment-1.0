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

        public Question(string question, List<string> answers)
        {
            this.question = question;
            this.answers = answers;
        }

        public void DisplayQuestion()
        {
            Console.WriteLine(question);
            Console.WriteLine("Правильные ответы:");
            foreach (var answer in answers)
            {
                Console.WriteLine(answer);
            }
        }

        public bool CheckAnswer(string answer)
        {
            if (answers.Contains(answer))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
