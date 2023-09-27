-- uso de fun��es

--criando uma fun��o ESCALAR para somatoria de 2 n�meros

create or alter function Soma (@n1 int, @n2 int)
returns int as
	begin
	return @n1 + @n2
	end

--chamada
 
 select dbo.soma(10, 20)
 use funcionarios

 --fun��o que determina o tamanho de um varchar
 create or alter function Tamanho(@texto varchar(60))
 returns int as
	begin
		declare @size int
		set @size = len(trim(@texto))

		return @size
	end

--chamada simples

select dbo.tamanho('Faculdade')

--Chamada com v�rios parametros
select f.func_nome, dbo.tamanho(f.func_nome) as qtd 
from funcionarios 

select * from funcionarios f
where dbo.Tamanho(f.func_nome) < 7


--criar fun��o que calcula quantos funcionarios existem dentro do setor passado

create or alter function contagemFunc(@setor_id int)
returns int as
	begin
		declare @retorno int
		set @retorno = (select count(func_nome) from funcionarios
						where setor_id = @setor_id)
		return @retorno
	end

--chamada
select f.func_nome, dbo.contagemFunc(f.setor_id) qtdFuncsetor
from funcionarios f


