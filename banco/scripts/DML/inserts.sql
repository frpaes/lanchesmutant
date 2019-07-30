




INSERT INTO TB_LANCHE(LANCHE)
VALUES('X-Bacon'),
	  ('X-Burger'),
	  ('X-Egg'),
	  ('X-Egg Bacon')
	
INSERT INTO TB_INGREDIENTE(INGREDIENTE, VALOR)
VALUES  ('Alface',0.40),
		('Bacon',2.00),
		('Hamb�rguer de carne',3.00),
		('Ovo',0.80),
		('Queijo',1.50)

DECLARE @IDENTITY INT
INSERT INTO TB_TIPO_DOMINIO(TIPO_DOMINIO)
VALUES('Promocao')
SET @IDENTITY = @@IDENTITY

INSERT INTO TB_DOMINIO(DOMINIO, DESC_DOMINIO, COD_TIPO_DOMINO, COD_ENUM)
VALUES  ('Light','lanche com alface e n�o contem bacon, 10% de desconto.',@IDENTITY,1),
		('Muita carne','A cada 3 por��es de carne pague somente 2 por��es. Se o lanche tiver 6 por��es, pague 4. Assim por diante',@IDENTITY,2),
		('Muito queijo','A cada 3 por��es de queijo pague somente 2 por��es. Se o lanche tiver 6 por��es, pague 4. Assim por diante',@IDENTITY,3),
		('Infla��o','Os valore n�o altera',@IDENTITY,4)


INSERT INTO [TB_LANCHE_INGREDIENTE] (COD_LANCHE, COD_INGREDIENTE)
VALUES (1,2),
	   (1,3),
	   (1,5),
	   (2,3),
	   (2,5),
	   (3,4),
	   (3,3),
	   (3,5),
	   (4,2),
	   (4,4),
	   (4,3),
	   (4,5)
