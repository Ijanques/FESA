
 --1)	Utilizando o banco de ve�culos, crie uma stored procedure chamada sp_ex_1 que receba como par�metro um c�digo de UF qualquer, e devolva em uma tabela a m�dia dos rendimentos das pessoas agrupadas por estado civil desta UF.
create or alter procedure SP_media_de_rendimento_UFS (@UF varchar(50)) as begin
--verificar se o UF existe
		if not exists (select cod_uf from tb_estados
						where @UF = cod_uf) begin
			print 'Estado informado n�o existe'
			return -1
		end
	select cod_uf, avg(rendimento), cod_estado_civil from tb_clientes 
	where cod_uf = @UF
	group by cod_uf, cod_estado_civil
end

exec SP_media_de_rendimento_UFS 'sp'

--2)	Crie uma SP que permita a inclus�o dos dados para uma marca, na tabela de marcas. Receba como par�metros todos os dados da tabela.


create or alter procedure SP_insere_marca (@cod int, @marca varchar(50)) as begin
--verificar se o codigo j� existe
		if exists (select cod_marca from tb_marcas
					where @cod = cod_marca)begin
			print 'o codigo informado j� existe'
			return -1
		end

insert into tb_marcas values(@cod, @marca)
	--verifica se algum erro aconteceu na inclus�o dos dados
	if @@ERROR != 0 begin
	print 'ocorreu um erro na inclus�o de dados.'
			return -1
		end
		return 0 
end

--tentativa de inclus�o
declare @ret int
exec @ret = SP_insere_marca 79, 'hiunday'

--verifica��o
if @ret = 0
	print 'Dados incluidos com sucesso!!!'
else
	print 'Ocorreu erro!!!!!'

select * from tb_marcas


--Baseada na sp criada no exerc�cio 2, fa�a uma altera��o para que o c�digo da marca seja gerado automaticamente dentro de sua SP

create or alter procedure SP_insere_marca2 (@marca varchar(50)) as begin
--verificar se o codigo j� existe
insert into tb_marcas values((select max(cod_marca) from tb_marcas) + 1, @marca)
	--verifica se algum erro aconteceu na inclus�o dos dados
	if @@ERROR != 0 begin
	print 'ocorreu um erro na inclus�o de dados.'
			return -1
		end
		return 0 
end

--tentativa de inclus�o
declare @ret int
exec @ret = SP_insere_marca2 'scania'

--verifica��o
if @ret = 0
	print 'Dados incluidos com sucesso!!!'
else
	print 'Ocorreu erro!!!!!'

select * from tb_marcas
