create table House(HouseId int identity(1,1)  , Acreage int, Address nvarchar(200), Description nvarchar(1000), Price int, Owner nvarchar(100), PhoneNumber varchar(20) constraint PK_House primary key(HouseId))
create table [User](UserId int identity(1,1), UserName varchar(100), PassWord varchar(100), Name nvarchar(100), BirthDay DateTime, Gender nvarchar(20), Email varchar(200), PhoneNumber varchar(20), Address nvarchar(200) constraint PK_User primary key(UserId)) 
create table HouseImage(HouseId int references House(HouseId), Image1 varchar(200), Image2 varchar(200), Image3 varchar(200), Image4 varchar(200), Image5 varchar(200), Image6 varchar(200), Image7 varchar(200), Image8 varchar(200), Image9 varchar(200) constraint PK_HouseImage primary key(HouseId))

Drop table HouseImage
Drop table House
Drop table [User]