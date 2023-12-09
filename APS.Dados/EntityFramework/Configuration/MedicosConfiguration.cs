using APS.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.Dados.EntityFramework.Configuration
{
    public class MedicosConfiguration : IEntityTypeConfiguration<CadastroMedicos>
    {
        public void Configure(EntityTypeBuilder<CadastroMedicos> builder)
        {
            builder.ToTable("CadastroMedicos");
            builder.HasKey(f => f.CadastroMedicosID);

            builder
                .Property(f => f.CadastroMedicosID)
                .UseIdentityColumn()
                .HasColumnName("CadastroMedicosID")
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

                .Property(f => f.Especializacao)
                .HasColumnName("Especializacao")
                .HasColumnType("varchar(200)");
            builder

               .Property(f => f.NomeClinica)
               .HasColumnName("NomeClinica")
               .HasColumnType("varchar(200)");

            builder

               .Property(f => f.Numero)
               .HasColumnName("Numero")
               .HasColumnType("varchar(200)");



        }
    }
}
