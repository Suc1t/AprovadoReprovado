using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprovadoReprovado
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float nota, frequencia;
            Console.Write("Informe a nota final do aluno: ");
            nota = float.Parse(Console.ReadLine());
            Console.Write("Informe a frequencia final do aluno: ");
            frequencia = float.Parse(Console.ReadLine());

            if ((nota >= 5) && (frequencia >= 75))
            {
                Console.WriteLine("Aprovado!");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
            Console.ReadKey();

        }
    }
}
