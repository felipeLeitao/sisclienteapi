# SisClientes

#OVER VIEW

Web api que vai ser usado nas palestras sobre angular JS, o projeto contem basicamente, uma controller, aceitando requisições para cadastrar e listar. Em breve coloco mais coisas como alterar e excluir.

#Listar

Retorna todos os clientes cadastados.

url: /api/cliente
method: GET

Exemplo: 
[
{
Codigo: 1,
Nome: "felipe",
Email: "fesilva1@outlook.com.br",
CEP: "03969000",
Logradouro: "Rua Manoel Quirino de Mattos",
Bairro: "Jardim Sapopemba",
Cidade: "São Paulo",
UF: "SP"
}
]

#Cadastrar

Cadastra o cliente enviado.

url: /api/amigo/cadastrar
method: POST
data: {
Codigo: 1,
Nome: "felipe",
Email: "fesilva1@outlook.com.br",
CEP: "03969000",
Logradouro: "Rua Manoel Quirino de Mattos",
Bairro: "Jardim Sapopemba",
Cidade: "São Paulo",
UF: "SP"
}
