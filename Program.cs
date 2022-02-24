using HelloWorld.Helper;
using HelloWorld.Models;

namespace HelloWorld
{
    class Program {
        static void Main(string[] args) {
            var path = "/home/elvis/DotNet/HelloWorld/ExampleDir";
            var fileExample = "ExampleFile.txt";
            FileHelper helper = new FileHelper();
            helper.ReadStreamFileTxt(Path.Combine(path, fileExample));
            var sourceFile = Path.Combine(path, fileExample);
            var destFile = Path.Combine(path, "NovoStreamFileTxt2.txt");

            helper.MoveFile(sourceFile, destFile);
            // helper.AppendStreamFileTxt(Path.Combine(path, "StreamExFile.txt"), 
            //     new List<string> {
            //         "texto da linha 5", "texto da linha 6", "texto da linha 7", "texto da linha 8" 
            //     }
            // );
            // helper.CreateStreamFileTxt(Path.Combine(path, "StreamExFile.txt"), 
            //     new List<string> {
            //         "texto da linha 1", "texto da linha 2", "texto da linha 3", "texto da linha 4" 
            //     }
            // );
            // helper.CreateFileTxt(Path.Combine(path, "ExampleFile.txt"), "Text de exemplo!!!");
            // helper.DeleteDirectory(Path.Combine(path, "ExampleDir"));
            // helper.CreateDirectory(Path.Combine(path, "ExampleDir"));
            // helper.ListFiles(path);
            // helper.ListDirectories(path);

            // Calculator calc = new Calculator();
            // System.Console.WriteLine($"O resultado da sua multiplicação é {calc.Multiply(5, 5)}");

            // Computer computer = new Computer();
            // System.Console.WriteLine(computer.ToString());

            // Corrente corrente = new Corrente();
            // corrente.Creditar(1234.56);
            // corrente.ExibirSaldo();

            // Calculator calc = new Calculator();
            // System.Console.WriteLine($"Resultado da primeira soma é: {calc.Sum(10, 10)}");
            // System.Console.WriteLine($"Resultado da segunda soma é: {calc.Sum(10, 10, 10)}");

            // Teacher teacher = new Teacher();
            // teacher.Name = "Rob";
            // teacher.Age = 45;
            // teacher.Salary = 2000.99;
            // teacher.IntroduceYourself();

            // Student student = new Student();
            // student.Name = "Bob";
            // student.Age = 15;
            // student.Grade = 10;
            // student.IntroduceYourself();


            // Rectangle r = new Rectangle();
            // r.SetMeasures(30, 30);
            // System.Console.WriteLine($"Área: {r.GetArea()}");

            // Person p1 = new Person();
            // p1.Name = "Elvis";
            // p1.Age = 43;
            // p1.IntroduceYourself();
        }
    }
}