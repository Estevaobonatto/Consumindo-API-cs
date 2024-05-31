using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using INtegraBrasilAPI.Interfaces;
using INtegraBrasilAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace INtegraBrasilAPI.Controllers
{
    /// <summary>
    /// Controller responsável por buscar endereços pelo CEP
    /// </summary>
    [ApiController]
    [Route("api/v1/[controller]")]
    public class EnderecoController : ControllerBase
    {
        /// <summary>
        /// Serviço responsável por buscar endereços
        /// </summary>
        private readonly IEnderecoService _enderecoService;

        /// <summary>
        /// Construtor da classe
        /// </summary>
        /// <param name="enderecoService">Serviço de endereço</param>
        public EnderecoController(IEnderecoService enderecoService)
        {
            _enderecoService = enderecoService;
        }

        /// <summary>
        /// Busca um endereço pelo seu CEP
        /// </summary>
        /// <param name="cep">CEP do endereço</param>
        /// <returns>Uma tarefa contendo uma resposta contendo o modelo do endereço</returns>
        [HttpGet("{cep}")]
        public async Task<IActionResult> BuscarEndereco([FromRoute]string cep) {
            var response = await _enderecoService.BuscarEndereco(cep);
            if(response.CodigoHttp == HttpStatusCode.OK){
                return Ok(response.DadosRetorno);
            }else{
                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
            }
        }
    }
}
