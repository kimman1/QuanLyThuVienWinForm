USE [DBQuanLyThuVien]
GO
/****** Object:  StoredProcedure [dbo].[deletePM]    Script Date: 06/02/2020 15:14:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[deletePM]
@idPM int,
@outputresult int OUTPUT
as
begin
	declare @idCheck int
	set @idCheck = (select MaPhieuMuon from PHIEUMUONSACH where not exists (select MaPhieuMuon from CHITIETPHIEUMUON where CHITIETPHIEUMUON.MaPhieuMuon = PHIEUMUONSACH.MaPhieuMuon)and PHIEUMUONSACH.MaPhieuMuon = @idPM )
	if(@idCheck <> '')
	begin
		delete from PHIEUMUONSACH where MaPhieuMuon = @idPM
		set @outputresult = 1
	end
	else
	begin
		set @outputresult = 0
	end
	
	
end
