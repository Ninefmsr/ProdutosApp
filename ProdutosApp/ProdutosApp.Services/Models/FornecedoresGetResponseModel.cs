namespace ProdutosApp.Services.Models
{
    /// <summary>
    /// Modelo de dados para a consulta de fornecedores
    /// </summary>
    public class FornecedoresGetResponseModel
    {
        public Guid? Id { get; set; }
        public string? RazaoSocial { get; set; }
        public string? Cnpj { get; set; }
    }
}
