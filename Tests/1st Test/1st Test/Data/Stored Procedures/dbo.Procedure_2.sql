CREATE PROCEDURE dbo.buscaTodos
AS
       SELECT cpf, nome, endereco, telefone
       FROM clientes