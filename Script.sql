-- Geração de 10 inserts para a tabela CATEGORIA

-- Insert 1
INSERT INTO [dbo].[CATEGORIA] ([ID], [NOME])
VALUES (NEWID(), 'Eletrônicos');

-- Insert 2
INSERT INTO [dbo].[CATEGORIA] ([ID], [NOME])
VALUES (NEWID(), 'Roupas');

-- Insert 3
INSERT INTO [dbo].[CATEGORIA] ([ID], [NOME])
VALUES (NEWID(), 'Acessórios');

-- Insert 4
INSERT INTO [dbo].[CATEGORIA] ([ID], [NOME])
VALUES (NEWID(), 'Cosméticos');

-- Insert 5
INSERT INTO [dbo].[CATEGORIA] ([ID], [NOME])
VALUES (NEWID(), 'Livros');

-- Insert 6
INSERT INTO [dbo].[CATEGORIA] ([ID], [NOME])
VALUES (NEWID(), 'Alimentos');

-- Insert 7
INSERT INTO [dbo].[CATEGORIA] ([ID], [NOME])
VALUES (NEWID(), 'Brinquedos');

-- Insert 8
INSERT INTO [dbo].[CATEGORIA] ([ID], [NOME])
VALUES (NEWID(), 'Móveis');

-- Insert 9
INSERT INTO [dbo].[CATEGORIA] ([ID], [NOME])
VALUES (NEWID(), 'Jogos');

-- Insert 10
INSERT INTO [dbo].[CATEGORIA] ([ID], [NOME])
VALUES (NEWID(), 'Ferramentas');

-- Geração de 5 inserts para a tabela FORNECEDOR

-- Insert 1
INSERT INTO [dbo].[FORNECEDOR] ([ID], [RAZAOSOCIAL], [CNPJ])
VALUES (NEWID(), 'Empresa A LTDA', '12345678901234');

-- Insert 2
INSERT INTO [dbo].[FORNECEDOR] ([ID], [RAZAOSOCIAL], [CNPJ])
VALUES (NEWID(), 'Empresa B S/A', '56789012345678');

-- Insert 3
INSERT INTO [dbo].[FORNECEDOR] ([ID], [RAZAOSOCIAL], [CNPJ])
VALUES (NEWID(), 'Distribuidora C', '90123456789012');

-- Insert 4
INSERT INTO [dbo].[FORNECEDOR] ([ID], [RAZAOSOCIAL], [CNPJ])
VALUES (NEWID(), 'Indústria XYZ', '34567890123456');

-- Insert 5
INSERT INTO [dbo].[FORNECEDOR] ([ID], [RAZAOSOCIAL], [CNPJ])
VALUES (NEWID(), 'Comércio de Produtos LTDA', '78901234567890');

SELECT * FROM CATEGORIA;
SELECT * FROM FORNECEDOR;