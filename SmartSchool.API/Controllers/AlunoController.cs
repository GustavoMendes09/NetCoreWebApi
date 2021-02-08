using Microsoft.AspNetCore.Mvc;
using SmartSchool.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartSchool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        public List<Aluno> Alunos = new List<Aluno>()
        {
            new Aluno()
            {
                Id = 1,
                Nome = "Marcos",
                Sobrenome = "Junior",
                Telefone = "123456"
            },
            new Aluno()
            {
                Id = 2,
                Nome = "Ana",
                Sobrenome = "Junior",
                Telefone = "1234456"
            },
            new Aluno()
            {
                Id = 3,
                Nome = "Julieta",
                Sobrenome = "Junior",
                Telefone = "12345601"
            }
        };

            public AlunoController() { }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Alunos);
        }

        //api/aluno/byId
        [HttpGet("byId/{id}")]
        public IActionResult GetById(int id)
        {
            var aluno = Alunos.FirstOrDefault(aluno => aluno.Id == id);
            if (aluno == null) return BadRequest("Aluno não encontrado");
            return Ok(Alunos);
        }

        //api/aluno/nome
        [HttpGet("ByName")]
        public IActionResult GetByName(string nome, string sobrenome)
        {
            var aluno = Alunos.FirstOrDefault(aluno => 
                aluno.Nome.Contains(nome) && aluno.Sobrenome.Contains(sobrenome)
                );
            if (aluno == null) return BadRequest("Aluno não encontrado");
            return Ok(Alunos);
        }

        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            return Ok(Alunos);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno)
        {
            return Ok(Alunos);
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Aluno aluno)
        {
            return Ok(Alunos);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }


        // GET: api/<AlunoController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<AlunoController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<AlunoController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<AlunoController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<AlunoController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
