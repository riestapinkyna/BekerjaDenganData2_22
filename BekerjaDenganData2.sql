CREATE DATABASE BekerjaDenganData

USE BekerjaDenganData


CREATE TABLE Karyawan
(
nik				varchar(16)			NOT NULL PRIMARY KEY,
nama_karyawan	nvarchar(50)		NOT NULL,
jabatan			varchar(5)			NOT NULL
)

CREATE TABLE Jabatan
(
id_jabatan			varchar(5)			NOT NULL PRIMARY KEY,
nama_jabatan		varchar(50)			NOT NULL
)

--input jabatan
CREATE PROCEDURE [dbo].[sp_InputJabatan]
	@id_jabatan varchar(5),
	@nama_jabatan varchar(50)
AS
BEGIN
	INSERT INTO Jabatan(id_jabatan, nama_jabatan)
	VALUES
	(	@id_jabatan,
		@nama_jabatan
	)
END

--input karyawan
CREATE PROCEDURE [dbo].[sp_InputKaryawan]
	@nik varchar (16),
	@nama_karyawan varchar(100),
	@jabatan varchar (5)
AS
BEGIN
	INSERT INTO Karyawan(nik, nama_karyawan, jabatan)
	VALUES
	(	@nik,
		@nama_karyawan,
		@jabatan
	)
END

--update karyawan
CREATE PROCEDURE [dbo].[sp_UpdateKaryawan]
	@nik varchar (16),
	@nama_karyawan varchar(100),
	@jabatan varchar (5)
AS
BEGIN
	UPDATE Karyawan
	SET nik = @nik,
	nama_karyawan=@nama_karyawan,
	jabatan=@jabatan
	WHERE nik=@nik;
END
	
--hapus karyawan
CREATE PROCEDURE [dbo].[sp_HapusKaryawan]
	@nik varchar (16)
AS
BEGIN
	DELETE FROM Karyawan 
	WHERE nik=@nik
END

--update jabatan
CREATE PROCEDURE [dbo].[sp_UpdateJabatan]
	@id varchar (5),
	@nama varchar (50)
AS
BEGIN
	UPDATE Jabatan
	SET id_jabatan = @id,
	nama_jabatan = @nama
	WHERE id_jabatan=@id;
END

--hapus jabatan
CREATE PROCEDURE [dbo].[sp_HapusJabatan]
	@id varchar (16)
AS
BEGIN
	DELETE FROM Jabatan 
	WHERE id_jabatan=@id
END

SELECT * FROM Karyawan
