using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OASIS.Context;
using OASIS.Models;

namespace OASIS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TarefaController : ControllerBase
    {
        private readonly OasisContext _context;

        public TarefaController(OasisContext context)
        {
            _context = context;
        }

        //CREATE
        [HttpPost]
        public IActionResult CriarPF(PessoaFisica pessoaFisica)
        {
            if (string.IsNullOrEmpty(pessoaFisica.Nome))
                return BadRequest(new { Erro = "O campo de Nome não pode ser Nulo" });

            _context.Add(pessoaFisica);
            _context.SaveChanges();

            return CreatedAtAction(nameof(ObterPorId), new { id = pessoaFisica.Id }, pessoaFisica);
        }

        //READ
        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id) 
        {
            var pessoaFisica = _context.Pessoas.Find(id);

            if (pessoaFisica == null)
                return NotFound();

            return Ok(pessoaFisica);
        }

        //UPDATE
        [HttpPut("{id}")]
        public IActionResult AtualizarPF(int id, PessoaFisica pessoaFisica)
        {
            var pessoaBanco = _context.Pessoas.Find(id);

            if (pessoaBanco == null)
                return NotFound();

            if (string.IsNullOrEmpty(pessoaFisica.Nome))
                return BadRequest(new { Erro = "O campo de Nome não pode ser vazio" });

            pessoaBanco.Nome = pessoaFisica.Nome;
            pessoaBanco.Email = pessoaFisica.Email;
            pessoaBanco.Telefone = pessoaFisica.Telefone;
            pessoaBanco.CPF = pessoaFisica.CPF;
            pessoaBanco.senha = pessoaFisica.senha;

            _context.Pessoas.Update(pessoaBanco);
            _context.SaveChanges();

            return Ok(pessoaBanco);
        }

        //DELETE
        [HttpDelete("{id}")]
        public IActionResult DeletarPF(int id)
        {
            var pessoaBanco = _context.Pessoas.Find(id);

            if (pessoaBanco == null)
                return NotFound();

            _context.Pessoas.Remove(pessoaBanco);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
