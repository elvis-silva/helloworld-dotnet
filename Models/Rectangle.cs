namespace HelloWorld.Models
{
    public class Rectangle
    {
        private double height;
        private double width;
        private bool valid;

        public void SetMeasures(double height, double width) 
        {
            if (height > 0 && width > 0) 
            {
                this.height = height;
                this.width = width;
                valid = true;
            }
            else 
            {
                System.Console.WriteLine("O valor tem que ser maior que zero!");
            }
        }

        public double GetArea() 
        {
            if (valid) 
            {
                return height * width;
            }
            else
            {
                System.Console.WriteLine("Preencha valores maior que zero!");
                return 0;
            }
        }
    }
}