using System;

namespace OperacoesAritimeticas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Os principais operadores aritimeticos do C# são: +, /, *, /, %
            int o1 = 5 + 5;
            Console.WriteLine(o1);

            int o2 = 5 - 2;
            Console.WriteLine(o2);
            
            int o3 = 5 * 8;
            Console.WriteLine(o3);

            //Caso o resultado de uma divisão seja um numero racional, os valores que o compoem não podem ser numeros inteiros, caso sejam o resultado tera um valor inteiro mesmo sendo uma variavel flutuante
            float o4 = 10 / 8;
            Console.WriteLine(o4);

            float o5 = (float) 10 / 8; //Ou float o5 = 10.0 / 8.0;
            Console.WriteLine(o5);

            //A operação % pega apenas o resto da divisão feita entre dois numeros
            int o6 = 10 % 3;
            Console.WriteLine(o6);


            //No C# tambem existe uma ordem de prioridade na qual as expeções aritimeticas são calculadas, as primeiras a serem calculadas são : *, /, % e so após seram realizadas as operações de : +, -
            //Operações com o mesmo nivel de prioridade são executadas da esquerda para a direita
            float o7 = 10 % 2 + 1 * 3 + 4 - 2 / 2;
            Console.WriteLine(o7);

            //Para dar prioridade a uma ou mais operações da expresão basta usar parenteses
            float o8 = 10 % (2 + 1) * 3 + (4 - 2 / 2);
            Console.WriteLine(o8);
            
            //Outras operações matematicas que podem ser uteis são : Potenciação e Raiz Quadrada
            //Para realizar um potenciação : Math.Pow(base, potencia); Apenas variaveis double aceitam esta expreção
            double o9 = 5 + Math.Pow(2, 2);
            Console.WriteLine(o9);

            //Para realizar uma raiz quadrada : Math.sqrt(radical); Apenas variaveis double aceitam esta expreção
            double o10 = 5 + Math.Sqrt(9);
            Console.WriteLine(o10);
        }
    }
}
