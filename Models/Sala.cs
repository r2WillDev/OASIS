using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OASIS.Models
{
    public class Sala
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public EnumStatusSala Status { get; set; }
        public string? Tamanho { get; set; }
        public int Capacidade { get; set; }
    }
}