

namespace calculadora.Services.Operacoes
{
    public class Subtracao : IOperacao
    {
        public double Executar(params double[] numeros)
        {
            if (numeros.Length < 2)
            {
                throw new ArgumentException("Subtração requer pelo menos 2 números");
            }

            double resultado = numeros[0];
            for (int i = 1; i < numeros.Length; i++)
            {
                resultado -= numeros[i];
            }
            return resultado;
        }
    }
}