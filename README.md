# DadosApi1
Implementação de Web API de Filmes com Entity Framework Core e MySql.
## Endpoints
![image](https://github.com/CarlosDiones96/DadosApi1/assets/69810072/e070fa66-b05b-485c-91de-3760dcee954e)
## Schemas
![image](https://github.com/CarlosDiones96/DadosApi1/assets/69810072/f817fc49-063c-488a-a362-cdcb86d2d799)


## Projeto
Projeto implementado em ASP.NET Core, Entity Framework Core e MySql (MySQL Workbench).
### Bibiotecas
- `AutoMapper`
- `AutoMapper.Extensions.Microsoft.DependencyInjection`
- `Microsoft.EntityFrameworkCore`
- `Microsoft.EntityFrameworkCore.Tools`
- `MySql.EntityFrameworkCore`
- `Swashbuckle.AspNetCore`
### Estrutura
Na pasta `Data` encontram-se a classe de contexto para acesso à base de dados do projeto (`FilmeContext`) e  o subdiretório `Dtos`. Essas classes DTO são mapeadas com `AutoMapper`, que se encontra na pasta `Profiles`.

Note que o mapeamento segue a lógica dos verbos HTTP (criação, recuperação e atualização).

```csharp
public class FilmeProfile : Profile
{
    public FilmeProfile()
    {
        CreateMap<CreateFilmeDto, Filme>();
        CreateMap<Filme, ReadFilmeDto>();
        CreateMap<UpdateFilmeDto, Filme>();
    }
}
```
## Acesso a dados
Para que o Entity Framework Core funcione corretamente é necessário criar uma base de dados no MySQL Workbench ou qualquer SGBD de sua preferência desde que haja suporte pelo ORM.
Depois disso, crie uma Connection String e adicione às configurações do projeto.
Para realizar a conexão no código atente-se para o seuinte snippet em `Program.cs`:
```csharp
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<FilmeContext>(opt => opt.UseMySQL(connectionString));
```
Onde `DefaultConnection`pode ser qualquer outro nome.
# Fazendo requisições com Postman
## POST /Filme
![image](https://github.com/CarlosDiones96/DadosApi1/assets/69810072/8f6922cc-5033-4228-9b7b-14ce99264942)
## GET /Filme
![image](https://github.com/CarlosDiones96/DadosApi1/assets/69810072/a4a0bcb3-9f5e-4bad-9a15-ab93243e01e4)
## GET /Filme?
![image](https://github.com/CarlosDiones96/DadosApi1/assets/69810072/181f055b-14f1-4fd5-bea0-dc8e8308d116)
## GET /Filme/{id}
![image](https://github.com/CarlosDiones96/DadosApi1/assets/69810072/0fa1060b-5c7c-42d1-a469-c3a4989d04dc)
## PUT /Filme/{id}
![image](https://github.com/CarlosDiones96/DadosApi1/assets/69810072/20a2ccc7-6f53-4d96-904b-c82750145702)
## DELETE /Filme/{id}
![image](https://github.com/CarlosDiones96/DadosApi1/assets/69810072/4411e048-e193-409f-8d7d-635926fc1eed)




