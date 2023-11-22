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
    public class CadastroPessoasConfiguration : IEntityTypeConfiguration<CadastroPessoas>
    {
        public void Configure(EntityTypeBuilder<CadastroPessoas> builder)
        {
            builder.ToTable("CadastroPessoas");
            builder.HasKey(f => f.CadastroPessoasID);

            builder
                .Property(f => f.CadastroPessoasID)
                .UseIdentityColumn()
                .HasColumnName("CadastroPessoasID")
                .HasColumnType("int");


            builder
                .Property(f => f.Nome)
                .HasColumnName("Nome")
                .HasColumnType("varchar(100)");

            


            builder
                .Property(f => f.Sobrenome)
                .HasColumnName("Sobrenome")
                .HasColumnType("varchar(100)");

            builder

                .Property(f => f.CPF)
                .HasColumnName("CPF")
                .HasColumnType("char(11)");
       

            builder
                .Property(f => f.Sexo)
                .HasColumnName("Sexo")
                .HasColumnType("char(1)");


            builder
                .Property(f => f.Endereco)
                .HasColumnName("Endereco")
                .HasColumnType("varchar(200)");

            builder

                .Property(f => f.Email)
                .HasColumnName("Email")
                .HasColumnType("varchar(150)");

            builder

                .Property(f => f.Senha)
                .HasColumnName("Senha")
                .HasColumnType("varchar(100)");

        }
    }
}