USE [DBQuanLyThuVien]
GO
/****** Object:  StoredProcedure [dbo].[deleteSach]    Script Date: 06/02/2020 14:59:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[deleteSach]
@idSach int,
@returnvalue int OUTPUT
as
begin
	declare @idCheck int
	 set @idCheck =  (select MaSach from SACH where not exists (select MaSach from CHITIETPHIEUMUON where CHITIETPHIEUMUON.MaSach =  SACH.MaSach )and SACH.MaSach = @idSach)
	if(@idCheck <> '')
	begin
		delete from SACH where MaSach = @idSach
		set @returnvalue = 1
	end
	else
	begin
		set @returnvalue = 0
	end
end