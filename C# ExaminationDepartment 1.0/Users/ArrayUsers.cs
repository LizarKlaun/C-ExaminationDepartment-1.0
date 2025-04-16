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
                        Console.WriteLine("Логин или Пароль не верны.");
                        return null;
                    }
                }
                else
                {
                    Console.WriteLine("Логин или Пароль не верны.");
                    return null;
                }
            }
            return null;
        }

        public User Register(string name, string login, int age)
        {
            User user = new User(name, login, age);
            users.Add(user);
            return user;
        }
    }
}
