using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProdutosApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutosApp.Data.Mappings
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            //nome da tabela
            builder.ToTable("PRODUTO");

            //chave primária
            builder.HasKey(p => p.Id);

            //mapeamento do campo 'Id'
            builder.Property(p => p.Id)
                .HasColumnName("ID");

            //mapeamento do campo 'Nome'
            builder.Property(p => p.Nome)
                .HasColumnName("NOME")
                .HasMaxLength(100)
                .IsRequired();

            //mapeamento do campo 'Preco'
            builder.Property(p => p.Preco)
                .HasColumnName("PRECO")
                .HasColumnType("DECIMAL(10,2)")
                .IsRequired();

            //mapeamento do campo 'Quantidade'
            builder.Property(p => p.Quantidade)
                .HasColumnName("QUANTIDADE")
                .IsRequired();

            //mapeamento do campo 'CategoriaId'
            builder.Property(p => p.CategoriaId)
                .HasColumnName("CATEGORIA_ID")
                .IsRequired();

            //mapeamento do campo 'FornecedorId'
            builder.Property(p => p.FornecedorId)
                .HasColumnName("FORNECEDOR_ID")
                .IsRequired();

            //mapeamento do relacionamento Produto com Categoria (1pN)
            builder.HasOne(p => p.Categoria) //Produto TEM 1 Categoria
                .WithMany(c => c.Produtos) //Categoria TEM MUITOS produtos
                .HasForeignKey(p => p.CategoriaId) //Chave estrangeira
                .OnDelete(DeleteBehavior.NoAction);

            //mapeamento do relacionamento Produto com Fornecedor
            builder.HasOne(p => p.Fornecedor) //Produto TEM 1 Fornecedor
                .WithMany(f => f.Produtos) //Fornecedor TEM MUITOS Produtos
                .HasForeignKey(p => p.FornecedorId) //Chave estrangeira
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
