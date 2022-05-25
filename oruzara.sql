create database oruzarnica
use oruzarnica



create table Puska(
id INT IDENTITY(1,1) PRIMARY KEY,
ime NVARCHAR(30),
sifra NVARCHAR(30),
datum_uvoza date,
kapacitet_sanzera int,
skladiste_id INT FOREIGN KEY REFERENCES Skladiste(id),
metak INT FOREIGN KEY REFERENCES Metkovi(id), 

)

create table Skladiste(
id INT IDENTITY(1,1) PRIMARY KEY,
redni_broj int
)

create table Metkovi(
id INT IDENTITY(1,1) PRIMARY KEY,
vrsta NVARCHAR(30),
)
drop table PUska
drop table Metkovi
drop table Skladiste

insert into skladiste values(34)
insert into skladiste values(44)
insert into skladiste values(57)
insert into skladiste values(62)
insert into skladiste values(31)
insert into skladiste values(17)
insert into skladiste values(00)
insert into skladiste values(28)
insert into skladiste values(99)

insert into Metkovi values('5.56')
insert into Metkovi values('7.62')
insert into Metkovi values('9mm')
insert into Metkovi values('.45acp')
insert into Metkovi values('12g')

INSERT INTO Puska VALUES('Kalasnjikov', 'AK-47','2022-2-2', 30, 1, 2)
INSERT INTO Puska VALUES('Arkticki Snajper', 'AWP','2022-2-2', 7, 2, 2)
INSERT INTO Puska VALUES('Rucni Kalasnjikov', 'AK-74u','2022-5-2', 25, 3, 4)
INSERT INTO Puska VALUES('Emara', 'M4','2022-1-3', 30, 1, 1)
INSERT INTO Puska VALUES('Hekler', 'MP5','2021-1-2', 20, 6, 3)
INSERT INTO Puska VALUES('Glok', 'Glock-18','1977-2-2', 12, 7, 3)
INSERT INTO Puska VALUES('Buldog', 'SGA','2022-2-2', 12, 3, 5)
INSERT INTO Puska VALUES('Bereta', 'M92','2020-1-2', 12, 2, 3)

GO
Create PROC dbo.puska_store
@ime nvarchar(50),
@sifra nvarchar(100)
AS
SET LOCK_TIMEOUT 3000;
BEGIN TRY
	IF EXISTS(SELECT TOP 1 ime FROM puska
	WHERE ime = @ime and sifra=@sifra)
	Begin
	RETURN 0
	end
	RETURN 1
END TRY
BEGIN CATCH
	RETURN @@error;
END CATCH
GO

GO
CREATE PROC puska_Insert
@ime nvarchar(50),
@sifra nvarchar(100)
AS
SET LOCK_TIMEOUT 3000;
BEGIN TRY
IF EXISTS (SELECT TOP 1 ime  FROM puska
	WHERE ime = @ime)
	Return 1
	else
	Insert Into Puska(ime,sifra)
	Values(@ime,@sifra)
		RETURN 0;
END TRY
	
BEGIN CATCH
	RETURN @@ERROR;
END CATCH
GO
/**/
GO
Create PROC puskaupdate
@ime nvarchar(50),
@sifra nvarchar(100)
AS
SET LOCK_TIMEOUT 3000;

BEGIN TRY
	IF EXISTS (SELECT TOP 1 ime FROM puska
	WHERE ime = @ime  )

	BEGIN
	
	Update Puska  Set sifra = @sifra  where ime = @ime 
		RETURN 0;
	END
	RETURN -1;
END TRY
BEGIN CATCH
	RETURN @@ERROR;
END CATCH
GO
/**/
GO
Create Proc puska_Delete
@ime nvarchar(100)
as
Begin TRY
Delete from puska where ime = @ime
RETURN 0
END TRY
BEGIN CATCH
	RETURN @@ERROR;
END CATCH
GO
/**/
go
Create Proc Sve_puske_Broj
as
select count(ime) from puska
go
/**/
go
execute puska_Insert'Desert Eagle', 'deagle'
go
/**/

select * from puska




select ime,sifra,datum_uvoza,kapacitet_sanzera,metkovi.vrsta from puska join metkovi on puska.metak = Metkovi.id


