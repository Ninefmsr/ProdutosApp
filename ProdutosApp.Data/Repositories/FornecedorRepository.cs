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
    /// Classe de repositório de dados para fornecedor
    /// </summary>
    public class FornecedorRepository
    {
        /// <summary>
        /// Método para consultar todos os fornecedores cadastrados
        /// </summary>
        public List<Fornecedor> ObterTodos()
        {
            using (var dataContext = new DataContext())
            {
                return dataContext
                    .Set<Fornecedor>() //tabela de fornecedores
                    .OrderBy(f => f.RazaoSocial) //ordenar pelo campo razão social
                    .ToList(); //retornando uma lista de fornecedores
            }
        }
    }
}
