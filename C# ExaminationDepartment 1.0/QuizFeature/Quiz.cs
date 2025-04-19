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
        public QuizResult? top1;
        public List<Question> questions;
        public List<QuizResult> top20user;

        public Quiz(string name, string themeQuiz, string nameOwner, List<Question> questions)
        {
            this.name = name;
            this.themeQuiz = themeQuiz;
            this.nameOwner = nameOwner;
            top1 = null;
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
            Console.WriteLine($" Количество вопросов: {questions.Count}");
            Console.WriteLine($" Количество правильных ответов: {countCorrectAnswers}");
            QuizResult userResult = new QuizResult(userName, countCorrectAnswers, questions, userAnswers);
            if (top20user.Count() == 0)
            {
                top20user.Add(userResult);
            }
            bool isUserInTop20 = false;
            foreach (var user in top20user)
            {
                if (user.countCorrectAnswers < countCorrectAnswers)
                {
                    top20user.Insert(top20user.IndexOf(user), userResult);
                    isUserInTop20 = true;
                    break;
                }
            }
            if (!isUserInTop20 && top20user.Count() < 20 && top20user.Count() != 0)
            {
                top20user.Add(userResult);
            }
            if (top20user.Count > 20)
            {
                top20user.RemoveAt(20);
            }
            top1 = top20user[0];
        }

        public void DisplayTop20()
        {
            Console.WriteLine($"\n Викторина {name}");
            Console.WriteLine($" Тематика викторины: {themeQuiz}");
            Console.WriteLine($" Владелец викторины: {nameOwner}");
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

        public void DisplayTop1()
        {
            Console.WriteLine($"\n Викторина {name}");
            Console.WriteLine($" Тематика викторины: {themeQuiz}");
            Console.WriteLine($" Владелец викторины: {nameOwner}");
            Console.WriteLine($" Топ 1 пользователь:");
            if (top1 != null)
            {
                top1.DisplayResult();
            }
            else
            {
                Console.WriteLine(" Топ 1 пользователя отсутствует.");
            }
        }
    }
}
