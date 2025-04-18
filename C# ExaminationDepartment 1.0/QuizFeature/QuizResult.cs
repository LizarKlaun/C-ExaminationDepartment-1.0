using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__ExaminationDepartment_1._0.QuizFeature
{
    internal class QuizResult
    {
        public string userName;
        public int countCorrectAnswers;
        public List<Question> questions;
        public List<string> userAnswers;

        public QuizResult(string userName, int countCorrectAnswers, List<Question> questions, List<string> userAnswers)
        {
            this.userName = userName;
            this.countCorrectAnswers = countCorrectAnswers;
            this.questions = questions;
            this.userAnswers = userAnswers;
        }

        public void DisplayResult()
        {
            Console.WriteLine($" Имя пользователя: {userName}");
            Console.WriteLine($" Количество правильных ответов: {countCorrectAnswers}");
            Console.WriteLine(" Ответы пользователя:");
            for (int i = 0; i < questions.Count; i++)
            {
                Console.WriteLine($" Вопрос {i+1}: {questions[i].question}");
                Console.WriteLine($" Ответ: {userAnswers[i]}");
            }
        }
    }
}
