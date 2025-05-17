

namespace calculadora.Services
{
    public interface IOperacao
    {
        public double Executar(params double[] numeros);
    }
}