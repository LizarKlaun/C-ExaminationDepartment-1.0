using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__ExaminationDepartment_1._0.QuizFeature
{
    internal class ArrayCuizzes
    {
        public List<Quiz> quizzes = new List<Quiz>();
        public Quiz CreateQuiz(string name, string themeQuiz, string nameOwner, List<Question> questions)
        {
            foreach (Quiz quiz1 in quizzes)
            {
                if (quiz1.name == name)
                {
                    Console.WriteLine("Такой тест уже существует.");
                    return null;
                }
            }
            Quiz quiz = new Quiz(name, themeQuiz, nameOwner, questions);
            quizzes.Add(quiz);
            Console.WriteLine("Вы успешно создали тест!");
            return quiz;
        }
    }
}
