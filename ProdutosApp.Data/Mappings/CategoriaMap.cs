using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProdutosApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutosApp.Data.Mappings
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            //nome da tabela
            builder.ToTable("CATEGORIA");

            //campo chave primária
            builder.HasKey(c => c.Id);

            //mapeamento do campo 'Id'
            builder.Property(c => c.Id)
                .HasColumnName("ID");

            //mapeamento do campo 'Nome'
            builder.Property(c => c.Nome)
                .HasColumnName("NOME")
                .HasMaxLength(50)
                .IsRequired();

            //definindo o campo 'Nome' como único
            builder.HasIndex(c => c.Nome)
                .IsUnique();
        }
    }
}
