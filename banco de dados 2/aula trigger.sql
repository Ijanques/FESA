--Criando uma trigger de INSERT
create trigger trg_InsereProduto on Produto
for Insert as
begin
	select * from inserted
end

--Incluindo o dado
insert into produto values(5, 'tapete', 5, 1590.00)
insert into produto values(6, 'Pacote folha sulfite', 30, 34.90)

--Alterando uma trigger para n�o permitir quantidade de produtos zerada nem pre�os zerados

create or alter trigger trg_InsereProduto on Produto
for insert as 
begin 
	declare @qtd int
	declare @preco decimal(10,2)

	--recuperando dados da tabela inserted

	select @qtd = x.qtdEstoque, @preco = x.preco
	from inserted x

	--validando 
	if @qtd = 0 or @preco = 0 begin
		--gerando um erro
		raiserror('Pre�o ou quantidade n�o podem ficar zerados', 16, 1)
		rollback transaction -- desfaz o comando	
	end
end

--testando inser��o
insert into produto values (7, 'Grampeador', 10, 0)

-- usando instead if 
-- o comando que disparou a trigger dever� ser eecutado dentro da trigger
create or alter trigger trg_InsereProduto on produto
instead of insert as
begin 

	declare @qtd int
	declare @preco decimal(10,2)

	--recuperando dados da tabela inserted

	select @qtd = x.qtdEstoque, @preco = x.preco
	from inserted x

	select @qtd = x.qtdEstoque, @preco = x.preco
	from inserted x

	--validando 
	if @qtd = 0 or @preco = 0 begin
		--gerando um erro
		raiserror('Pre�o ou quantidade n�o podem ficar zerados', 16, 1)
		rollback transaction -- desfaz o comando	
		end
end

--testando

insert into produto values(9, 'canet�o preto', 8 , 17.75)

select * from produto


--criando trigger para mostrar os itens que est�o sendo deletados
create or alter trigger tg_DeleteProduto on produto
for delete as
begin
select* from deleted
end

delete from produto where codProduto = 2



