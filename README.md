# AppBlog - .NET MAUI

Um aplicativo de blog criado com .NET MAUI que consome dados da API (https://jsonplaceholder.typicode.com), exibe uma lista de posts em um feed e persiste os dados localmente para acesso offline.

## Funcionalidades

- Consulta dois endpoints da API:
  - `/users` – para obter os usuários
  - `/posts` – para obter os posts
- Exibe os posts em um feed com título, corpo e nome do autor
- Armazena os dados localmente para uso offline
- Arquitetura baseada em **Clean Architecture** e princípios **SOLID**
- Injeção de dependência via `Microsoft.Extensions.DependencyInjection`

## Tecnologias

- [.NET MAUI](https://learn.microsoft.com/dotnet/maui/)
- SQLite para persistência local
- MVVM (Model-View-ViewModel)
- HttpClient para consumo de APIs
- CommunityToolkit.Mvvm
- Clean Architecture + SOLID

## Como rodar

### Pré-requisitos

- .NET 8 SDK
- Android SDK (com licenças aceitas)
- Microsoft OpenJDK 11
- Visual Studio 2022 ou superior com suporte ao MAUI

### Passos

1. Clone o repositório:

git clone https://github.com/jorgericardoacaldas/AppBlog.git
cd AppBlog

dotnet restore


