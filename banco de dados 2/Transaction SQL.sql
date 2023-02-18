use funcionarios
/*
- Declaração de variáveis
- Atribuição de dados
- Desvio condicional
- Laço de repetição
*/


--Declaração
declare @salario decimal(10,3)
declare @media decimal (10,3)


--Atribuição 

set @salario = 3400.87
set @salario = (select sum(func_salario)
				from funcionarios)
				

select @salario = sum(func_salario),
	   @media = avg(func_salario)
from funcionarios
print @salario
print @media


--exemplo

declare @gerente int = 3

if @gerente = 1 begin
	 select * from funcionarios where gerente_id = 1
end
else
	 select * from funcionarios where gerente_id !=1

declare @tipo varchar(30)
declare @valor decimal(10,2)
set @tipo = 'media'

if @tipo = 'media'
	 set @valor = (select avg(func_salario) from funcionarios)
else
	 set @valor = (select sum(func_salario) from funcionarios)

print 'O valor calculado é R$ ' + cast(@valor, varchar(20))

-- Laço de repetição

declare @contador int = 1

while (@contador <=10)begin
		print 'Número: ' + cast(@contador as varchar(2))
		set @contador = @contador + 1
end

--Uso do case
select f.func_nome, f.func_salario,
	   case f.gerente_id
			when 1 then 'Gerente 1'
			when 2 then 'Gerente 2'
			when 3 then 'Gerente 3'
			else 'Inexistente'
		end as tipo_gerente
from funcionarios f

select f.func_nome, f.func_salario,
		case
			when f.func_salario < 1000 then 'Ganha pouco'
			when f.func_salario < 2000 then 'Ganha bem'
			else 'Milionario'
		end as tipo_salario
from funcionarios f