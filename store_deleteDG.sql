USE [DBQuanLyThuVien]
GO
/****** Object:  StoredProcedure [dbo].[deleteDG]    Script Date: 05/31/2020 13:51:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[deleteDG]
@idDG int,
@outputresult int OUTPUT
as
begin
	declare @idCheck int
	set @idCheck = (select MaDocGia from DOCGIA where not exists (select MaDocGia from PHIEUMUONSACH where DOCGIA.MaDocGia = PHIEUMUONSACH.MaDocGia ) )
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
