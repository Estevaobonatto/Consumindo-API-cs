using INtegraBrasilAPI.Interfaces; // Interfaces da API
using INtegraBrasilAPI.Mappings; // Mappings da API
using INtegraBrasilAPI.Rest; // Implementação da API
using INtegraBrasilAPI.Services; // Serviços da API

var builder = WebApplication.CreateBuilder(args); // Criação do builder

// Adiciona serviços ao contêiner
// Saiba mais sobre a configuração do Swagger/OpenAPI em https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers(); // Adiciona controladores
builder.Services.AddEndpointsApiExplorer(); // Adiciona os controladores de ponto de extremidade
builder.Services.AddSwaggerGen(); // Adiciona o Swagger

builder.Services.AddSingleton<IEnderecoService, EnderecoService>(); // Adiciona o serviço de endereço
//builder.Services.AddSingleton<IBancoService, BancoService>(); // Adiciona o serviço de banco
builder.Services.AddSingleton<IBrasilApi, BrasilApiRest>(); // Adiciona a implementação da API

//builder.Services.AddAutoMapper(typeof(EnderecoMapping), typeof(BancoMapping)); // Adiciona o mapeamento automático

var app = builder.Build(); // Cria a aplicação

// Configura o pipeline de solicitação HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); // Utiliza o Swagger em ambiente de desenvolvimento
    app.UseSwaggerUI(); // Utiliza a interface do usuário do Swagger
}

app.UseHttpsRedirection(); // Redireciona para HTTPS
app.UseAuthorization(); // Utiliza a autorização
app.MapControllers(); // Mapeia os controladores

app.Run(); // Executa a aplicação

