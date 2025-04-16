using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__ExaminationDepartment_1._0.Users
{
    internal class User
    {
        public string name { get; set; }
        public string login { get; set; }
        public int age { get; set; }

        public User(string name, string login, int age)
        {
            this.name = name;
            this.login = login;
            this.age = age;
        }

        public void Print()
        {
            Console.WriteLine($"\n Аккаунт\n Имя: {name}\n Пароль: {login}\n Возраст: {age}");
        }
    }

}
