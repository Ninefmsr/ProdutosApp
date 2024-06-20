namespace ProdutosApp.Services.Models
{
    /// <summary>
    /// Modelo de dados para a consulta de produtos
    /// </summary>
    public class ProdutosGetResponseModel
    {
        public Guid? Id { get; set; }
        public string? Nome { get; set; }
        public decimal? Preco { get; set; }
        public int? Quantidade { get; set; }
        public CategoriasGetResponseModel? Categoria { get; set; }
        public FornecedoresGetResponseModel? Fornecedor { get; set; }
    }
}
