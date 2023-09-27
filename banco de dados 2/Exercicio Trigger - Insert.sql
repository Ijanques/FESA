/*
	Usando o banco de dados de Com�rcio fa�a:
	1) Uma trigger de inclus�o para a tabela de notaFiscal
	que n�o permita a inclus�o de uma nota com a data de emiss�o
	menor que a data do sistema operacional

	2) Uma trigger de inclus�o na tabela de itensNotaFiscal
	que n�o permita uma quantidade negativa. Junto a essa trigger
	fa�a uma verifica��o se o valor informado � igual ao
	valor do produto que est� sendo inserido vezes a quantidade
	de itens inseridos

	3) Crie uma trigger para exclus�o de registro na tabela
	de notaFiscal, para que toda vez que uma nota fiscal
	for excluida o sistema dever� automaticamente excluir
	todos os itens que existem para essa nota na tabela
	de itensNotaFiscal

	4)Criar uma trigger de inclus�o baseada no resultado do exercicio 2 
	que quando um produto for vendidm a quantidade que foi 
	vendida dever� ser subtraida da quantidade em estoque do produto

	5)Criar uma trigger de exclus�o de itens de nota fiscal que,
	quando um item de nota fiscal for exclido a quantidade do produto dever� retornar para o estoque
*/
use Comercio
--EX1 Trigger inserir nota fiscal
create or alter trigger trg_InsereNota on notaFiscal
for insert as 
begin
	declare @data smalldatetime
	select @data = dataemissao from inserted
	if @data <> GETDATE()
	begin
		raiserror('A data da nota fiscal n�o pode ser menor que a atual', 16, 1)
		rollback transaction
	end
end

insert into notafiscal values(3, '2023-03-25', 'William')


--EX2 

create or alter trigger trg_insereItens on itensnotafiscal
for insert as 
begin
	declare @qtd int
	declare @codProduto decimal(10,2)
	declare @valor decimal(10,2)

	select @qtd = quantidade, @codProduto = codproduto, @valor = valor from inserted
	


	if @qtd < 0 
	begin
		raiserror('A quantidade n�o pode ser 0 ou menor', 14, 1)
		rollback transaction
	end
	if @valor <> ((select preco from produto where codProduto = @codProduto) * @qtd)
	begin 
		raiserror('O valor deve ser inserido corretamente', 14, 1)
		rollback transaction
	end
end
insert into itensNotaFiscal values (3, 4, 11, 27.04)
select * from produto
--ex3

create or alter trigger trg_excluiNota on notafiscal
instead of delete as
begin
	declare @codNota int = (select nrNota from deleted) 
	delete from itensNotaFiscal where nrNota = @codNota
	delete from notaFiscal where nrNota = @codNota
end

delete from notaFiscal where nrNota = 5 

--Ex4
create or alter trigger trg_insereItens on itensnotafiscal
for insert as 
begin
	declare @qtd int
	declare @codProduto decimal(10,2)
	declare @valor decimal(10,2)

	select @qtd = quantidade, @codProduto = codproduto, @valor = valor from inserted
	


	if @qtd < 0 or (@qtd > (select qtdestoque from produto where codProduto = @codProduto))
	begin
		raiserror('A quantidade n�o pode ser 0 ou menor', 14, 1)
		rollback transaction
	end
	if @valor <> ((select preco from produto where codProduto = @codProduto) * @qtd)
	begin 
		raiserror('O valor deve ser inserido corretamente', 14, 1)
		rollback transaction
	end
	update produto
	set qtdEstoque = qtdEstoque - @qtd
	where codProduto = @codProduto
end