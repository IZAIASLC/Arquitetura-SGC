using Microsoft.EntityFrameworkCore;
using prmToolkit.NotificationPattern;
using SCG.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCG.Infrastructure.Data
{
    public class SgcContext:DbContext
    {
        public SgcContext(DbContextOptions<SgcContext> options):base(options)
        {
                
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Contato> Contatos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Contato>().ToTable("Contato");
            modelBuilder.Ignore<Notification>();
        }
    }
}
