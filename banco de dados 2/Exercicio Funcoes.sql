/*
	crie um select que exiba o nome do funcionario, salario e a média salarial
	dos funcionarios que trabalham no mesmo setor do funcionario.
	
	fazer utilizando funções
*/

create or alter function mediaSalario(@setor_id int)
returns decimal(10,2) as 
	begin
		declare @media decimal(10,2)
		set @media = (select (sum(f.func_salario) / count(f.func_nome)) as media from funcionarios f where f.setor_id = @setor_id)
		return @media
	end



--chamada

select f.func_nome, f.func_salario, dbo.mediaSalario(f.setor_id) as media_salarial from funcionarios f

--Procedure que exibe quem está acima ou abaixo da meida do salario

create or alter procedure sp_AcimaBaixo(@tipo varchar(10)) as
begin
	if @tipo = 'acima' begin
		select f.func_nome, f.func_salario
		from funcionarios f
		where f.func_salario > dbo.mediaSalario(f.setor_id)
	end
	else begin
		select f.func_nome, f.func_salario
		from funcionarios f
		where f.func_salario < dbo.mediaSalario(f.setor_id)
	end
end


exec sp_AcimaBaixo 'acima'
	