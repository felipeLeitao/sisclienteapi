# SisClientes

#OVER VIEW

Web api que vai ser usado nas palestras sobre angular JS, o projeto contem basicamente, uma controller, aceitando requisições para cadastrar e listar. Em breve coloco mais coisas como alterar e excluir.

#Listar

Retorna todos os amigos cadastados.

url: /api/cliente
method: GET

Exemplo: 
[
{
id: 1,
nome: "felipe",
email: "fesilva@Outlook.com.br"
}
]

#Cadastrar

Cadastra o amigo enviado.

url: /api/amigo/cadastrar
method: POST
data: {
    "nome" : "algum nome",
    "email" : "algumemail@teste.com"
}
