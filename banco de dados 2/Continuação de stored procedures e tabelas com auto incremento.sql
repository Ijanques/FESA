--Continuação dos estudos sobre stored procedures
use funcionarios
select * from setores

--Exemplo de SP para inclusão de dados
--recebendo a chave primaria

create procedure SP_insere_setores(@setor_id int,
									@setor_nome varchar(50))
as begin
	
	set nocount on --desligar a contagem de registros (Esse desligamento ocorre para evitar erros durante a integração com linguagens de programação)
			       --A linguagem de programação entende a mensagem de quantas linhas foram afetadas como um retorno da função

	insert into setores values (@setor_id, @setor_nome)

	 
	if @@ERROR != 0 begin
		set nocount on --habilita a contagem
		print 'erro na inclusão dos dados'
		return -1 --ocorreu erro
	end
	else begin
		set nocount off --habilita a contagem
		return 0 --tudo certo
	end
end

--Chamada
declare @ret int
exec @ret = SP_insere_setores 11, 'TI'
if @ret = 0
	print 'Inclusão efetuada com sucesso'


--calculando a chave primaria dentro da SP

create or alter procedure SP_Insere_Setores_2(
											  @setor_nome varchar(50), @setor_id int output)
As begin
		--desligar a contagem de registros
		set nocount on

		set @setor_id = (select isnull(max(setor_id),0) + 1
								 from setores)

		insert into setores values (@setor_id, @setor_nome)

		 
		if @@ERROR != 0 begin
			set nocount on --habilita a contagem
			print 'erro na inclusão dos dados'
			return -1 --ocorreu erro
		end
		else begin
			set nocount off --habilita a contagem
			return 0 --tudo certo
		end
end

--chamada 
declare @ret int
declare @codinserido int
exec @ret = SP_Insere_Setores_2 'middle office', @codinserido output
if @ret = 0 begin
	print 'Inclusão efetuada com sucesso'
	print 'O codigo gerado foi: ' + cast(@codinserido as varchar(3))
end

select * from setores





--------------------------------------------------------------------------------------------------------------------
-- ROTINA PARA A CRIAÇÃO DE UMA TABELA COM CAMPO DE AUTO INCREMENTO	
--------------------------------------------------------------------------------------------------------------------

CREATE TABLE setores_2(
		setor_id int primary key identity(1,1),
		setor_nome varchar(50)
)

select * from setores_2






