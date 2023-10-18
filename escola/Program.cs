using escola;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace space
{
    public class Program
    {


        public static void Main()
        {
            bool rodando = true;
           Escola escola = new Escola();

            Aluno aluno1 = new Aluno("Pedro", 19, 2331);
            escola.Alunos.Add(aluno1);

            Professor professor2 = new Professor("Lucas", 45); 
            escola.Professores.Add(professor2);
            Professor professor1 = new Professor("Rogério", 34);
            escola.Professores.Add(professor1);

            Disciplina disciplina1 = new Disciplina("Matemática", 400, "Estudo de contas e numeros");
            Disciplina disciplina2 = new Disciplina("Ingles", 450, "Estudo da lingua mais falada entre países");
            escola.Disciplinas.Add(disciplina1);
            escola.Disciplinas.Add(disciplina2);

            Curso curso1 = new Curso("Engenharia");
            curso1.Disciplinas.Add(disciplina1);
            escola.Cursos.Add(curso1);

            while (rodando == true)
            {
                Console.WriteLine("1:Aluno");
                Console.WriteLine("2:Professor");
                Console.WriteLine("3:Sair");


                switch (Console.ReadLine())
                {
                    
                    case "1":
                        Console.Clear();
                        Console.WriteLine("1:Cadastrar novo aluno");
                        Console.WriteLine("2:Cadastrar um aluno em um curso");
                        Console.WriteLine("3:Lista de Alunos");
                        
                        switch (Console.ReadLine())
                        {
                                case "1":
                                escola.CadastrarAluno();
                                break;
                                case "2":
                                escola.PrintCursos();
                                escola.CadastroCursoAluno();
                                break;
                                case "3":
                                escola.PrintAluno();
                                break;
                                
                        }
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("1:Cadastrar novo professor");
                        Console.WriteLine("2:Cadastrar uma disciplina para um professor");
                        Console.WriteLine("3:Lista de Professores");
                        switch (Console.ReadLine())
                        {
                                case "1":
                                escola.CadastrarProfessor();
                                break;
                                case "2":
                                escola.CadastroDisciplinaProf();
                                break;
                                case "3":
                                escola.PrintProfessor();
                                break;
                        }

                        break;

                    case "3":
                        rodando = false;
                        break;

                }
            }








        }
    }
}