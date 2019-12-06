using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());


            int[,] mat= new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] valor = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(valor[j]);
                }
            }

            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == num)
                    {
                        Console.WriteLine("Posição:" + i + "," +j + ":");

                        if(j > 0)
                        {
                            Console.WriteLine("Direita: " + mat[i, j-1]);
                        }
                        if(i > 0)
                        {
                            Console.WriteLine("Esquerda: " + mat[i - 1,j]);
                        }
                        if (j < n - 1)
                        {

                            Console.WriteLine("Right: " + mat[i, j + 1]);

                        }

                        if (i < m - 1)
                        {

                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                }
            }
        }
    }
}
