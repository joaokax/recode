using AgenciaViagens.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgenciaViagens.Data
{
    public class ContaContext : DbContext 
    {
        public ContaContext (DbContextOptions<ContaContext> opt) : base(opt)
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Destino> Destinos { get; set; }
        

    }
}
