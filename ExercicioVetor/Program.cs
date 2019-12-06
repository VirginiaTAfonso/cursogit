using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluguel[] vect = new Aluguel[10];

            Console.Write("Quantos quartos alugados? ");
            int q = int.Parse(Console.ReadLine());


            for (int i = 0; i < q; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i+1}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Numero do Quarto: ");
                int numeroQuarto = int.Parse(Console.ReadLine());

                vect[numeroQuarto] = new Aluguel(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos Ocupados: ");

            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }
}
