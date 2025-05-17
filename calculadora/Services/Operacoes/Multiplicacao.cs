
namespace calculadora.Services.Operacoes
{
    public class Multiplicacao : IOperacao
    {
        public double Executar(params double[] numeros)
        {
            double resultado = 1;
            foreach (var numero in numeros)
            {
                resultado *= numero;
            }

            return resultado;
        }
    }
}