using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__ExaminationDepartment_1._0.QuizFeature
{
    internal class ArrayQuizzes
    {
        public List<Quiz> quizzes = new List<Quiz>();
        public Quiz CreateQuiz(string name, string themeQuiz, string nameOwner, List<Question> questions)
        {
            Quiz quiz = new Quiz(name, themeQuiz, nameOwner, questions);
            quizzes.Add(quiz);
            Console.WriteLine("Вы успешно создали тест!");
            return quiz;
        }
    }
}
