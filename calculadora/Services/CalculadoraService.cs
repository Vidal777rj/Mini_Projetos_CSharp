

namespace calculadora.Services
{
    public class CalculadoraService
    {
        public double Calcular(IOperacao operacao, params double[] numeros)
        {
            return operacao.Executar(numeros);
        }
    }
}