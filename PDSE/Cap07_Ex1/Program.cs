using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap07_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            CadAluno ALUNO = new CadAluno(); //Instanciar, criar uma variável do tipo CadAluno.
            Console.WriteLine("Entre com o nome...:");
            ALUNO.NOME = Console.ReadLine();

            Console.WriteLine("Entre com as notas");
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine("{0}a. nota.....:", i + 1);
                ALUNO.nota[i] = float.Parse(Console.ReadLine());
            }
            ALUNO.CalcMedia();
            Console.WriteLine();
            Console.WriteLine("Nome............: {0}",ALUNO.NOME);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Nota: ");
            Console.WriteLine();
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine("{0}a. nota....:", i + 1);
                Console.WriteLine("{0,5:0.00} ", ALUNO.nota[i]);              
            }
            Console.WriteLine();
            Console.WriteLine("Media.......: {0,5:0.00}", ALUNO.CalcMedia());
            Console.WriteLine();
            Console.WriteLine("Pressione uma tecla para encerrar");
            Console.ReadKey();
        }
    }
}
