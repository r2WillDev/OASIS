using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OASIS.Models;
using OASIS.Controllers;


namespace OASIS.Context
{
    public class OasisContext : DbContext
    {
        public OasisContext(DbContextOptions<OasisContext> options) : base(options) {

        }

        public DbSet<PessoaFisica> Pessoas { get; set; }
        public DbSet<PessoaJuridica> Empresas { get; set; }
        public DbSet<Sala> Salas { get; set; }
    }
}