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
            User? user = null;
            User lizar = new User("Lizar", "Klaun", 25);
            users.users.Add(lizar);
            string? name;
            string? login;
            int age;

            while (true)
            {
                do
                {
                    Console.Write($"\n 1.Залогинится\n 2.Зарегистрироваться\n 3.Выйти\n Выберите как вы хотите войти: ");
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
                } while (user == null);
                user.Print();
                while (true)
                {
                    Console.WriteLine();
                    Console.Write($" 1.Начать новую викторину\n 2.Создать новую викторину\n 3.Просмотреть результаты викторин\n 4.Просмотреть Топ-20 с конкретной викторины\n 5.Просмотреть статус аккаунта\n 6.Сменить Имя Пароль или Возраст\n 7.Выйти с аккаунта\n Выберите что вы хотите делать:");
                    int lol2;
                    while (!int.TryParse(Console.ReadLine(), out lol2) || lol2 > 7 || lol2 < 1)
                    {
                        Console.Write(" Неверный ввод :< Введите пожалуйста число: ");
                    }
                    Console.WriteLine();
                    if (lol2 == 1)
                    {
                        //Console.WriteLine("1. История \n2. География \n3. Биология\n 4. Математика\n 5. Универсальная\n");
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
                        Console.Write("1. История \n2. География \n3. Биология\n 4. Математика\n");
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

                        List<Question> questions = new List<Question>();
                        for (int i = 0; i < 2; i++)
                        {
                            Console.WriteLine($"Введите {i + 1} вопрос: ");
                            string? question = Console.ReadLine();
                            while (string.IsNullOrWhiteSpace(question))
                            {
                                Console.Write("Вопрос должен быть заполненным :< Введите пожалуйста Вопрос: ");
                                question = Console.ReadLine();
                            }

                            Console.Write($"Введите количество ответов на этот вопрос: ");
                            int countOfAnsfers = 0;
                            while (countOfAnsfers < 1)
                            {
                                while (!int.TryParse(Console.ReadLine(), out countOfAnsfers))
                                {
                                    Console.Write("Неверный ввод :< Введите пожалуйста число: ");
                                }
                                if (countOfAnsfers < 1)
                                {
                                    Console.WriteLine("Количество ответов не может быть меньше 1");
                                    Console.Write($"Введите количество ответов на этот вопрос: ");
                                }
                            }

                            Console.Write($"Введите количество правильных ответов на вопросс: ");
                            int countOfRightAnsfers = 0;
                            while (countOfRightAnsfers >= countOfAnsfers)
                            {
                                while (!int.TryParse(Console.ReadLine(), out countOfRightAnsfers))
                                {
                                    Console.Write("Неверный ввод :< Введите пожалуйста число: ");
                                }
                                if (countOfRightAnsfers >= countOfAnsfers)
                                {
                                    Console.WriteLine("Количество правильных ответов не может быть больше самих ответов");
                                    Console.Write($"Введите количество правильных ответов на вопросс: ");
                                }
                            }

                            List<string> ansfers = new List<string>();
                            List<string> incorrectAnswers = new List<string>();
                            for (int j = 0; j < countOfRightAnsfers; j++)
                            {
                                Console.WriteLine($"Введите правильный ответ на вопрос {j + 1} : ");
                                string? ansfer = Console.ReadLine();
                                while (string.IsNullOrWhiteSpace(ansfer))
                                {
                                    Console.Write("Правильный ответ должен быть заполненным :< Введите пожалуйста Правильный ответ на вопрос: ");
                                    ansfer = Console.ReadLine();
                                }
                                ansfers.Add(ansfer);
                            }
                            for (int j = 0; j < countOfAnsfers - countOfRightAnsfers; j++)
                            {
                                Console.WriteLine($"Введите не правильный ответ на вопрос {j + 1} : ");
                                string? incorrectAnswer = Console.ReadLine();
                                while (string.IsNullOrWhiteSpace(incorrectAnswer))
                                {
                                    Console.Write("Поле Пароль должно быть заполненным :< Введите пожалуйста Пароль: ");
                                    incorrectAnswer = Console.ReadLine();
                                }
                                incorrectAnswers.Add(incorrectAnswer);
                            }
                            Question question1 = new Question(question, ansfers, incorrectAnswers);
                            questions.Add(question1);
                        }
                        Quiz quiz = new Quiz(name, theme, user.name, questions);
                    }
                    else if (lol2 == 3)
                    {
                        //Console.WriteLine("Результат созданой вами викторины");
                    }
                    else if (lol2 == 4)
                    {
                        //Console.WriteLine("Топ-20 с конкретной викторины");
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
                            user.ChangeName(name);
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
                            user.ChangeLogin(login);
                        }
                        else if (lol4 == 3)
                        {
                            Console.Write("Введите Возраст: ");
                            while (!int.TryParse(Console.ReadLine(), out age))
                            {
                                Console.Write("Неверный ввод :< Введите пожалуйста число: ");
                            }
                            user.ChangeAge(age);
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
