using System;
using System.Globalization;

namespace SaidaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            //Diferença entre Write.Line e Write
            //O Console.WriteLine faz com que o output seja direto na linha abaixo diferente do Console.Write
            Console.Write("Bom Dia!");
            Console.Write("Boa Noite!");
            Console.WriteLine("Bom Dia!");
            Console.WriteLine("Boa Noite!");
            
            //Tipos de Concatenação
            int idade = 30;
            float saldo = 10.76538f;
            string nome = "Maria";

            //Placeholders
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2} reais", nome, idade, saldo);
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);

            //Interpolação
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");

            //Concatenação
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo + " reais");
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2") + " reais");
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");
        }
    }
}
