using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC
{
    public class Context : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=NT000645;Database=cursoMvc;Integrated Security=true");
        }
    }
}
