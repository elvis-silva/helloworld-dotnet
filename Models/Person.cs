using System;

namespace HelloWorld.Models
{
    public class Person
    {
        public string ?Name { get; set; }

        public int Age { get; set; }

        public virtual void IntroduceYourself()
        {
            Console.WriteLine($"Olá, eu sou {Name} e tenho {Age} anos!");
        }
    }
}