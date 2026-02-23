using Microsoft.AspNetCore.Mvc;
using SeguroApi.Models;

namespace SeguroApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApoliceController : ControllerBase
    {
        private const int CODIGO_PRODUTO = 215;

        [HttpPost]
        public IActionResult GerarApolice([FromBody] ApoliceRequest request)
        {
            if (request == null || string.IsNullOrEmpty(request.NomeSegurado))
                return BadRequest("Dados inválidos");

            string numeroApolice = GerarNumeroApolice();

            var response = new ApoliceResponse
            {
                NumeroApolice = numeroApolice,
                CodigoProduto = CODIGO_PRODUTO,
                DataEmissao = DateTime.UtcNow
            };

            return Ok(response);
        }

        private string GerarNumeroApolice()
        {
            var random = new Random();
            var numeroSequencial = random.Next(100000, 999999);

            return $"{CODIGO_PRODUTO}-{DateTime.UtcNow:yyyyMMdd}-{numeroSequencial}";
        }
    }
}