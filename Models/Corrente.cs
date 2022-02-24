namespace HelloWorld.Models
{
    public class Corrente : Conta
    {
        public override void Creditar(double value)
        {
            base.saldo = value;
        }
    }
}