using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            var biblioteca = new Biblioteca();

            var livro1 = new Livro("Redes de Computadores", "Autor A");
            var livro2 = new Livro("POO2 na prática", "Autor B");
            var livro3 = new Livro("Manual dos DevOps", "Autor C");
            var livro4 = new Livro("Infraestrutura de TI", "Autor D");

            var leitor1 = new Leitor("Arthur", "Dias");
            var leitor2 = new Leitor("Cleber", "Dias");
            var leitor3 = new Leitor("Maria", "Silva");

            biblioteca.Livros.Add(livro1);
            biblioteca.Livros.Add(livro2);
            biblioteca.Livros.Add(livro3);
            biblioteca.Livros.Add(livro4);

            biblioteca.Leitores.Add(leitor1);
            biblioteca.Leitores.Add(leitor2);
            biblioteca.Leitores.Add(leitor3);

            biblioteca.EmprestarLivro("Redes de Computadores", leitor1);
            biblioteca.EmprestarLivro("POO2 na prática", leitor2);
            biblioteca.EmprestarLivro("Manual dos DevOps", leitor3);

            biblioteca.ListarEmprestados();

            biblioteca.DevolverLivro("Redes de Computadores", leitor1);

            biblioteca.ListarDisponiveis();



        }
    }
}
