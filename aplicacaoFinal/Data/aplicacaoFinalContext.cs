using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using aplicacaoFinal.Models;

namespace aplicacaoFinal.Data
{
    public class aplicacaoFinalContext : DbContext
    {
        public aplicacaoFinalContext (DbContextOptions<aplicacaoFinalContext> options)
            : base(options)
        {
        }

        public DbSet<aplicacaoFinal.Models.Usuario> Usuario { get; set; } = default!;

        public DbSet<aplicacaoFinal.Models.Posto> Posto { get; set; } = default!;
    }
}
