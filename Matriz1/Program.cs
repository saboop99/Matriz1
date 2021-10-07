using System;
using System.Globalization;

namespace Matriz1
{
    class Program
    {
        //RAFAEL DO NASCIMENTO RODRIGUES RA 210211
        static void Main(string[] args)
        {
            //Pedido ao usuário para digitar a ordem da matriz
            Console.WriteLine("digite a ordem da matriz");
            //leitura e conversão de string para int
            int n = int.Parse(Console.ReadLine());
            //matriz que le números inteiros inputados pelo usuario
            int[,] mat = new int[n, n];
            
            //Pedido ao usuário para digitar os valores da matriz
            Console.WriteLine("digite os valores, todos separados por espaço e do tamanho da ordem colocada");
            
            //condicional para a linha da matriz. (começa no 0, é menor que o número inputado para n, vai acrescentando na variavel i)
            for (int i = 0; i < n; i++)
            {
                //armazanamento dos valores da matriz na variavel value, sendo o split para espaçar os valores inputados
                string[] values = Console.ReadLine().Split(' ');

                //condicional para a coluna da matriz (começa no 0, é menor que o número inputado para n, vai acrescentando na variavel j)
                for (int j = 0; j < n; j++)
                {
                    //armazanamento dos valores na matriz ( conversão de string para int da variavel value)
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            // mostra os valores que estão em diagonal na matriz 
            Console.WriteLine("Main diagonal:");

            //condicional para a linha da matriz. (começa no 0, é menor que o número inputado para n, vai acrescentando na variavel i)
            for (int i = 0; i < n; i++)
            {
                //mostrar os valores da diagonal principal ( i,i usado para repetir a variavel i, assim contando linhas e colunas identicas)
                Console.Write(mat[i, i] + " ");
            }
            //pular uma linha
            Console.WriteLine();

            // variavel para soma
            int count = 0;

            //condicional para a linha da matriz. (começa no 0, é menor que o número inputado para n, vai acrescentando na variavel i)
            for (int i = 0; i < n; i++)
            {
                //condicional para a coluna da matriz (começa no 0, é menor que o número inputado para n, vai acrescentando na variavel j)
                for (int j = 0; j < n; j++)
                {
                    //condicional para achar os valores negativos na matriz
                    if (mat[i, j] < 0)
                    {
                        //somar a quantidade de valores negativos encontrados
                        count++;
                    }
                }
            }
            //mostra a quantidade de valores negativos da matriz
            Console.WriteLine("Negative numbers: " + count);
        }
    }
}
