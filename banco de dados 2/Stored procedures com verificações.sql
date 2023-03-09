--stored procedure com verificações
--SP para inclusãoo de funcionarios com verficação do setor

create or alter procedure SP_insere_Func(
	@func_id int,
	@func_nome varchar(50),
	@gerente_id int,
	@setor_id int,
	@func_salario decimal(10,2),
	@func_dataNasc smalldatetime
) as begin
	--verifica se o setor existe
	if not exists (select setor_id from setores
					where @setor_id = @setor_id) begin
		print 'Setor informado inexistente!!!'
		return -1
	end
	
	insert into funcionarios values(
			@func_id,
			@func_nome,
			@gerente_id,
			@setor_id,
			@func_salario,
			@func_dataNasc)
		--verifica se tem erro na inclusão de dados
		if @@ERROR != 0 begin
			print 'ocorreu um erro na inclusão de dados.'
			return -1
		end
		return 0 
end

--chamada
declare @ret int 
exec @ret = SP_insere_Func 20, 'Ivan Soares', 2, 12,
			1500.87, '1972/10/22'

if @ret = 0
	print 'Dados incluidos com sucesso!!!'
else
	print 'Ocorreu erro!!!!!'

select * from funcionarios

