using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using INtegraBrasilAPI.Dtos;
using INtegraBrasilAPI.Models;

namespace INtegraBrasilAPI.Interfaces
{
    /// <summary>
    /// Interface que define os métodos para buscar endereços
    /// </summary>
    public interface IEnderecoService
    {
        /// <summary>
        /// Busca um endereço pelo seu CEP
        /// </summary>
        /// <param name="cep">CEP do endereço</param>
        /// <returns>Uma tarefa contendo uma resposta contendo o modelo do endereço</returns>
        Task<ResponseGenerico<EnderecoResponse>> BuscarEndereco(string cep);
    }
}
