/*
crie uma trigger trg_ExcluiProduto que não permita que um produto que possua alguma unidade em estoque, seja excluida
faça a solução usando a tratativa FOR e outra com o instead of
*/
use Comercio
create or alter trigger trg_ExcluiProduto on produto
for delete as
begin
	declare @qtd int
	select @qtd = qtdEstoque from deleted
	if @qtd <> 0 begin
		raiserror('O item que deseja deletar não pode ter nenhuma unidade em estoque', 16, 1)
		rollback transaction
	end
end

delete produto where codProduto = 3

select * from produto

create or alter trigger trg_excluiProduto on produto
instead of delete as
begin
	declare @qtd int
	select @qtd = qtdEstoque from deleted
	if @qtd <> 0 begin
		raiserror('O item que deseja deletar não pode ter nenhuma unidade em estoque', 16, 1)
		rollback transaction
	end
	else begin
		delete produto where codProduto = (select codproduto from deleted)
	end
end
update produto set qtdEstoque = 0 where codProduto = 3

