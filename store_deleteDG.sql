USE ShopMVC
GO
/****** Object:  StoredProcedure [dbo].[deleteDG]    Script Date: 06/02/2020 15:13:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[deleteDG]
@idCustomer int,
@outputresult int OUTPUT
as
begin
	declare @idCheck int
	set @idCheck = (select CustomerID from Customer where not exists (select CustomerID from Orders where Orders.CustomerID = Customer.CustomerID ) and Customer.CustomerID = @idCustomer )
	if(@idCheck <> '')
	begin 
	delete from DOCGIA where MaDocGia = @idDG
	set @outputresult = 1
	end
	else
	begin
	set @outputresult = 0
	end
end
