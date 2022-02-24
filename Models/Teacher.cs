namespace HelloWorld.Models
{
    public class Teacher : Person
    {
        public double Salary {get; set;}

        public sealed override void IntroduceYourself()
        {
            Console.WriteLine($"Olá, eu sou {Name} e tenho {Age} anos, sou professor e meu salário é {Salary}!");
        }
    }
}