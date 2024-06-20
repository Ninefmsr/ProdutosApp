using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProdutosApp.Data.Repositories;
using ProdutosApp.Services.Models;

namespace ProdutosApp.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        /// <summary>
        /// Serviço da API para retornar uma consulta de categorias
        /// </summary>
        [HttpGet]
        [ProducesResponseType(typeof(List<CategoriasGetResponseModel>), 200)]
        public IActionResult Get()
        {
            try
            {
                //consultando as categorias no banco de dados
                var categoriaRepository = new CategoriaRepository();
                var categorias = categoriaRepository.ObterTodos();

                //criando uma lista da classe de modelo de dados
                var response = new List<CategoriasGetResponseModel>();

                //percorrer todas as categorias obtidas do banco de dados
                foreach (var item in categorias)
                {
                    response.Add(new CategoriasGetResponseModel 
                    { 
                        Id = item.Id,
                        Nome = item.Nome
                    });
                }

                //retornando a lista com sucesso (HTTP 200 - OK)
                return StatusCode(200, response);
            }
            catch (Exception e)
            {
                //retornando erro do servidor
                return StatusCode(500, new { e.Message });
            }
        }
    }
}
