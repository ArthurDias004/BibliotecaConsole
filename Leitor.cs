using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaConsole
{
    public class Leitor
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public List<Livro> LivrosEmprestados { get; set; } = new List<Livro>();

        public Leitor(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
    }
}
