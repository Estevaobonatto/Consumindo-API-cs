using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace INtegraBrasilAPI.Models
{
    /// <summary>
    /// Modelo de endereço
    /// </summary>
    public class EnderecoModel
    {
        /// <summary>
        /// CEP do endereço
        /// </summary>
        [JsonPropertyName("cep")]
        public string? Cep { get; set; }

        /// <summary>
        /// Estado do endereço
        /// </summary>
        [JsonPropertyName("state")]
        public string? Estado { get; set; }

        /// <summary>
        /// Cidade do endereço
        /// </summary>
        [JsonPropertyName("city")]
        public string? Cidade { get; set; }

        /// <summary>
        /// Região do endereço
        /// </summary>
        [JsonPropertyName("neighborhood")]
        public string? Regiao { get; set; }

        /// <summary>
        /// Rua do endereço
        /// </summary>
        [JsonPropertyName("street")]
        public string? Rua { get; set; }

        /// <summary>
        /// Serviço do endereço
        /// </summary>
        [JsonPropertyName("service")]
        public string? Servico { get; set; }
    }
}
