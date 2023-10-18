using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace escola
{
    internal class Professor
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public List<Disciplina> Disciplinas { get; set;} = new List<Disciplina>();
       
        public Professor(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
            
        }
       
    }
}
