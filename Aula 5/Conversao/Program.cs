using System;

namespace Conversao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conversão implicita
            //O valor de uma variavel A pode ser armazenado em uma variavel B caso o tipo da variavel A tenha menos bytes que o tipo da variavel B
            float a = 10.0f;
            double b = a;
            
            //Float comporta informações de ate 4 bytes enquanto double suporta informações de até 8 bytes

            
            //Caso tente armazenar uma variavel A dentro de B sendo que o tipo da variavel A contem mais bytes que o tipo da variavel B ou tente armazenar uma variavel dentro de outra variavel de outro tipo sera necessario usar o casting
            double c = 25.52;
            float d = (float) b;
            int e = (int) b;
            
            //Existe a posibilidade de ocorrer uma perga de dados ao ultilizar o casting
        }
    }
}
