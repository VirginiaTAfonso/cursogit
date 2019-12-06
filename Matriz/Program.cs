using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int [,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] valor = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(valor[j]);
                }
            }

            Console.WriteLine("Diagonal principal");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(mat[i,i] + " ");
            }
           

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(mat[i,j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Numeros negativos: " + count);

        }
    }
}
