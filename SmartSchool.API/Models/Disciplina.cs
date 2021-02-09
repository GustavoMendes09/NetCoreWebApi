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
        public int DisciplinaId { get; set; }

        public Disciplina()
        {
        }

        public Disciplina(int id, string nome , int disciplinaId)
        {
            Id = id;
            Nome = nome;
            DisciplinaId = disciplinaId;
        }
    }
}
