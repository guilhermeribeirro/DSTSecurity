using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using APS.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.Dados.EntityFramework.Configuration
{
    public class DepoimentosConfiguration : IEntityTypeConfiguration<Depoimentos>
    {
        public void Configure(EntityTypeBuilder<Depoimentos> builder)
        {
            builder.ToTable("Depoimentos");
            builder.HasKey(f => f.DepoimentosID);

            builder
                .Property(f => f.DepoimentosID)
                .UseIdentityColumn()
                .HasColumnName("DepoimentosID")
                .HasColumnType("int");
            builder
                .Property(f => f.Nome1)
                .HasColumnName("Nome1")
                .HasColumnType("varchar(100)");

            builder
                .Property(f => f.Relato)
                .HasColumnName("Relato")
                .HasColumnType("varchar(600)");




            

        }
    }
}