using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProdutosApp.Data.Repositories;
using ProdutosApp.Services.Models;

namespace ProdutosApp.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FornecedoresController : ControllerBase
    {
        /// <summary>
        /// Serviço para consultar todos os fornecedores na API
        /// </summary>
        [HttpGet]
        [ProducesResponseType(typeof(List<FornecedoresGetResponseModel>), 200)]
        public IActionResult Get()
        {
            try
            {
                //consultar os fornecedores cadastrados no banco de dados
                var fornecedorRepository = new FornecedorRepository();
                var fornecedores = fornecedorRepository.ObterTodos();

                //criando uma lista de objetos da classe FornecedoresGetResponseModel
                var response = new List<FornecedoresGetResponseModel>();
                foreach (var item in fornecedores)
                {
                    response.Add(new FornecedoresGetResponseModel
                    {
                        Id = item.Id,
                        RazaoSocial = item.RazaoSocial,
                        Cnpj = item.Cnpj
                    });
                }

                //retornar sucesso HTTP 200 -> OK
                return StatusCode(200, response);
            }
            catch (Exception e)
            {
                //retornar erro HTTP 500 -> INTERNAL SERVER ERROR
                return StatusCode(500, new { e.Message });
            }
        }
    }
}
