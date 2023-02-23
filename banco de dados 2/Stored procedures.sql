--uso de Stored Procedures



--SP comum

create procedure sp_exemplo1 as 
begin
	select f.setor_id, sum(f.func_salario) as total
	from funcionarios f
	group by f.setor_id
end


--Chamada da SP
exec sp_exemplo1

select * from funcionarios


--SP com parametros
--Mostroa o total dos salarios pagos para cada setor
--Filtrando os setores ou -1 para todos

create procedure SP_exemplo2 (@numSetor INT) as
begin
	  if @numSetor = -1 
	  begin --vai listar tudo
		  select f.setor_id, sum(f.func_salario) as total
		  from funcionarios f
		  group by f.setor_id
	  end
	  else --vai listar somente o desejado
	  begin
			select @numSetor setor_id, sum(f.func_salario) as total
			from funcionarios f
			where f.setor_id = @numSetor
	  end
end

--chamada da procedure

exec SP_exemplo2 6

--SP que rece parametro e devolve um ou mais dados

create or alter procedure SP_exemplo3(@num1 int, @num2 int, @resultado decimal(10,7) output) as
begin
	set @resultado = cast(@num1 as decimal (10,3)) /@num2
end

--chamada
declare @res decimal(10,7)
exec SP_exemplo3 10, 13, @res output
print 'O resultado é: ' + cast(@res as varchar(15))

-----------------
--Sp que devolve vários valores de output
create or alter procedure SP_exemplo4(
				@num1 decimal(10,2),
				@num2 decimal(10,2),
				@soma decimal (10,2) output,
				@sub decimal (10,2) output,
				@div decimal (10,2) output,
				@mult decimal (10,2) output) as
begin
	set @soma = @num1 + @num2
	set @sub = @num1 - @num2
	set @div = @num1 / @num2
	set @mult = @num1 * @num2
end


-- chamada
declare @soma decimal (10,7)
declare @mult decimal (10,7)
declare @sub decimal (10,7)
declare @div decimal (10,7)
exec SP_exemplo4 10, 13, @soma output,
						 @sub output,
						 @div output,
						 @mult output
print 'O resultado da soma é: ' + cast(@soma as varchar(15))
print 'O resultado da subtração é: ' + cast(@sub as varchar(15))
print 'O resultado da divisão é: ' + cast(@div as varchar(15))
print 'O resultado da multiplicação é: ' + cast(@mult as varchar(15))