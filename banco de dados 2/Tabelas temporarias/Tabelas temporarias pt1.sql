-- tabela temporaruias

-- cria uma tabela temporaria LOCAL

create table #temporaria
(
	ID int primary key,
	descricao varchar(30)
)

--inserindo dados 

insert into #temporaria values
(1, 'controle'),
(2, 'Sofá');

select * from #temporaria


--Usando tabelas temporarias em Stored Procedures

use funcionarios

create or alter procedure sp_atualizaSalario
as begin
	select * into #TabTemp from funcionarios -- cria uma tabela temporaria com todas as informações da tabela funcionarios
	-- atualizar o salario da seguinte forma: cada ano de vida irá se transforma em 1% de aumento no salario do funcionario
	update #TabTemp set func_salario = func_salario *
	cast( '1.' + cast(datediff ( year , func_dataNasc , getdate()) AS varchar) as decimal(8,2))
	--remover a coluna gerente_ID da tabela temporaria
	alter table #TabTemp
	drop column gerente_id
	--Visualizando a tabela
	select * from #TabTemp
end

exec sp_atualizaSalario


--tabela temporaria GLOBAL
drop table #temporaria
--criando uma global 
create table ##tempGlobal (
	id int primary key,
	descricao varchar(50)
)

--inserindo dados na tabela 
insert into ##tempGlobal values
(1, 'mesa'),
(2, 'quarto'),
(3, 'Comida');

select * from ##tempGlobal