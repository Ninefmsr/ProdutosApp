using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutosApp.Data.Entities
{
    public class Produto
    {
        #region Propriedades

        public Guid? Id { get; set; } //Chave primária
        public string? Nome { get; set; }
        public decimal? Preco { get; set; }
        public int? Quantidade { get; set; }
        public Guid? CategoriaId { get; set; } //Chave estrangeira
        public Guid? FornecedorId { get; set; } //Chave estrangeira

        #endregion

        #region Relacionamentos de composição

        public Categoria? Categoria { get; set; } //ter-1
        public Fornecedor? Fornecedor { get; set; } //ter-1

        #endregion
    }
}
