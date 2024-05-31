using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using INtegraBrasilAPI.Dtos;
using INtegraBrasilAPI.Interfaces;
using INtegraBrasilAPI.Models;

namespace INtegraBrasilAPI.Rest
{
    public class BrasilApiRest : IBrasilApi
    {
        public Task<ResponseGenerico<BancoModel>> BuscarBanco(string codigoBanco)
        {
            throw new NotImplementedException();
        }

        public Task BuscarEndereco(string cep)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseGenerico<EnderecoModel>> BuscarEnderecoPorCEP(string cep)
        {
            // Cria uma requisição HTTP GET para a API BrasilApi com o CEP fornecido
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/cep/v1/{cep}");

            var response = new ResponseGenerico<EnderecoModel>();
            using (var client = new HttpClient())
            {
                // Envia a requisição e aguarda a resposta
                var responseBrasilApi = await client.SendAsync(request);

                // Lê o conteúdo da resposta como string
                var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();

                // Deserializa o conteúdo da resposta em um objeto EnderecoModel
                var objResponse = JsonSerializer.Deserialize<EnderecoModel>(contentResp);

                // Verifica se a requisição foi bem-sucedida
                if (responseBrasilApi.IsSuccessStatusCode)
                {
                    // Define o código HTTP da resposta como o código HTTP da resposta da API
                    response.CodigoHttp = responseBrasilApi.StatusCode;

                    // Define o objeto de retorno como o objeto deserializado
                    response.DadosRetorno = objResponse;
                }
                else
                {
                    // Define o código HTTP da resposta como o código HTTP da resposta da API
                    response.CodigoHttp = responseBrasilApi.StatusCode;

                    // Deserializa o conteúdo da resposta em um objeto ExpandoObject para armazenar informações de erro
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
                }
            }

            // Retorna a resposta com o objeto de retorno ou informações de erro
            return response;
        }
        
        public Task<ResponseGenerico<List<BancoModel>>> BuscarTodosBancos()
        {
                    throw new NotImplementedException();
        }
        
    }
    
        
        
        

        
}