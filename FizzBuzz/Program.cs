/*
Escreva um programa que exiba números de 1 a 100, 
se o número for multiplo de 3 exiba Fizz
se o número for multiplo de 5 exiba Buzz
se o número for multiplo de 3 e de 5 exiba FizzBuzz
*/

for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        System.Console.WriteLine($"{i} - FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        System.Console.WriteLine($"{i} - Fizz");
    }
    else if (i % 5 == 0)
    {
        System.Console.WriteLine($"{i} - Buzz");
    }
    else
    {
        System.Console.WriteLine($"Não é multiplo de 3 ou 5");
    }
}


//Criando um método para ver um número especifico 
System.Console.WriteLine(FizzBuzz(55));
static string FizzBuzz(int numero)
{
    if (numero % 3 == 0 && numero % 5 == 0) return $"{numero} | FizzBuzz";
    if (numero % 3 == 0) return $"{numero} | Fizz";
    if (numero % 5 == 0) return $"{numero} | Buzz";

    return $"{numero} | Não é multiplo de 3 ou 5";
}