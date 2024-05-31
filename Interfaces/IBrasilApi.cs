using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using INtegraBrasilAPI.Dtos;
using INtegraBrasilAPI.Models;

namespace INtegraBrasilAPI.Interfaces
{
    /// <summary>
    /// Interface que define os métodos da API BrasilApi
    /// </summary>
    public interface IBrasilApi
    {
        /// <summary>
        /// Busca um endereço pelo seu CEP
        /// </summary>
        /// <param name="cep">CEP do endereço</param>
        /// <returns>Uma tarefa contendo uma resposta contendo o modelo do endereço</returns>
        Task<ResponseGenerico<EnderecoModel>> BuscarEnderecoPorCEP(string cep);

        /// <summary>
        /// Busca todos os bancos no BrasilApi
        /// </summary>
        /// <returns>Uma tarefa contendo uma resposta contendo a lista de modelos dos bancos</returns>
        Task<ResponseGenerico<List<BancoModel>>> BuscarTodosBancos();

        /// <summary>
        /// Busca um banco pelo seu código
        /// </summary>
        /// <param name="codigoBanco">Código do banco</param>
        /// <returns>Uma tarefa contendo uma resposta contendo o modelo do banco</returns>
        Task<ResponseGenerico<BancoModel>> BuscarBanco(string codigoBanco);

        /// <summary>
        /// Busca um endereço pelo seu CEP
        /// </summary>
        /// <param name="cep">CEP do endereço</param>
        /// <returns>Uma tarefa contendo uma resposta contendo o modelo do endereço</returns>
        Task BuscarEndereco(string cep);
    }
}
