
namespace calculadora.Services
{
    public class Adicao : IOperacao
    {
        public double Executar(params double[] numeros)
        {
            double resultado = 0;
            foreach (var numero in numeros)
            {
                resultado += numero;
            }
            return resultado;
        }
    }
}