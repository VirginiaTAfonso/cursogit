using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace vetorClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Produto[] vect = new Produto[n];

            for (int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Produto { Nome = nome, Preco = preco };
            }

            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma += vect[i].Preco;
            }

            double avg = soma / n;

            Console.WriteLine("Preco Medio = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
