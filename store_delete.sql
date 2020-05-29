USE [DBQuanLyThuVien]
GO
/****** Object:  StoredProcedure [dbo].[deletePM]    Script Date: 05/29/2020 15:09:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[deletePM] 
@IdPM int
as
begin
	DECLARE @IdCheck int;
	set @IdCheck = (select MaPhieuMuon from PHIEUMUONSACH where not exists (select MaPhieuMuon from CHITIETPHIEUMUON where PHIEUMUONSACH.MaPhieuMuon =  CHITIETPHIEUMUON.MaPhieuMuon))
	if ( @IDcheck <> '' )
	begin
	delete from PHIEUMUONSACH where MaPhieuMuon = @IdPM
	end
	
end