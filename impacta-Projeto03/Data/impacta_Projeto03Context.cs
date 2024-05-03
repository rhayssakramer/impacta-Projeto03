using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using impacta_Projeto03.Models;

namespace impacta_Projeto03.Data
{
    public class impacta_Projeto03Context : DbContext
    {
        public impacta_Projeto03Context (DbContextOptions<impacta_Projeto03Context> options)
            : base(options)
        {
        }

        public DbSet<impacta_Projeto03.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<impacta_Projeto03.Models.Acesso> Acesso { get; set; } = default!;
        public DbSet<impacta_Projeto03.Models.Funcionario> Funcionario { get; set; } = default!;
        public DbSet<impacta_Projeto03.Models.Produto> Produto { get; set; } = default!;
        public DbSet<impacta_Projeto03.Models.Venda> Venda { get; set; } = default!;
    }
}
