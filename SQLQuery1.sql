create database telaLogin
go

use telaLogin
go

create table Usuario(
	ID int identity primary key,
	nome varchar(200) not null,
	senha varchar(MAX) not null
);
go

insert Usuario values ('Carlos', '0D5399508427CE79556CDA71918020C1E8D15B53')