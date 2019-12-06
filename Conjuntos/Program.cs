using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();

            Console.Write("O curso A possui quantos alunos? ");
            int quantidadeA = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso A: ");

            for (int i = 0; i < quantidadeA; i++)
            {
                int x = int.Parse(Console.ReadLine());
                A.Add(x);
            }

            Console.Write("O curso B possui quantos alunos? ");
            int quantidadeB = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidadeB; i++)
            {
                int x = int.Parse(Console.ReadLine());
                A.Add(x);
            }

            Console.Write("O curso C possui quantos alunos? ");
            int quantidadeC = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidadeC; i++)
            {
                int x = int.Parse(Console.ReadLine());
                A.Add(x);
            }

            HashSet<int> Novo = new HashSet<int>();
            Novo.UnionWith(A);
            Novo.UnionWith(A);
            Novo.UnionWith(A);

            Console.WriteLine("Total de alunos: " + Novo.Count);
            Console.ReadLine();

            //A.Except(B);
            ////A.UnionWith
            ////A.IntersectWith



            //foreach (int x in A)
            //{
            //    Console.WriteLine(x);
            //}
            //Console.WriteLine("Digita um valor inteiro");
            //int N = int.Parse(Console.ReadLine());

            //if (B.Contains(N))
            //{
            //    Console.WriteLine(N+ "Pertence");
            //}
            //else
            //    Console.WriteLine(N+ "Não Pertence");

        }
    }
}
