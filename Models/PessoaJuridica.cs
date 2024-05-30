using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OASIS.Models
{
    public class PessoaJuridica
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }
        public string? CPF { get; set; }
        public string? senha { get; set; }
    }
}