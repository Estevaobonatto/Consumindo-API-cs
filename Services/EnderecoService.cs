using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using INtegraBrasilAPI.Dtos;
using INtegraBrasilAPI.Interfaces;

namespace INtegraBrasilAPI.Services
{
    /// <summary>
    /// Classe responsável por fornecer serviços de endereço
    /// </summary>
    public class EnderecoService : IEnderecoService
    {
        /// <summary>
        /// Mapper de objetos
        /// </summary>
        private readonly IMapper _mapper;

        /// <summary>
        /// Interface de comunicação com a API BrasilApi
        /// </summary>
        private readonly IBrasilApi _brasilApi;

        /// <summary>
        /// Construtor da classe
        /// </summary>
        /// <param name="mapper">Mapper de objetos</param>
        /// <param name="brasilApi">Interface de comunicação com a API BrasilApi</param>
        public EnderecoService(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        /// <summary>
        /// Busca um endereço pelo seu CEP
        /// </summary>
        /// <param name="cep">CEP do endereço</param>
        /// <returns>Uma tarefa contendo uma resposta contendo o modelo do endereço</returns>
        public async Task<ResponseGenerico<EnderecoResponse>> BuscarEndereco(string cep)
        {
            // Busca o endereço pelo CEP na API BrasilApi
            var endereco = await _brasilApi.BuscarEnderecoPorCEP(cep);

            // Mapeia o endereço para o modelo de resposta
            return _mapper.Map<ResponseGenerico<EnderecoResponse>>(endereco);
        }
    }
}
