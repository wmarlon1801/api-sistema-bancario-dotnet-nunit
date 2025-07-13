# API Bancária (.NET 8 + NUnit)

Projeto de uma API REST para operações bancárias, desenvolvida com .NET 8 e testes automatizados utilizando o NUnit.

---

## Estrutura do Projeto

SistemaBancario/
├── SistemaBancario.API # Camada de apresentação (Web API)
├── SistemaBancario.Core # Camada de domínio (regras de negócio)
├── SistemaBancario.Testes # Testes automatizados com NUnit
├── .gitignore
├── SistemaBancario.sln

---

##  Como Executar a API

Para rodar a aplicação localmente:

```bash
dotnet build
dotnet run --project SistemaBancario.API

A API estará disponível em:
📍 https://localhost:5001
📍 http://localhost:5000

Testes Automatizados
Os testes estão localizados na pasta SistemaBancario.Testes.
Para executá-los:

dotnet test


## Tecnologias Utilizadas

- ASP.NET Core 8
- NUnit
- Docker (opcional)
- Git & GitHub

---

```md
## Sobre o Autor

Desenvolvido por **Wesley Macedo**, desenvolvedor .NET apaixonado por APIs, boas práticas e testes automatizados.  
Entre em contato: [LinkedIn]((https://www.linkedin.com/in/wesley-santos-97621b178/)) | [Email](wesleytrabalhos1801@gmail.com)
