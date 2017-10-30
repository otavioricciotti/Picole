
insert into produto values
(1, 1, 'PICOLÉ DE MAÇÃ', 1, 50),
(2, 1, 'PICOLÉ DE MORANGO', 1, 50),
(3, 1, 'PICOLÉ DE UVA', 1, 50),
(4, 1, 'PICOLÉ DE CHOCOLATE', 1, 50),
(5, 1, 'PICOLÉ DE BAUNILHA', 1, 50),
(6, 1, 'PICOLÉ DE CREME', 1, 50),
(7, 1, 'PICOLÉ DE LIMÃO', 1, 50),
(8, 1, 'PICOLÉ DE ABACAXI', 1, 50),
(9, 1, 'PICOLÉ DE LICHIA', 1, 50),
(10, 2, 'LEITE EM PÓ', 2, NULL),
(11, 2, 'PALITO DE PICOLÉ', 1, NULL),
(12, 2, 'EMBALAGEM', 1, NULL),
(13, 2, 'AROMATIZANTE', 2, NULL),
(14, 2, 'GORDURA VEGETAL', 2, NULL),
(15, 2, 'XAROPE DE GLICOSE', 2, NULL),
(16, 2, 'EMULSIFICANTE', 2, NULL),
(17, 2, 'AÇUCAR', 3, NULL),
(18, 2, 'CORANTE MARROM', 2, NULL),
(19, 2, 'CORANTE ROXO', 2, NULL),
(20, 2, 'CORANTE AMARELO', 2, NULL),
(21, 2, 'CORANTE VERMELHO', 2, NULL),
(22, 2, 'CORANTE BRANCO', 2, NULL),
(23, 2, 'EXTRATO SABOR MORANGO', 2, NULL),
(24, 2, 'EXTRATO SABOR UVA', 2, NULL),
(25, 2, 'EXTRATO SABOR MAÇA', 2, NULL),
(26, 2, 'EXTRATO SABOR CHOCOLATE', 2, NULL),
(27, 2, 'EXTRATO SABOR BAUNILHA', 2, NULL),
(28, 2, 'EXTRATO SABOR LIMÃO', 2, NULL),
(29, 2, 'EXTRATO SABOR ABACAXI', 2, NULL),
(30, 2, 'EXTRATO SABOR LICHIA', 2, NULL),
(31, 2, 'CAIXA DE PAPELÃO', 1, NULL),
(32, 2, 'EXTRATO SABOR CREME', 2, NULL)
go

insert into def_tipo_produto values
(1, 'Produto acabado'),
(2, 'Matéria prima')
go

insert into def_medida values
(1, 'Peça'),
(2, 'Litro'),
(3, 'Kilograma')
go

insert into produto_estoque values
(1, 0),
(2, 0),
(3, 0),
(4, 0),
(5, 0),
(6, 0),
(7, 0),
(8, 0),
(9, 0),
(10, 0),
(11, 0),
(12, 0),
(13, 0),
(14, 0),
(15, 0),
(16, 0),
(17, 0),
(18, 0),
(19, 0),
(20, 0),
(21, 0),
(22, 0),
(23, 0),
(24, 0),
(25, 0),
(26, 0),
(27, 0),
(28, 0),
(29, 0),
(30, 0),
(31, 0),
(32, 0)
go


insert into produto_lista values
(1, 1, 'RECEITA DE PICOLÉ DE MAÇÃ'),
(2, 2, 'RECEITA DE PICOLÉ DE MORANGO'),
(3, 3, 'RECEITA DE PICOLÉ DE UVA'),
(4, 4, 'RECEITA DE PICOLÉ DE CHOCOLATE'),
(5, 5, 'RECEITA DE PICOLÉ DE BAUNILHA'),
(6, 6, 'RECEITA DE PICOLÉ DE CREME'),
(7, 7, 'RECEITA DE PICOLÉ DE LIMÃO'),
(8, 8, 'RECEITA DE PICOLÉ DE ABACAXI'),
(9, 9, 'RECEITA DE PICOLÉ DE LICHIA')
go
