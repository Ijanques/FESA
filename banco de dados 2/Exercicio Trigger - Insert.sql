/*
	Usando o banco de dados de Comércio faça:
	1) Uma trigger de inclusão para a tabela de notaFiscal
	que não permita a inclusão de uma nota com a data de emissão
	menor que a data do sistema operacional

	2) Uma trigger de inclusão na tabela de itensNotaFiscal
	que não permita uma quantidade negativa. Junto a essa trigger
	faça uma verificação se o valor informado é igual ao
	valor do produto que está sendo inserido vezes a quantidade
	de itens inseridos

	3) Crie uma trigger para exclusão de registro na tabela
	de notaFiscal, para que toda vez que uma nota fiscal
	for excluida o sistema deverá automaticamente excluir
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
		raiserror('A data da nota fiscal não pode ser maior que a atual', 16, 1)
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