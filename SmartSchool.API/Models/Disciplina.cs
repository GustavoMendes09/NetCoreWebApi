using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.API.Models
{
    public class Disciplina
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CargaHoraria { get; set; }
        public int? PrerequisitoId { get; set; } = null;
        public Disciplina Prerequisito { get; set; }
        public int ProfessorId { get; set; }
        public Professor professor { get; set; }
        public int CursoId { get; set; }
        public Curso Curso { get; set; }
        public IEnumerable<AlunoDisciplina> AlunosDisciplinas { get; set; }
       
        

        public Disciplina()
        {
        }

        public Disciplina(int id, string nome, int professorId, int cursoId)
        {
            Id = id;
            Nome = nome;
            ProfessorId = professorId;
            CursoId = cursoId;
        }
    }
}
