CREATE PROCEDURE dbo.buscaCliCPF
       @CPF varchar(15)
AS
       SELECT cpf, nome, endereco, telefone
       FROM clientes
       WHERE CPF=@CPF
