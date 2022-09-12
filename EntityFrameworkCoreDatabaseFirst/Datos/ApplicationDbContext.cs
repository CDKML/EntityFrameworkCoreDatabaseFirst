using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using EntityFrameworkCoreDatabaseFirst.Models;

namespace EntityFrameworkCoreDatabaseFirst.Datos
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<nota> notas { get; set; }
        public DbSet<usuario> usuarios { get; set; }
    }
}
