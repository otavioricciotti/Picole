create database industria
go

use industria
go

create table def_tipo_produto (
id_tipo_produto int primary key,
descricao nvarchar(30)
)
go

create table produto_estoque (
id_produto int primary key,
estoque float
)
go

create table medida (
id_medida int primary key,
descricao nvarchar(15)
)
go

create table receita_fase (
id_receita int,
sequencia int,
id_fase int
)
go

create table receita (
id_receita int primary key,
id_produto int,
descricao nvarchar(30)
)
go

create table produto_lista (
id_lista int primary key,
id_produto int
)
go

create table produto_lista_item (
id_lista int,
id_produto int,
quantidade float,
primary key(id_lista,id_produto),
foreign key(id_lista) references produto_lista (id_lista)
)
go

create table fase (
id_fase int primary key,
descricao nvarchar(35)
)
go

create table produto (
id_produto int primary key,
id_tipo_produto int,
id_medida int,
id_receita_ativa int,
id_lista_ativa int,
descricao nvarchar(50),
cx_fechada int,
foreign key(id_tipo_produto) references def_tipo_produto (id_tipo_produto),
foreign key(id_medida) references medida (id_medida),
foreign key(id_receita_ativa) references receita (id_receita),
foreign key(id_lista_ativa) references produto_lista (id_lista)
)
go

create table pedido (
id_pedido int primary key,
quantidade_total float,
valor_total smallmoney,
id_status_pedido int,
id_tipo_pedido int,
id_entidade int
)
go

create table def_tipo_pedido (
id_tipo_pedido int primary key,
descricao nvarchar(15)
)
go

create table def_status_pedido (
id_status_pedido int primary key,
descricao nvarchar(20)
)
go

create table pedido_item (
id_pedido int,
id_produto int,
quantidade float,
valor_unitario smallmoney,
primary key(id_pedido,id_produto),
foreign key(id_pedido) references pedido (id_pedido),
foreign key(id_produto) references produto (id_produto)
)
go

create table entidade (
id_entidade int primary key,
razao_social nvarchar(60),
fantasia nvarchar(30),
data_cadastro datetime,
cpf_cnpj bigint,
id_tipo_entidade int,
login nvarchar(30),
senha nvarchar(40)
)
go

create table ordem (
id_ordem int primary key,
qtde_solicitada int,
lote nvarchar(10),
id_produto int,
id_status int,
qtde_produzida int,
foreign key(id_produto) references produto (id_produto)
)
go

create table def_status_ordem (
id_status_ordem int primary key,
descricao nvarchar(20)
)
go

create table ordem_fase (
id_fase int,
id_ordem int,
id_status_ordem_fase int,
primary key(id_fase,id_ordem),
foreign key(id_fase) references fase (id_fase),
foreign key(id_ordem) references ordem (id_ordem)
)
go

create table def_status_ordem_fase (
id_status_ordem_fase int primary key,
descricao nvarchar(15)
)

create table def_tipo_entidade (
id_tipo_entidade int primary key,
descricao nvarchar(20)
)
go

create table nota_fiscal (
id_nota_fiscal int primary key,
id_entidade int,
id_pedido int,
id_tipo_nota_fiscal int,
data_faturamento datetime,
data_entrega datetime,
total smallmoney,
total_item float,
foreign key(id_entidade) references entidade (id_entidade),
foreign key(id_pedido) references pedido (id_pedido)
)
go

create table def_tipo_nota_fiscal (
id_tipo_nota_fiscal int primary key,
descricao nvarchar(20)
)
go

create table nota_fiscal_item (
id_nota_fiscal int,
id_produto int,
preco_unitario smallmoney,
quantidade float,
primary key(id_nota_fiscal,id_produto),
foreign key(id_nota_fiscal) references nota_fiscal (id_nota_fiscal),
foreign key(id_produto) references produto (id_produto)
)
go

alter table produto_estoque add foreign key(id_produto) references produto (id_produto)
alter table receita_fase add foreign key(id_receita) references receita (id_receita)
alter table receita_fase add foreign key(id_fase) references fase (id_fase)
alter table receita add foreign key(id_produto) references produto (id_produto)
alter table produto_lista add foreign key(id_produto) references produto (id_produto)
alter table produto_lista_item add foreign key(id_produto) references produto (id_produto)
alter table pedido add foreign key(id_status_pedido) references def_status_pedido (id_status_pedido)
alter table pedido add foreign key(id_tipo_pedido) references def_tipo_pedido (id_tipo_pedido)
alter table pedido add foreign key(id_entidade) references entidade (id_entidade)
alter table entidade add foreign key(id_tipo_entidade) references def_tipo_entidade (id_tipo_entidade)
alter table ordem add foreign key(id_status) references def_status_ordem (id_status_ordem)
alter table ordem_fase add foreign key(id_status_ordem_fase) references def_status_ordem_fase (id_status_ordem_fase)
alter table nota_fiscal add foreign key(id_tipo_nota_fiscal) references def_tipo_nota_fiscal (id_tipo_nota_fiscal)
