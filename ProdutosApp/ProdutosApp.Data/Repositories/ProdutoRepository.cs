using Microsoft.EntityFrameworkCore;
using ProdutosApp.Data.Contexts;
using ProdutosApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutosApp.Data.Repositories
{
    /// <summary>
    /// Classe de repositório de dados para produto
    /// </summary>
    public class ProdutoRepository
    {
        /// <summary>
        /// Método para inserir um produto no banco de dados
        /// </summary>
        public void Inserir(Produto produto)
        {
            using (var dataContext = new DataContext())
            {
                dataContext.Add(produto); //inserindo no banco de dados
                dataContext.SaveChanges(); //executando a operação
            }
        }

        /// <summary>
        /// Método para atualizar um produto no banco de dados
        /// </summary>
        public void Alterar(Produto produto)
        {
            using (var dataContext = new DataContext())
            {
                dataContext.Update(produto); //atualizando no banco de dados
                dataContext.SaveChanges(); //executando a operação
            }
        }

        /// <summary>
        /// Método para excluir um produto no banco de dados
        /// </summary>
        public void Excluir(Produto produto)
        {
            using (var dataContext = new DataContext())
            {
                dataContext.Remove(produto);
                dataContext.SaveChanges();
            }
        }

        /// <summary>
        /// Método para consultar todos os produtos cadastrados
        /// </summary>
        public List<Produto> ObterTodos()
        {
            using (var dataContext = new DataContext())
            {
                return dataContext
                    .Set<Produto>() //consultar a tabela de produto
                    .Include(p => p.Fornecedor) //JOIN com a tabela de Fornecedor
                    .Include(p => p.Categoria) //JOIN com a tabela de Categoria
                    .OrderBy(p => p.Nome) //ordenar pelo nome
                    .ToList(); //retornar uma lista
            }
        }

        /// <summary>
        /// Método para consultar 1 produto através do ID
        /// </summary>
        public Produto? ObterPorId(Guid id)
        {
            using (var dataContext = new DataContext())
            {
                return dataContext
                    .Set<Produto>() //consultar a tabela de produto
                    .Include(p => p.Fornecedor) //JOIN com a tabela de Fornecedor
                    .Include(p => p.Categoria) //JOIN com a tabela de Categoria
                    .Where(p => p.Id == id) //filtrando pelo id (chave primária)
                    .FirstOrDefault(); //retornar o primeiro registro ou null
            }
        }
    }
}
