<p align="center">
    <img src="https://i.postimg.cc/JhMc1Thw/net-core.png" />
</p>

DeepBlue - Controle de Produtos

Repositório responsável pelos códigos desenvolvidos no estudo do TDD, utilizando o XUnit, realizando rotinas de testes na(s) controller(s) do projeto, testando assim os métodos
POST, PUT, DELETE, GET que são responsaveis por cadastrar, atualizar, apagar e obter os dados da API.

## Recursos Utilizados 🚀
ASPNET CORE 2.2
DataDriven Design
Injeção de dependência
AutoMapper
Swagger
XUnit
FluentAssertions
Repository Pattern
DataBase simulada com ConcurrentDictionary

## Entidades do projeto
### Produto
- Id
- Nome
- Preco
- Quantidade

## Swagger Habilitado🔍
Para explorar e testar a API, basta executar o projeto e usar a interface do usuário do Swagger.

A API incluem os seguintes endpoints REST:
- POST	/api/produto		- Registra um novo produto.		

- PUT		/api/produto		- Atualiza um produto registrado no sistema.	

- DELETE	/api/Produto/{id}	- Apaga um produto registrado no sistema.	

- GET		/api/produto		- Exibe todos os produtos registrado no sistema.	
	
- GET		/api/Produto/{id}	- Exibe apenas o produto com id registrado no sistema.

Projeto não finalizado.