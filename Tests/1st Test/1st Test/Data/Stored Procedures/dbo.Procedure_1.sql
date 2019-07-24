ALTER PROCEDURE dbo.buscaCliNome
       @nome varchar(50)
AS
       SELECT cpf, nome, endereco, telefone
       FROM clientes
       WHERE nome like @nome +'%'