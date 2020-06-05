USE [DBQuanLyThuVien]
GO
/****** Object:  StoredProcedure [dbo].[deleteDG]    Script Date: 06/05/2020 13:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc deleteNV
@idNV int,
@outputresult int OUTPUT
as
begin
	declare @idCheck int
	set @idCheck = (select MaNhanVien from NHANVIEN where not exists (select MaNhanVien from PHIEUMUONSACH where NHANVIEN.MaNhanVien = PHIEUMUONSACH.MaNhanVien ) and NHANVIEN.MaNhanVien = @idNV )
	if(@idCheck <> '')
	begin 
	delete from NHANVIEN where MaNhanVien = @idNV
	set @outputresult = 1
	end
	else
	begin
	set @outputresult = 0
	end
end
