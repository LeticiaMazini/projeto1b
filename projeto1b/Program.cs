using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1b
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            pessoa aluno;
            aluno = new pessoa();
            pessoa professor = new pessoa();
            aluno.nome = "petala";
            professor.nome = "prof. sonia";
            Console.WriteLine("aluno:" + aluno.nome);
            Console.WriteLine("professor:" + professor.nome);
            Console.ReadKey();

        }
    }
}
