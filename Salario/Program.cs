using System;
using System.Collections.Generic;
using System.Globalization;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Quantos Funcionarios serão registrados: ");
            int quantidade = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();

            for (int i = 1; i <= quantidade; i++)
            {
                Console.WriteLine($"Funcionario #{i} : ");
                Console.Write("Id: ");
                int ide= int.Parse(Console.ReadLine());
                Console.Write("Nome:");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Funcionario(ide, nome, salario));
                Console.WriteLine();

            }

            Console.WriteLine("ID de aumento: ");
            int id = int.Parse(Console.ReadLine());

            Funcionario func = list.Find(x => x.Id == id);
            if (func != null)
            {
                Console.WriteLine("Qual a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                func.Aumento(porcentagem);
            }
            else
                Console.WriteLine("Funcionario não existe!");

            Console.WriteLine();
            Console.WriteLine("lista atualizada");
            foreach (Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }




        }
    }
}
