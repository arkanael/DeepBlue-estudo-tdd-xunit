DeepBlue - Controle de Produtos
Projeto desenvolvido em .NET CORE para o estudo do TDD, realizando rotinas de testes nas controllers, testando assim os m�todos
POST, PUT, DELETE, GET que s�o responsaveis por cadastrar, atualizar, apagar e obter os dados da API.


ASPNET CORE 2.2.
DataDriven Design
Inje��o de depend�ncia
AutoMapper
Swagger
XUnit
FluentAssertions
Repository Pattern

Swagger Habilitado
Para explorar e testar a API, basta executar o projeto e usar a interface do usu�rio do Swagger.

A API incluem os seguintes endpoints REST:
POST /api/produto			- Registra um novo produto.								[implementado]
PUT /api/produto			- Atualiza um produto registrado no sistema.			[implementando]
DELETE /api/Produto/{id}	- Apaga um produto registrado no sistema.				[implementando]
GET /api/produto			- Exibe todos os produtos registrado no sistema.		[implementando]
GET /api/Produto/{id}		- Exibe apenas o produto com id registrado no sistema.	[implementando]

Projeto n�o finalizado.