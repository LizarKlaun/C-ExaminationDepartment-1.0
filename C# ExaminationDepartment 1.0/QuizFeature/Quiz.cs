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
        public List<QuizResult> top20user;

        public Quiz(string name, string themeQuiz, string nameOwner, List<Question> questions)
        {
            this.name = name;
            this.themeQuiz = themeQuiz;
            this.nameOwner = nameOwner;
            this.questions = questions;
            top20user = new List<QuizResult>();
        }

        public void StartQuiz(string userName)
        {
            Console.WriteLine($"\n Тест {name} начался!");
            Console.WriteLine($" Тематика теста: {themeQuiz}");
            Console.WriteLine($" Владелец теста: {nameOwner}");
            Console.WriteLine("\n Вопросы:\n");
            int i = 0;
            int countCorrectAnswers = 0;
            List<string> userAnswers = new List<string>();
            foreach (var question in questions)
            {
                i++;
                Console.WriteLine($" {i}: {question.question}");
                Console.Write("\nВведите ваш ответ: ");
                string? ansfer = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(ansfer))
                {
                    Console.Write("Поле ответ должен быть заполненным :< Пожалуйста повторите ваш Ответ: ");
                    ansfer = Console.ReadLine();
                }
                userAnswers.Add(ansfer);
                if (question.CheckAnswer(ansfer))
                {
                    countCorrectAnswers++;
                    Console.WriteLine("\n Правильный ответ! :-)\n");
                }
                else
                {
                    Console.WriteLine("\n Неправильный ответ. :-(\n");
                }
            }
            Console.WriteLine("\n Тест завершен!");
            QuizResult userResult = new QuizResult(userName, countCorrectAnswers, questions, userAnswers);
            top20user.Add(userResult);
        }

        public void DisplayTop20()
        {
            Console.WriteLine($"\n Тест {name}");
            Console.WriteLine($" Тематика теста: {themeQuiz}");
            Console.WriteLine($" Владелец теста: {nameOwner}");
            Console.WriteLine($" Топ 20 пользователей:");
            int i = 0;
            foreach (var user in top20user)
            {
                i++;
                Console.WriteLine();
                Console.WriteLine($"{i}.");
                user.DisplayResult();
            }
        }
    }
}
