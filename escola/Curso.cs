using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace escola
{
    internal class Curso
    {
        public List<Aluno> AlunosCadastrados = new List<Aluno>();
        public string NomeCurso { get; set; }
        public List<Disciplina> Disciplinas { get; set; } = new List<Disciplina>();

        public Curso(string curso)
        {
            this.NomeCurso = curso; 
        }
        
    }
}
