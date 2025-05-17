

namespace calculadora.Services.Operacoes
{
    public class Divisao : IOperacao
    {
        public double Executar(params double[] numeros)
        {
            if (numeros.Length != 2)
            {
                throw new ArgumentException("Divisão requer exatamente 2 números");
            }
            if (numeros[1] == 0)
            {
                throw new DivideByZeroException("Não é possivel divisão por zero");
            }
            return numeros[0] / numeros[1];
        }
    }
}