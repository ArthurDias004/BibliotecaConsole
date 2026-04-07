using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaConsole
{
    public class Biblioteca
    {
        public List<Livro> Livros { get; set; } = new List<Livro>();
        public List<Leitor> Leitores { get; set; } = new List<Leitor>();

        public void EmprestarLivro(string titulo, Leitor leitor)
        {
            var livro = Livros.FirstOrDefault(l => l.Titulo == titulo);

            if (livro == null)
            {
                Console.WriteLine("Livro não encontrado.");
                return;
            }

            if (!livro.Disponivel)
            {
                Console.WriteLine("Livro já está emprestado.");
                return;
            }

            livro.Disponivel = false;
            leitor.LivrosEmprestados.Add(livro);

            Console.WriteLine($"Livro '{livro.Titulo}' emprestado para {leitor.Nome}.");
        }

        public void DevolverLivro(string titulo, Leitor leitor)
        {
            var livro = leitor.LivrosEmprestados.FirstOrDefault(l => l.Titulo == titulo);

            if (livro == null)
            {
                Console.WriteLine("Esse leitor não possui esse livro.");
                return;
            }

            livro.Disponivel = true;
            leitor.LivrosEmprestados.Remove(livro);

            Console.WriteLine($"Livro '{livro.Titulo}' devolvido.");
        }

        public void ListarDisponiveis()
        {
            Console.WriteLine("\nLivros disponíveis:");

            foreach (var livro in Livros.Where(l => l.Disponivel))
            {
                Console.WriteLine($"{livro.Titulo} - {livro.Autor}");
            }
        }

        public void ListarEmprestados()
        {
            Console.WriteLine("\nLivros emprestados:");

            foreach (var leitor in Leitores)
            {
                foreach (var livro in leitor.LivrosEmprestados)
                {
                    Console.WriteLine($"{livro.Titulo} → {leitor.Nome} {leitor.Sobrenome}");
                }
            }
        }
    }
}
