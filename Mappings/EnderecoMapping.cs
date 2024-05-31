using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using INtegraBrasilAPI.Dtos;
using INtegraBrasilAPI.Models;

namespace INtegraBrasilAPI.Mappings
{
    /// <summary>
    /// Classe que define os mapeamentos entre os modelos de resposta da API e os modelos de domínio da aplicação.
    /// </summary>
    public class EnderecoMapping : Profile
    {
        /// <summary>
        /// Construtor que cria os mapeamentos entre os modelos de resposta da API e os modelos de domínio da aplicação.
        /// </summary>
        public EnderecoMapping()
        {
            // Mapeia a resposta genérica da API para a resposta genérica do domínio
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));

            // Mapeia o modelo de resposta da API para o modelo de domínio
            CreateMap<EnderecoResponse, EnderecoModel>();

            // Mapeia o modelo de domínio para o modelo de resposta da API
            CreateMap<EnderecoModel, EnderecoResponse>();
        }
    }
}
