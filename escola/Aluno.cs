using space;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace escola
{
    internal class Aluno
    {
        public List<Curso> CursosCadastrados = new List<Curso>();

        public string Nome { get; set; }
        public int Idade { get; set; }
        public int Matricula { get; set; }

        public Aluno(string nome, int idade, int matricula)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Matricula = matricula;
        }
       
       
    }
}
