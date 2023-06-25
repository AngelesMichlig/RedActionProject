using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RedAction.Models;

    public class RedActionDBContext : DbContext
    {
        public RedActionDBContext (DbContextOptions<RedActionDBContext> options)
            : base(options)
        {
        }

        public DbSet<RedAction.Models.Articulo> Articulo { get; set; } = default!;

        public DbSet<RedAction.Models.Usuario>? Usuario { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=LAPTOP-D68A60BE\SQLEXPRESS;Database=RedActionDBMVC-G;Trusted_Connection=True;");
    }
}
