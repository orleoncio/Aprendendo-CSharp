using System;

namespace OperacaoDeAtribuicao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operadores de Atribuição

            // x = 10 significa que x recebe o valor de 10
            int x = 10;
            Console.WriteLine(x);
            
            // x += 2 significa que x vai receber o seu valor atual +2 ou seja 10 + 2 = 12
            x += 2;
            Console.WriteLine(x);

            // x -= 2 significa que x vai receber o seu valor atual -2 ou seja 12 - 2 = 10
            x -= 2;
            Console.WriteLine(x);

            // x *= 3 significa que x vai receber o seu valor atual *3 ou seja 10 * 3 = 30
            x*=3;
            Console.WriteLine(x);

            // x /= 3 significa que x vai receber o seu valor atual /3 ou seja 30 / 3 = 10
            x /= 3;
            Console.WriteLine(x);

            // x %= 3 significa que x vai receber o resto da divisão do seu valor atual dividido por 3 ou seja 10 / 3 = 3 com resto 1 - x = 1
            x %= 3;
            Console.WriteLine(x);
            
            // x++ significa que x vai receber o seu valor atual +1 ou seja 1 + 1 = 2
            x++;
            Console.WriteLine(x);

            // x-- significa que x vai receber o seu valor atual -1 ou seja 2 - 1 = 1 
            x--;
            Console.WriteLine(x);
        }
    }
}
