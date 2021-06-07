

--Create database Impexium_DB;
--Go
--Use Impexium_DB;

go
If Not OBJECT_ID('Products') Is Null Begin drop Table Products End
go
Create table Products  -- select  * from Products
(
	Id UniqueIdentifier Primary key Not null,
	Name Varchar(100),
	Description varchar(500),
	price decimal(18,2),
	Quantity  int,
	CreatedDate  datetime
)

go
If Not OBJECT_ID('Users') Is Null Begin drop Table Users End
go
Create Table Users  -- select  * from Users
(
 	Id UniqueIdentifier Primary key Not null,
	Name Varchar(100),
	Password Varchar(100),
	Active bit,
	CreatedDate  datetime
)
go  

Insert Into  Users values (NEWID() , 'admin', '6f544f3e8a1d25ce5a481272a82ad87bd870884207dbb253424fde196a323350', 1, getdate() ) ---- clave.1234

go
/*
Select 'Insert into Products values (',''''+cast(id as varchar(50))+'''',',',''''+Name+'''',',',''''+Description+'''',',',price,',',Quantity,',','GetDate()',');'
FRom  Products
*/

Insert into Products values (	'F459EA58-2AF7-4D0D-94A6-6F8DC4367F7E'	,	'Xbox One'	,	'500 GB, 2 controles y 4 juegos'	,	876	,	2	,	GetDate()	);
Insert into Products values (	'A6521C2E-812E-4C3B-9EA3-7B049B190FF1'	,	'Celular'	,	'Xiaomi XTG'	,	300	,	2	,	GetDate()	);
Insert into Products values (	'3830442C-B8C7-4F30-AF3E-81C6715CB2D6'	,	'Cargador'	,	'Xiaomi XTG 5V'	,	25	,	1	,	GetDate()	);
Insert into Products values (	'65A49240-FFC5-4CD8-953C-831717127C70'	,	'Televisor'	,	'Samsung serie 5 + control inteligente'	,	829	,	2	,	GetDate()	);
Insert into Products values (	'C9C967D2-5EBC-4DA4-83A3-BCBFA49562EC'	,	'Mouse'	,	'Wireles 5.0 color black'	,	24	,	4	,	GetDate()	);
Insert into Products values (	'A90B6E49-CE65-49EB-8411-DD42182A39CD'	,	'Teclado'	,	'Genius inalambrico, color rojo-negro'	,	32	,	2	,	GetDate()	);
Insert into Products values (	'B64F021E-0B80-48B1-AA10-EA73102E4F95'	,	'Impresora Epson'	,	'L451 multifuncional'	,	346	,	4	,	GetDate()	);
Insert into Products values (	'A14D66B1-FA22-498C-BB11-FE28CA559B06'	,	'Televisor'	,	'LG 43'' modelo 2020'	,	670	,	1	,	GetDate()	);