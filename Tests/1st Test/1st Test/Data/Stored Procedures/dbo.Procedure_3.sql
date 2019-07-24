CREATE PROCEDURE dbo.ExcluirCliente
       @CPF varchar(15)
AS
       DELETE FROM clientes WHERE cpf = @cpf