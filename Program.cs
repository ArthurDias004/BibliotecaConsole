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

            var leitor1 = new Leitor("Arthur", "Dias");
            var leitor2 = new Leitor("Cleber", "Dias");

            biblioteca.Livros.Add(livro1);
            biblioteca.Livros.Add(livro2);

            biblioteca.Leitores.Add(leitor1);
            biblioteca.Leitores.Add(leitor2);

            biblioteca.EmprestarLivro("Redes de Computadores", leitor1);
            biblioteca.EmprestarLivro("POO2 na prática", leitor2);

            biblioteca.ListarEmprestados();

            biblioteca.DevolverLivro("Redes de Computadores", leitor1);

            biblioteca.ListarDisponiveis();



        }
    }
}
