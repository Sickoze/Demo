CREATE PROCEDURE dbo.inserir_alterar_Cliente
       @CPF varchar(15),
       @nome varchar(50),
       @endereco varchar (100),
       @telefone varchar(15),
       @flag int
AS
       if (@flag = 1)
       BEGIN
             INSERT INTO Clientes(cpf,nome,endereco,telefone)
             VALUES(@CPF,@nome,@endereco,@telefone)
       END
       else BEGIN
             UPDATE clientes 
             SET nome = @nome, endereco = @endereco, telefone = @telefone
             WHERE cpf = @cpf
       END