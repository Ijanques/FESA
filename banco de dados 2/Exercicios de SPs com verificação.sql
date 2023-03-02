
 --1)	Utilizando o banco de veículos, crie uma stored procedure chamada sp_ex_1 que receba como parâmetro um código de UF qualquer, e devolva em uma tabela a média dos rendimentos das pessoas agrupadas por estado civil desta UF.
create or alter procedure SP_media_de_rendimento_UFS (@UF varchar(50)) as begin
--verificar se o UF existe
		if not exists (select cod_uf from tb_estados
						where @UF = cod_uf) begin
			print 'Estado informado não existe'
			return -1
		end
	select cod_uf, avg(rendimento), cod_estado_civil from tb_clientes 
	where cod_uf = @UF
	group by cod_uf, cod_estado_civil
end

exec SP_media_de_rendimento_UFS 'sp'

--2)	Crie uma SP que permita a inclusão dos dados para uma marca, na tabela de marcas. Receba como parâmetros todos os dados da tabela.


create or alter procedure SP_insere_marca (@cod int, @marca varchar(50)) as begin
--verificar se o codigo já existe
		if exists (select cod_marca from tb_marcas
					where @cod = cod_marca)begin
			print 'o codigo informado já existe'
			return -1
		end

insert into tb_marcas values(@cod, @marca)
	--verifica se algum erro aconteceu na inclusão dos dados
	if @@ERROR != 0 begin
	print 'ocorreu um erro na inclusão de dados.'
			return -1
		end
		return 0 
end

--tentativa de inclusão
declare @ret int
exec @ret = SP_insere_marca 79, 'hiunday'

--verificação
if @ret = 0
	print 'Dados incluidos com sucesso!!!'
else
	print 'Ocorreu erro!!!!!'

select * from tb_marcas


--Baseada na sp criada no exercício 2, faça uma alteração para que o código da marca seja gerado automaticamente dentro de sua SP

create or alter procedure SP_insere_marca2 (@marca varchar(50)) as begin
--verificar se o codigo já existe
insert into tb_marcas values((select max(cod_marca) from tb_marcas) + 1, @marca)
	--verifica se algum erro aconteceu na inclusão dos dados
	if @@ERROR != 0 begin
	print 'ocorreu um erro na inclusão de dados.'
			return -1
		end
		return 0 
end

--tentativa de inclusão
declare @ret int
exec @ret = SP_insere_marca2 'scania'

--verificação
if @ret = 0
	print 'Dados incluidos com sucesso!!!'
else
	print 'Ocorreu erro!!!!!'

select * from tb_marcas
