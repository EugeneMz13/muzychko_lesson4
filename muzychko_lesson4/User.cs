using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace muzychko_lesson4
{
    //Створення enum
    public enum Gender
    {
        Male,
        Female
    }

    public class User
    {
        //Поля та властивості
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public readonly int Age;
        public Gender Gender { get; set; }

        private static Random _random = new Random();

        //Конструктор без параметрів
        public User()
        {
            Age = _random.Next(1, 20);
        }

        //Конструктор з параметром age
        public User(int age)
        {
            Age = age;
        }

        //Override методу ToString();
        public override string ToString()
        {
            string agedescription = Age < 10 ? "I'am a baby." : $"I am {Age} years old.";
            return $"Hi, my name is {FirstName} and last name {LastName}. {agedescription} I am {Gender}.";
        }
    }
}
