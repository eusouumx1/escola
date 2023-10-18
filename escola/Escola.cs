using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace escola
{
    internal class Escola
    {
        public List<Aluno> Alunos = new List<Aluno>();
        public List<Professor> Professores = new List<Professor>();
        public List<Curso> Cursos = new List<Curso>();
        public List<Disciplina> Disciplinas = new List<Disciplina>();
        
        

        public void CadastrarAluno()
        {
            Console.Clear();
            Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a matricula");
            int matricula = int.Parse(Console.ReadLine());

            Aluno aluno = new Aluno(nome, idade, matricula);
            Alunos.Add(aluno);
            
        }

        public void CadastrarProfessor()
        {
            Console.Clear();
            Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade");
            int idade = int.Parse(Console.ReadLine());

            Professor professor = new Professor(nome, idade);
            Professores.Add(professor);
        }

        public void CadastrarDisciplina()
        {
            Console.Clear();
            Console.WriteLine("Digite o nome da disciplina");
            string titulo = Console.ReadLine();
            Console.WriteLine("Digite a carga horaria da disciplina");
            double cargaHoraria = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Ementas");
            string ementas = Console.ReadLine();

            Disciplina disciplina = new Disciplina(titulo, cargaHoraria, ementas);
        }

        public int BuscaAluno()
        {
            Console.WriteLine("Digite o nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a matricula");
            int matricula = int.Parse(Console.ReadLine());

            int indiceAluno = Alunos.FindIndex(e => e.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase)
             && e.Matricula.Equals(matricula));

            return indiceAluno;
        }

        public int BuscaProfessor()
        {
            

            Console.WriteLine("Digite o nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a idade");
            int idade = int.Parse(Console.ReadLine());
            
              int indiceProfessor = Professores.FindIndex(e => e.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase) && e.Idade.Equals(idade));
            
            return indiceProfessor;
        }

        public int BuscaCurso()
        {
            Console.WriteLine("Digite o nome do curso");
            string nomeCurso = Console.ReadLine();

            int indiceCurso = Cursos.FindIndex(e => e.NomeCurso.Equals(nomeCurso, StringComparison.OrdinalIgnoreCase));

            return indiceCurso;
        }

        public int BuscaDisciplina()
        {
            
            Console.WriteLine("Digite o nome da disciplina");
            string titulo = Console.ReadLine();

            int indiceDisciplina = Disciplinas.FindIndex(e => e.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));

            return indiceDisciplina;
        }

        public void CadastroCursoAluno()
     {
     Console.Clear();
     Alunos[BuscaAluno()].CursosCadastrados.Add(Cursos[BuscaCurso()]);
     Console.WriteLine("Aluno cadastrado no curso com Sucesso");
    
     }
        public void CadastroDisciplinaProf()
{
    Console.Clear();

    Professores[BuscaProfessor()].Disciplinas.Add(Disciplinas[BuscaDisciplina()]);
    Console.WriteLine("Disciplina Cadastrada ao professor com sucesso");
    
}
        public void PrintAluno()
        {
            Console.Clear();
            foreach (var aluno in Alunos)
            {
                Console.Clear();
                Console.WriteLine(aluno.Nome);
                Console.WriteLine(aluno.Idade);
                Console.WriteLine(aluno.Matricula);
            }
        }
        public void PrintCursos()
        {
            Console.Clear();
            Console.WriteLine("Cursos disponíveis:");
            foreach (var curso in Cursos)
            {
                Console.WriteLine(curso.NomeCurso);
                Console.WriteLine("Este curso contem as seguintes disciplinas:");
                foreach (var disciplina in curso.Disciplinas)
                {
                    Console.WriteLine(disciplina.Titulo);
                }
            }
        }
        public void PrintProfessor()
        {
            Console.Clear();
            foreach (var professor in Professores)
            {
                Console.WriteLine("Nome:"+professor.Nome);
                Console.WriteLine("Idade:"+professor.Idade);
                
                foreach (var disciplinas in professor.Disciplinas)
                {
                    
                    Console.WriteLine($"{disciplinas.Titulo} {disciplinas.CargaHoraria} {disciplinas.Ementa}");
                }
            }
        }

    }
}
