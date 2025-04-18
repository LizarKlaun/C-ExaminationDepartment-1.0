using System.Globalization;
using C__ExaminationDepartment_1._0.Users;
using C__ExaminationDepartment_1._0.QuizFeature;

namespace C__ExaminationDepartment_1._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayUsers users = new ArrayUsers();
            ArrayCuizzes quizzes = new ArrayCuizzes();
            User? user = new User("Lizar", "Klaun", 25);
            users.users.Add(user);
            user = null;
            string? name;
            string? login;
            int age;

            while (true)
            {
                while (user == null)
                {
                    Console.Write($"\n 1.Залогинится\n 2.Зарегистрироваться\n 3.Выйти\n Выберите как вы хотите войти или выйти: ");
                    int lol1;
                    while (!int.TryParse(Console.ReadLine(), out lol1))
                    {
                        Console.Write(" Неверный ввод :< Введите пожалуйста число: ");
                    }
                    Console.WriteLine();
                    if (lol1 == 1)
                    {
                        Console.Write("Введите Имя: ");
                        name = Console.ReadLine();
                        while (string.IsNullOrWhiteSpace(name))
                        {
                            Console.Write("Поле Имя должно быть заполненным :< Введите пожалуйста Имя: ");
                            name = Console.ReadLine();
                        }
                        Console.Write("Введите Пароль: ");
                        login = Console.ReadLine();
                        while (string.IsNullOrWhiteSpace(login))
                        {
                            Console.Write("Поле Пароль должно быть заполненным :< Введите пожалуйста Пароль: ");
                            login = Console.ReadLine();
                        }
                        user = users.Login(name, login);
                    }
                    else if (lol1 == 2)
                    {
                        Console.Write("Введите Имя: ");
                        name = Console.ReadLine();
                        while (string.IsNullOrWhiteSpace(name))
                        {
                            Console.Write("Поле Имя должно быть заполненным :< Введите пожалуйста Имя: ");
                            name = Console.ReadLine();
                        }
                        Console.Write("Введите Пароль: ");
                        login = Console.ReadLine();
                        while (string.IsNullOrWhiteSpace(login))
                        {
                            Console.Write("Поле Пароль должно быть заполненным :< Введите пожалуйста Пароль: ");
                            login = Console.ReadLine();
                        }
                        Console.Write("Повторите Пароль: ");
                        string? login1 = Console.ReadLine();
                        while (string.IsNullOrWhiteSpace(login1))
                        {
                            Console.Write("Поле Повторный Пароль должно быть заполненным :< Пожалуйста Повторите Пароль: ");
                            login1 = Console.ReadLine();
                        }
                        while (login != login1)
                        {
                            Console.WriteLine("Пароли не совпадают )_(");
                            Console.WriteLine("Введите Пароль: ");
                            login = Console.ReadLine();
                            while (string.IsNullOrWhiteSpace(login))
                            {
                                Console.Write("Поле Пароль должно быть заполненным :< Введите пожалуйста Пароль: ");
                                login = Console.ReadLine();
                            }
                            Console.WriteLine("Повторите Пароль: ");
                            login1 = Console.ReadLine();
                            while (string.IsNullOrWhiteSpace(login1))
                            {
                                Console.Write("Поле Повторный Пароль должно быть заполненным :< Пожалуйста Повторите Пароль: ");
                                login1 = Console.ReadLine();
                            }
                        }
                        Console.Write("Введите Возраст: ");
                        while (!int.TryParse(Console.ReadLine(), out age))
                        {
                            Console.Write("Неверный ввод :< Введите пожалуйста число: ");
                        }
                        user = users.Register(name, login, age);
                    }
                    //else if (lol1 == 3)
                    //{
                    //    foreach (User user1 in users.users)
                    //    {
                    //        Console.WriteLine($" Имя: {user1.name}\n Пароль: {user1.login}\n Возраст: {user1.age}");
                    //    }
                    //}
                    else
                    {
                        return;
                    }
                }
                user.Print();
                while (true)
                {
                    Console.WriteLine();
                    Console.Write($" 1.Начать новую викторину\n 2.Создать новую викторину\n 3.Просмотреть результаты викторин\n 4.Просмотреть Топ-20 с конкретной викторины\n 5.Просмотреть статус аккаунта\n 6.Сменить Имя Пароль или Возраст\n 7.Выйти с аккаунта\n Выберите что вы хотите делать: ");
                    int lol2;
                    while (!int.TryParse(Console.ReadLine(), out lol2) || lol2 > 7 || lol2 < 1)
                    {
                        Console.Write(" Неверный ввод :< Введите пожалуйста число: ");
                    }
                    Console.WriteLine();
                    if (lol2 == 1)
                    {
                        Console.WriteLine(" 1.История \n 2.География \n 3.Биология\n 4.Математика\n 5.Универсальная\n");
                        Console.Write("Выберите тему викторины: ");
                        int lol3;
                        while (!int.TryParse(Console.ReadLine(), out lol3) || lol3 > 5 || lol3 < 1)
                        {
                            Console.Write(" Неверный ввод :< Введите пожалуйста число: ");
                        }
                        int i = 0;
                        int lol4 = 0;
                        switch (lol3)
                        {
                            case 1:
                                if (quizzes.quizzes.Where(quiz => quiz.themeQuiz == "История").ToList().Count == 0)
                                {
                                    Console.WriteLine("Викторин c этой темой нету :<");
                                    break;
                                }
                                Console.WriteLine($"Викторины с Истории: ");
                                foreach (Quiz quiz in quizzes.quizzes.Where(quiz => quiz.themeQuiz == "История").ToList())
                                {
                                    i++;
                                    Console.WriteLine($"{i}: {quiz.name}");
                                }
                                Console.Write("Выберите викторину: ");
                                while (!int.TryParse(Console.ReadLine(), out lol4) || lol4 > i || lol4 < 1)
                                {
                                    Console.Write(" Неверный ввод :< Введите пожалуйста число: ");
                                }
                                quizzes.quizzes[lol4 - 1].StartQuiz(user.name);
                                break;
                            case 2:
                                if (quizzes.quizzes.Where(quiz => quiz.themeQuiz == "География").ToList().Count == 0)
                                {
                                    Console.WriteLine("Викторин c этой темой нету :<");
                                    break;
                                }
                                Console.WriteLine($"Викторины с Географии: ");
                                foreach (Quiz quiz in quizzes.quizzes.Where(quiz => quiz.themeQuiz == "География").ToList())
                                {
                                    i++;
                                    Console.WriteLine($"{i}: {quiz.name}");
                                }
                                Console.Write("Выберите викторину: ");
                                while (!int.TryParse(Console.ReadLine(), out lol4) || lol4 > i || lol4 < 1)
                                {
                                    Console.Write(" Неверный ввод :< Введите пожалуйста число: ");
                                }
                                quizzes.quizzes[lol4 - 1].StartQuiz(user.name);
                                break;
                            case 3:
                                if (quizzes.quizzes.Where(quiz => quiz.themeQuiz == "Биология").ToList().Count == 0)
                                {
                                    Console.WriteLine("Викторин c этой темой нету :<");
                                    break;
                                }
                                Console.WriteLine($"Викторины с Биологии: ");
                                foreach (Quiz quiz in quizzes.quizzes.Where(quiz => quiz.themeQuiz == "Биология").ToList())
                                {
                                    i++;
                                    Console.WriteLine($"{i}: {quiz.name}");
                                }
                                Console.Write("Выберите викторину: ");
                                while (!int.TryParse(Console.ReadLine(), out lol4) || lol4 > i || lol4 < 1)
                                {
                                    Console.Write(" Неверный ввод :< Введите пожалуйста число: ");
                                }
                                quizzes.quizzes[lol4 - 1].StartQuiz(user.name);
                                break;
                            case 4:
                                if (quizzes.quizzes.Where(quiz => quiz.themeQuiz == "Математика").ToList().Count == 0)
                                {
                                    Console.WriteLine("Викторин c этой темой нету :<");
                                    break;
                                }
                                Console.WriteLine($"Викторины с Математики: ");
                                foreach (Quiz quiz in quizzes.quizzes.Where(quiz => quiz.themeQuiz == "Математика").ToList())
                                {
                                    i++;
                                    Console.WriteLine($"{i}: {quiz.name}");
                                }
                                Console.Write("Выберите викторину: ");
                                while (!int.TryParse(Console.ReadLine(), out lol4) || lol4 > i || lol4 < 1)
                                {
                                    Console.Write(" Неверный ввод :< Введите пожалуйста число: ");
                                }
                                quizzes.quizzes[lol4 - 1].StartQuiz(user.name);
                                break;
                        }
                    }
                    else if (lol2 == 2)
                    {
                        Console.Write("Введите название викторины: ");
                        name = Console.ReadLine();
                        while (string.IsNullOrWhiteSpace(name))
                        {
                            Console.Write("Название викторины должно быть заполненным :< Введите пожалуйта название викторины: ");
                            name = Console.ReadLine();
                        }
                        Console.Write("1. История \n2. География \n3. Биология\n4. Математика\n");
                        Console.Write("Выберите тему викторины: ");
                        int lol3;
                        while (!int.TryParse(Console.ReadLine(), out lol3) || lol3 > 4 || lol3 < 1)
                        {
                            Console.Write(" Неверный ввод :< Введите пожалуйста число: ");
                        }

                        string theme;

                        if (lol3 == 1)
                        {
                            theme = "История";
                        }
                        else if (lol3 == 2)
                        {
                            theme = "География";
                        }
                        else if (lol3 == 3)
                        {
                            theme = "Биология";
                        }
                        else
                        {
                            theme = "Математика";
                        }

                        int countOfQuestions = 0;
                        Console.Write($"Введите количество вопросов в викторине: ");
                        while (countOfQuestions < 1)
                        {
                            while (!int.TryParse(Console.ReadLine(), out countOfQuestions))
                            {
                                Console.Write("Неверный ввод :< Введите пожалуйста число: ");
                            }
                            if (countOfQuestions < 1)
                            {
                                Console.WriteLine("Количество вопросов не может быть меньше 1");
                                Console.Write($"Введите количество вопросов в викторине: ");
                            }
                        }

                        List<Question> questions = new List<Question>();
                        for (int i = 0; i < countOfQuestions; i++)
                        {
                            Console.Write($"Введите {i + 1} вопрос: ");
                            string? question = Console.ReadLine();
                            while (string.IsNullOrWhiteSpace(question))
                            {
                                Console.Write("Вопрос должен быть заполненным :< Введите пожалуйста Вопрос: ");
                                question = Console.ReadLine();
                            }

                            Console.Write($"Введите количество правильных ответов на вопросс: ");
                            int countOfRightAnsfers = 0;
                            while (countOfRightAnsfers < 1)
                            {
                                while (!int.TryParse(Console.ReadLine(), out countOfRightAnsfers))
                                {
                                    Console.Write("Неверный ввод :< Введите пожалуйста число: ");
                                }
                                if (countOfRightAnsfers < 1)
                                {
                                    Console.WriteLine("Количество правильных ответов не может быть больше самих ответов");
                                    Console.Write($"Введите количество правильных ответов на вопросс: ");
                                }
                            }

                            List<string> ansfers = new List<string>();
                            for (int j = 0; j < countOfRightAnsfers; j++)
                            {
                                Console.Write($"Введите {j + 1} правильный ответ на вопрос : ");
                                string? ansfer = Console.ReadLine();
                                while (string.IsNullOrWhiteSpace(ansfer))
                                {
                                    Console.Write($"Правильный ответ должен быть заполненным :< Введите пожалуйста  {j + 1} Правильный ответ на вопрос: ");
                                    ansfer = Console.ReadLine();
                                }
                                ansfers.Add(ansfer);
                            }
                            Question question1 = new Question(question, ansfers);
                            questions.Add(question1);
                        }
                        quizzes.CreateQuiz(name, theme, user.name, questions);
                    }
                    else if (lol2 == 3)
                    {
                        Console.WriteLine($"\n Викторины {user.name}:");
                        int i = 0;
                        foreach (Quiz quiz in quizzes.quizzes)
                        {
                            if (quiz.nameOwner == user.name)
                            {
                                i++;
                                Console.Write($" {i}. ");
                                quiz.DisplayTop1();
                            }
                        }
                    }
                    else if (lol2 == 4)
                    {
                        Console.WriteLine(" 1.История \n 2.География \n 3.Биология\n 4.Математика\n 5.Универсальная\n");
                        Console.Write("Выберите тему викторины: ");
                        int lol3;
                        while (!int.TryParse(Console.ReadLine(), out lol3) || lol3 > 5 || lol3 < 1)
                        {
                            Console.Write(" Неверный ввод :< Введите пожалуйста число: ");
                        }
                        int i = 0;
                        int lol4 = 0;
                        switch (lol3)
                        {
                            case 1:
                                if (quizzes.quizzes.Where(quiz => quiz.themeQuiz == "История").ToList().Count == 0)
                                {
                                    Console.WriteLine("Викторин c этой темой нету :<");
                                    break;
                                }
                                Console.WriteLine($"Викторины с Истории: ");
                                foreach (Quiz quiz in quizzes.quizzes.Where(quiz => quiz.themeQuiz == "История").ToList())
                                {
                                    i++;
                                    Console.WriteLine($"{i}: {quiz.name}");
                                }
                                Console.Write("Выберите викторину: ");
                                while (!int.TryParse(Console.ReadLine(), out lol4) || lol4 > i || lol4 < 1)
                                {
                                    Console.Write(" Неверный ввод :< Введите пожалуйста число: ");
                                }
                                quizzes.quizzes[lol4 - 1].DisplayTop20();
                                break;
                            case 2:
                                if (quizzes.quizzes.Where(quiz => quiz.themeQuiz == "География").ToList().Count == 0)
                                {
                                    Console.WriteLine("Викторин c этой темой нету :<");
                                    break;
                                }
                                Console.WriteLine($"Викторины с Географии: ");
                                foreach (Quiz quiz in quizzes.quizzes.Where(quiz => quiz.themeQuiz == "География").ToList())
                                {
                                    i++;
                                    Console.WriteLine($"{i}: {quiz.name}");
                                }
                                Console.Write("Выберите викторину: ");
                                while (!int.TryParse(Console.ReadLine(), out lol4) || lol4 > i || lol4 < 1)
                                {
                                    Console.Write(" Неверный ввод :< Введите пожалуйста число: ");
                                }
                                quizzes.quizzes[lol4 - 1].DisplayTop20();
                                break;
                            case 3:
                                if (quizzes.quizzes.Where(quiz => quiz.themeQuiz == "Биология").ToList().Count == 0)
                                {
                                    Console.WriteLine("Викторин c этой темой нету :<");
                                    break;
                                }
                                Console.WriteLine($"Викторины с Биологии: ");
                                foreach (Quiz quiz in quizzes.quizzes.Where(quiz => quiz.themeQuiz == "Биология").ToList())
                                {
                                    i++;
                                    Console.WriteLine($"{i}: {quiz.name}");
                                }
                                Console.Write("Выберите викторину: ");
                                while (!int.TryParse(Console.ReadLine(), out lol4) || lol4 > i || lol4 < 1)
                                {
                                    Console.Write(" Неверный ввод :< Введите пожалуйста число: ");
                                }
                                quizzes.quizzes[lol4 - 1].DisplayTop20();
                                break;
                            case 4:
                                if (quizzes.quizzes.Where(quiz => quiz.themeQuiz == "Математика").ToList().Count == 0)
                                {
                                    Console.WriteLine("Викторин c этой темой нету :<");
                                    break;
                                }
                                Console.WriteLine($"Викторины с Математики: ");
                                foreach (Quiz quiz in quizzes.quizzes.Where(quiz => quiz.themeQuiz == "Математика").ToList())
                                {
                                    i++;
                                    Console.WriteLine($"{i}: {quiz.name}");
                                }
                                Console.Write("Выберите викторину: ");
                                while (!int.TryParse(Console.ReadLine(), out lol4) || lol4 > i || lol4 < 1)
                                {
                                    Console.Write(" Неверный ввод :< Введите пожалуйста число: ");
                                }
                                quizzes.quizzes[lol4 - 1].DisplayTop20();
                                break;
                        }
                    }
                    else if (lol2 == 5)
                    {
                        user.Print();
                    }
                    else if (lol2 == 6)
                    {
                        Console.Write(" 1.Сменить Имя\n 2.Сменить Пароль\n 3.Сменить Возраст\n 4.Выйти\n Выберите что вы хотите изменить: ");
                        int lol4;
                        while (!int.TryParse(Console.ReadLine(), out lol4) || lol4 > 4 || lol4 < 1)
                        {
                            Console.Write(" Неверный ввод :< Введите пожалуйста число: ");
                        }
                        if (lol4 == 1)
                        {
                            Console.Write("Введите Имя: ");
                            name = Console.ReadLine();
                            while (string.IsNullOrWhiteSpace(name))
                            {
                                Console.Write("Поле Имя должно быть заполненным :< Введите пожалуйста Имя: ");
                                name = Console.ReadLine();
                            }
                            users.users.Remove(user);
                            user.ChangeName(name);
                            users.users.Add(user);
                        }
                        else if (lol4 == 2)
                        {
                            Console.Write("Введите Пароль: ");
                            login = Console.ReadLine();
                            while (string.IsNullOrWhiteSpace(login))
                            {
                                Console.Write("Поле Пароль должно быть заполненным :< Введите пожалуйста Пароль: ");
                                login = Console.ReadLine();
                            }
                            users.users.Remove(user);
                            user.ChangeLogin(login);
                            users.users.Add(user);
                        }
                        else if (lol4 == 3)
                        {
                            Console.Write("Введите Возраст: ");
                            while (!int.TryParse(Console.ReadLine(), out age))
                            {
                                Console.Write("Неверный ввод :< Введите пожалуйста число: ");
                            }
                            users.users.Remove(user);
                            user.ChangeAge(age);
                            users.users.Add(user);
                        }
                    }
                    else if (lol2 == 7)
                    {
                        user = null;
                        Console.WriteLine("Вы вышли с аккаунта");
                        break;
                    }
                }
            }
        }
    }
}
