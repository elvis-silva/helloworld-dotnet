namespace HelloWorld.Models
{
    public class Student : Person
    {
        public int Grade {get; set;}

        public override void IntroduceYourself()
        {
            Console.WriteLine($"Olá, eu sou {Name}, tenho {Age} anos e sou aluno nota {Grade}!");
        }
    }
}