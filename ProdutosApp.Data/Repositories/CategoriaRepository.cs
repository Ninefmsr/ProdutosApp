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
    /// Classe de repositório de dados para categoria
    /// </summary>
    public class CategoriaRepository
    {
        /// <summary>
        /// Método para consultar todas as categorias cadastradas
        /// </summary>
        public List<Categoria> ObterTodos()
        {
            using (var dataContext = new DataContext())
            {
                return dataContext
                    .Set<Categoria>() //tabela de categorias
                    .OrderBy(c => c.Nome) //order de nome
                    .ToList(); //retornando uma lista de categorias
            }
        }
    }
}
