using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__ExaminationDepartment_1._0.Users
{
    internal class ArrayUsers
    {
        public List<User> users = new List<User>();

        public User Login(string name, string login)
        {
            foreach (User user1 in users)
            {
                if (user1.name == name)
                {
                    if (user1.login == login)
                    {
                        Console.WriteLine("Вы успешно авторизовались!");
                        User user = new User(user1.name, user1.login, user1.age);
                        return user;
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("Логин или Пароль не верны.");
            return null;
        }

        public User Register(string name, string login, int age)
        {
            foreach (User user1 in users)
            {
                if (user1.name == name)
                {
                    Console.WriteLine("Такой пользователь уже существует.");
                    return null;
                }
            }
            User user = new User(name, login, age);
            users.Add(user);
            Console.WriteLine("Вы успешно зарегистрировались!");
            return user;
        }
    }
}
