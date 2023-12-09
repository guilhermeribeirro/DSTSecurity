using APS.Dados.EntityFramework.Configuration;
using APS.Dominio.Entities;
using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.Dados.EntityFramework
{
    public class Contexto : DbContext
    {
        public DbSet<CadastroPessoas> CadastroPessoas { get; set; }

        public DbSet<Depoimentos> Depoimentos { get; set; }

        public DbSet<CadastroMedicos> CadastroMedicos { get; set; }

        public Contexto() : base()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data source = 201.62.57.93, 1434; 
                                    Database = BD038216; 
                                    User ID = RA038216; 
                                    Password = 038216;
                                    TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CadastroPessoasConfiguration());
        }

    }
}


    

