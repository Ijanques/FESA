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
*/

--EX1 Trigger inserir nota fiscal
create or alter trigger trg_InsereNota on notaFiscal
for insert as 
begin
	declare @data smalldatetime
	select @data = dataemissao from inserted
	if @data > SYSDATETIME()
	begin
		raiserror('A data da nota fiscal n�o pode ser maior que a atual', 16, 1)
		rollback transaction
	end
end

insert into notafiscal values(1, '11-09-2023', 'William')


--EX2 

create or alter trigger trg_insereItens on itensnotafiscal
for insert as 
begin
	declare @qtd
end