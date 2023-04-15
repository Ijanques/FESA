-- criando funções que retornam tabelas

--tipo 1 (não é definido uma estrutura)

create function fnc_RetornaTabelaFuncionarios
(
		@p_salario_inicial decimal(10,2),
		@p_salario_final decimal (10,2)
)
returns table
as 
	return
	(
		select * from funcionarios
		where func_salario between @p_salario_inicial and @p_salario_final
	)



--chamada
select fnc.func_nome, s.setor_nome
from dbo.fnc_RetornaTabelaFuncionarios(1000,5000) fnc
inner join setores s on s.setor_id and fnc.setor_id

--tipo 2 (estrutura da tabela definida)

create or alter function fnc_func_setor (@setor int, @aumento decimal (10,2))
returns @tbl_func_setor table
(
	func_id int,
	func_name varchar(50),
	setor_id int,
	setor_nome varchar(50),
	func_salario decimal(10,2)
)
as
begin
	insert @tbl_func_setor
		select funcionarios.func_id, funcionarios.func_nome, setores.setor_id, setores.setor_nome, func_salario
		from funcionarios
		inner join setores on setores.setor_id = funcionarios.setor_id
		where funcionarios.setor_id = @setor
	--aplicar um aumento na tabela criada
	update @tbl_func_setor set func_salario *= 1 + (@aumento /100)
	return
end

--chamda
select *
from dbo.fnc_func_setor(1,10)