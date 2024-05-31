using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using INtegraBrasilAPI.Dtos;
using INtegraBrasilAPI.Models;

namespace INtegraBrasilAPI.Interfaces
{
    public interface IEnderecoService
    {
        Task<ResponseGenerico<EnderecoResponse>> BuscarEndereco(string cep);
    }
}