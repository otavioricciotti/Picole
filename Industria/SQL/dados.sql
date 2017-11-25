insert into produto (id_produto, id_tipo_produto, id_medida, id_receita_ativa, id_lista_ativa, descricao, cx_fechada) values
(1, 1, 1, 1, 1, 'PICOLÉ DE MAÇÃ', 50),
(2, 1, 1, 2, 2, 'PICOLÉ DE MORANGO', 50),
(3, 1, 1, 3, 3, 'PICOLÉ DE UVA', 50),
(4, 1, 1, 4, 4, 'PICOLÉ DE CHOCOLATE', 50),
(5, 1, 1, 5, 5, 'PICOLÉ DE BAUNILHA', 50),
(6, 1, 1, 6, 6, 'PICOLÉ DE CREME', 50),
(7, 1, 1, 7, 7, 'PICOLÉ DE LIMÃO', 50),
(8, 1, 1, 8, 8, 'PICOLÉ DE ABACAXI', 50),
(9, 1, 1, 9, 9, 'PICOLÉ DE LICHIA', 50),
(10, 2, 3, NULL, NULL, 'LEITE EM PÓ', NULL),
(11, 2, 1, NULL, NULL, 'PALITO DE PICOLÉ', NULL),
(12, 2, 1, NULL, NULL, 'EMBALAGEM', NULL),
(13, 2, 2, NULL, NULL, 'AROMATIZANTE', NULL),
(14, 2, 3, NULL, NULL, 'GORDURA VEGETAL', NULL),
(15, 2, 2, NULL, NULL, 'XAROPE DE GLICOSE', NULL),
(16, 2, 3, NULL, NULL, 'EMULSIFICANTE', NULL),
(17, 2, 3, NULL, NULL, 'AÇUCAR', NULL),
(18, 2, 2, NULL, NULL, 'CORANTE MARROM', NULL),
(19, 2, 2, NULL, NULL, 'CORANTE ROXO', NULL),
(20, 2, 2, NULL, NULL, 'CORANTE AMARELO', NULL),
(21, 2, 2, NULL, NULL, 'CORANTE VERMELHO', NULL),
(22, 2, 2, NULL, NULL, 'CORANTE BRANCO', NULL),
(23, 2, 2, NULL, NULL, 'EXTRATO SABOR MORANGO', NULL),
(24, 2, 2, NULL, NULL, 'EXTRATO SABOR UVA', NULL),
(25, 2, 2, NULL, NULL, 'EXTRATO SABOR MAÇA', NULL),
(26, 2, 2, NULL, NULL, 'EXTRATO SABOR CHOCOLATE', NULL),
(27, 2, 2, NULL, NULL, 'EXTRATO SABOR BAUNILHA', NULL),
(28, 2, 2, NULL, NULL, 'EXTRATO SABOR LIMÃO', NULL),
(29, 2, 2, NULL, NULL, 'EXTRATO SABOR ABACAXI', NULL),
(30, 2, 2, NULL, NULL, 'EXTRATO SABOR LICHIA', NULL),
(31, 2, 2, NULL, NULL, 'EXTRATO SABOR CREME', NULL),
(32, 2, 2, NULL, NULL, 'ÁGUA POTÁVEL', NULL)
go

insert into def_tipo_produto (id_tipo_produto, descricao) values
(1, 'Produto acabado'),
(2, 'Matéria prima')
go

insert into medida (id_medida, descricao) values
(1, 'Peça'),
(2, 'Litro'),
(3, 'Kilograma'),
go

insert into produto_estoque (id_produto, estoque) values
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

insert into produto_lista (id_lista, id_produto) values
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5),
(6, 6),
(7, 7),
(8, 8),
(9, 9)
go

insert into produto_lista_item (id_lista, id_produto, quantidade) values
(1, 11, 1),
(1, 12, 1),
(1, 13, 0,005),
(1, 14, 0,01),
(1, 15, 0,01),
(1, 16, 0,005),
(1, 17, 0,015),
(1, 20, 0,02),
(1, 25, 0,005),
(1, 32, 0,03),
(2, 10, 0,02),
(2, 11, 1),
(2, 12, 1),
(2, 13, 0,005),
(2, 14, 0,01),
(2, 15, 0,01),
(2, 16, 0,005),
(2, 17, 0,015),
(2, 21, 0,02),
(2, 23, 0,005),
(2, 32, 0,03),
(3, 11, 1),
(3, 12, 1),
(3, 13, 0,005),
(3, 14, 0,01),
(3, 15, 0,01),
(3, 16, 0,005),
(3, 17, 0,015),
(3, 19, 0,02),
(3, 24, 0,005),
(3, 32, 0,03),
(4, 10, 0,02),
(4, 11, 1),
(4, 12, 1),
(4, 13, 0,005),
(4, 14, 0,01),
(4, 15, 0,01),
(4, 16, 0,005),
(4, 17, 0,015),
(4, 18, 0,02),
(4, 26, 0,005),
(4, 32, 0,03),
(5, 10, 0,02),
(5, 11, 1),
(5, 12, 1),
(5, 13, 0,005),
(5, 14, 0,01),
(5, 15, 0,01),
(5, 16, 0,005),
(5, 17, 0,015),
(5, 22, 0,02),
(5, 27, 0,005),
(5, 32, 0,03),
(6, 10, 0,02),
(6, 11, 1),
(6, 12, 1),
(6, 13, 0,005),
(6, 14, 0,01),
(6, 15, 0,01),
(6, 16, 0,005),
(6, 17, 0,015),
(6, 22, 0,02),
(6, 31, 0,005),
(6, 32, 0,03),
(7, 11, 1),
(7, 12, 1),
(7, 13, 0,005),
(7, 14, 0,01),
(7, 15, 0,01),
(7, 16, 0,005),
(7, 17, 0,015),
(7, 22, 0,02),
(7, 28, 0,005),
(7, 32, 0,03),
(8, 11, 1),
(8, 12, 1),
(8, 13, 0,005),
(8, 14, 0,01),
(8, 15, 0,01),
(8, 16, 0,005),
(8, 17, 0,015),
(8, 20, 0,02),
(8, 29, 0,005),
(8, 32, 0,03),
(9, 11, 1),
(9, 12, 1),
(9, 13, 0,005),
(9, 14, 0,01),
(9, 15, 0,01),
(9, 16, 0,005),
(9, 17, 0,015),
(9, 22, 0,02),
(9, 30, 0,005),
(9, 32, 0,03)
go

insert into receita (id_receita, id_produto, descricao) values
(1, 1, 'RECEITA DE PICOLÉ DE MAÇÃ I'),
(2, 2, 'RECEITA DE PICOLÉ DE MORANGO I'),
(3, 3, 'RECEITA DE PICOLÉ DE UVA I'),
(4, 4, 'RECEITA DE PICOLÉ DE CHOCOLATE I'),
(5, 5, 'RECEITA DE PICOLÉ DE BAUNILHA I'),
(6, 6, 'RECEITA DE PICOLÉ DE CREME I'),
(7, 7, 'RECEITA DE PICOLÉ DE LIMÃO I'),
(8, 8, 'RECEITA DE PICOLÉ DE ABACAXI I'),
(9, 9, 'RECEITA DE PICOLÉ DE LICHIA I'),
go

insert into receita_fase (id_receita, id_fase, sequencia) values
(1, 1, 1),
(1, 2, 2),
(1, 3, 3),
(1, 4, 4),
(2, 1, 1),
(2, 2, 2),
(2, 3, 3),
(2, 4, 4),
(3, 1, 1),
(3, 2, 2),
(3, 3, 3),
(3, 4, 4),
(4, 1, 1),
(4, 2, 2),
(4, 3, 3),
(4, 4, 4),
(5, 1, 1),
(5, 2, 2),
(5, 3, 3),
(5, 4, 4),
(6, 1, 1),
(6, 2, 2),
(6, 3, 3),
(6, 4, 4),
(7, 1, 1),
(7, 2, 2),
(7, 3, 3),
(7, 4, 4),
(8, 1, 1),
(8, 2, 2),
(8, 3, 3),
(8, 4, 4),
(9, 1, 1),
(9, 2, 2),
(9, 3, 3),
(9, 4, 4)
go

isnert into fase (id_fase, descricao) values
(1, 'Separação'),
(2, 'Mescla'),
(3, 'Refrigeramento'),
(4, 'Embrulho')
go

isnert into def_status_ordem_fase (id_status_ordem_fase, descricao) values
(1, 'Pronto'),
(2, 'Em andamento'),
(3, 'Finalizado')
go

insert into ordem (id_ordem, qtde_solicitada, id_produto, id_status, qtde_produzida) values
(1, 50, 1, 1, 50),
(2, 50, 2, 1, 50)
go

insert into ordem_fase (id_fase, id_ordem, id_status_ordem_fase) values
(1, 1, 3),
(2, 1, 3),
(3, 1, 3),
(4, 1, 3),
(1, 2, 3),
(2, 2, 3),
(3, 2, 3),
(4, 2, 3)
go

insert into def_status_ordem_fase (id_status_ordem, descricao) values
(1, 'Pronto'),
(2, 'Em andamento'),
(3, 'Finalizado')
go

insert into pedido (id_pedido, quantidade_total, valor_total, id_status_pedido, id_tipo_pedido, id_entidade) values
(1, 100, 100, 3, 2, 2),
(2, 50, 50, 3, 1, 1)
go

insert into pedido_item (id_pedido, id_produto, quantidade, valor_unitario) values
(1, 1, 50, 1),
(1, 2, 50, 1),
(2, 10, 20, 2),
(2, 11, 1000, 0,05),
(2, 12, 1000, 0,09),
(2, 13, 5, 5),
(2, 14, 10, 2),
(2, 15, 10, 5),
(2, 16, 5, 1),
(2, 17, 15, 1),
(2, 18, 20, 1),
(2, 19, 20, 1),
(2, 20, 20, 1),
(2, 21, 20, 1),
(2, 22, 20, 1),
(2, 23, 5, 4),
(2, 24, 5, 4),
(2, 25, 5, 4),
(2, 26, 5, 4),
(2, 27, 5, 4),
(2, 28, 5, 4),
(2, 29, 5, 4),
(2, 30, 5, 4),
(2, 31, 5, 4),
(2, 32, 30, 0,3)
go

insert into def_tipo_pedido (id_tipo_pedido, descricao) values
(1, 'Entrada'),
(2, 'Saída')
go

insert into def_status_pedido (id_status_pedido, descricao) values
(0, 'Digitado'),
(1, 'Aprovado'),
(2, 'Produzido'),
(3, 'Faturado')

insert into entidade (id_entidade, razao_social, fantasia, data_cadastro, cpf_cnpj, id_tipo_entidade) values
(1, 'FAZENDA SÃO PEDRO', 'SÃO PEDRO', getdate(), 4532527000118, 1),
(2, 'ZÉ DO CÔCO REPRESENTAÇÕES LTDA', 'ZÉ DO CÔCO', getdate(), 4623990100131, 2)
go

insert into def_tipo_entidade (id_tipo_entidade, descricao) values
(1, 'Fornecedor'),
(2, 'Cliente')
go

insert into nota_fiscal (id_nota_fiscal, id_entidade, id_pedido
			, id_tipo_nota_fiscal, data_faturamento, data_entrega, total, total_item) values
(1, 1, 2, 1, getdate(), dateadd(day, 1, getdate()), 574,4, 2240),
(2, 2, 1, 2, getdate(), dateadd(day, 3, getdate()), 100, 100)
go

insert into def_tipo_nota_fiscal (id_tipo_nota_fiscal, descricao) values
(1, 'Entrada'),
(2, 'Saída')
go

insert into nota_fiscal_item (id_nota_fiscal, id_produto, preco_unitario, quantidade) values
(1, 10, 2, 20),
(1, 11, 0,05, 1000),
(1, 12, 0,09, 1000),
(1, 13, 5, 5),
(1, 14, 2, 10),
(1, 15, 5, 10),
(1, 16, 1, 5),
(1, 17, 1, 15),
(1, 18, 1, 20),
(1, 19, 1, 20),
(1, 20, 1, 20),
(1, 21, 1, 20),
(1, 22, 1, 20),
(1, 23, 4, 5),
(1, 24, 4, 5),
(1, 25, 4, 5),
(1, 26, 4, 5),
(1, 27, 4, 5),
(1, 28, 4, 5),
(1, 29, 4, 5),
(1, 30, 4, 5),
(1, 31, 4, 5),
(1, 32, 0,3, 30),
(2, 1, 1, 50),
(2, 2, 1, 50)
go



