using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using desafio_final_atos.Models;

namespace desafio_final_atos.Data
{
    public class desafio_final_atosContext : DbContext
    {
        public desafio_final_atosContext (DbContextOptions<desafio_final_atosContext> options)
            : base(options)
        {
        }

        public DbSet<desafio_final_atos.Models.Cliente>? Cliente { get; set; }

        public DbSet<desafio_final_atos.Models.Produto>? Produto { get; set; }

        public DbSet<desafio_final_atos.Models.Venda>? Venda { get; set; }

        public DbSet<desafio_final_atos.Models.ItemVenda>? ItemVenda { get; set; }
    }
}
