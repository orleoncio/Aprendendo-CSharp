using System;
using System.ComponentModel.DataAnnotations;

namespace TiposDeValor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tipo de Valores em Variaveis
            //C# - .NET
            //sbyte - SByte / composto por numeros inteiros - é formado por 1 byte - o seu valor vai de -128 a 127
            sbyte s1 = 127;
            SByte s2 = -128;

            //short - Int16 / composto por numeros inteiros - é formado por 2 bytes - o seu valor vai de -32768 a 32767
            short sh1 = 32767;
            Int16 sh2 = -32768;

            //int - Int32 / composto por numeros inteiros - é formado por 4 bytes - o seu valor vai de -2^31 a 2^31 - 1
            int i1 = 2147483647;
            Int32 i2 = -2147483648;

            //long - Int64 / composto por numeros inteiros - é formado por 8 bytes - o seu valor vai de -2^63 a 2^63 - 1 / (sempre finalizar o numero long com L)
            long l1 = 9223372036854775807L;
            Int64 l2 = -9223372036854775808L;

            //byte - Byte / composto por numeros naturais - é formado por 1 byte - o seu valor vai de 0 a 255
            byte b1 = 255;
            Byte b2 = 0;

            //ushort - Uint16 / composto por numeros naturais - é formado por 2 bytes - o seu valor vai de 0 a 65535
            ushort u1 = 65535;
            UInt16 u2 = 0;

            //uint - Uint32 / composto por numeros naturais - é formado por 4 bytes - o seu valor vai de 0 a 2^32 - 1
            uint ui1 = 4294967295;
            UInt32 ui2 = 0;

            //ulong - Uint64 / composto por numeros naturais - é formado por 8 bytes - o seu valor vai de 0 a 2^64 - 1
            ulong ul1 = 18446744073709551615;
            UInt64 ul2 = 0;

            //float - Single / composto por numeros racionais - é formado por 4 bytes - o seu valor vai de +/- 1.5 * 10^-45 a +/- 3.4 * 10^38 com 7 algarismos significativos 
            //Sempre finalizar o numero float com f
            float f1 = 340000000000000000000000000000000000000f; 
            float f2 = -340000000000000000000000000000000000000f;
            Single f3 = 0.000000000000000000000000000000000000000000000015f;
            Single f4 = -0.000000000000000000000000000000000000000000000015f;

            //double - Double / composto por numeros racionais - é formado por 8 bytes - o seu valor vai de +/- 5.0 * 10^-324 a +/- 1.7 * 10^308 com 15 ou 16 algarismos significativos
            //Sempre finalizar o numero double com D
            //por questoes de espaço o valor double sera limitado a 39 digitos e o valor Double sera limitado a 45 casas
            double d1 = 170000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000D;
            double d2 = -170000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000D;
            Double d3 = 0.000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000005D;
            Double d4 = -0.000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000005D;

            //decimal - Decimal / composto por numeros racionais - é formado por 12 bytes - o seu valor vai de +/- 1.0 * 10^-28 a +/- 7.9 * 10^28 com 28 ou 29 algarismos significativos
            //Sempre finalizar o numero decimal com m
            decimal de1 = 79000000000000000000000000000m;
            decimal de2 = -79000000000000000000000000000m;
            Decimal de3 = 0.0000000000000000000000000001m;
            Decimal de4 = -0.0000000000000000000000000001m;

            //char - Char / é formado por 2 bytes - recebe um caractere ou código do caractere
            char c1 = '\u006A';
            Char c2 = 'j';

            //bool - Boolean / é formado por 1/2 bytes - recebe um valor verdadeiro ou falso
            bool bo1 = true;
            Boolean bo2 = false;

            //string - String / recebe uma cadeia de caracteres unicode - é imutavel
            string st1 = "João";
            String st2 = "Maria";

            //object - Object / é um objeto generico ou seja pode receber qualquer valor dentro de sua variavel
            object obj1 = "Nome";
            object obj2 = 100;
            Object obj3 = 10.52f;
            Object obj4 = true;


            //É possivel saber qual os valores maximos e minimos de cada um dos tipos de variaveis usando .MinValue e .MaxValue
            Console.WriteLine(sbyte.MinValue);
            Console.WriteLine(sbyte.MaxValue);
            Console.WriteLine(short.MinValue);
            Console.WriteLine(short.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(ushort.MinValue);
            Console.WriteLine(ushort.MaxValue);
            Console.WriteLine(uint.MinValue);
            Console.WriteLine(uint.MaxValue);
            Console.WriteLine(ulong.MinValue);
            Console.WriteLine(ulong.MaxValue);
            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);


            // Caso o valor exceda o limite de sua variavel ele reseta a partir do seu menor numero ou vice-versa
            sbyte sb1 = 127;
            sb1 += 100;

            sbyte sb2 = -128;
            sb2 -= 100;

            Console.WriteLine(sb1);
            Console.WriteLine(sb2);  
        }
    }
}
