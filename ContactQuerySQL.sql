begin --Initial Query
create Database ContactBook;
Use ContactBook
end

begin --Query Users
create table Tbl_Users(
IdUser int primary key identity(1,1),
Name nvarchar(100) not null,
LastName nvarchar(100) not null,
UserName nvarchar(50) not null,
Password nvarchar(30) not null
)

create procedure SP_LoginUser
@UserName nvarchar(50),
@Password nvarchar(30)
as
select * from Tbl_Users where UserName = @UserName and Password=@Password


exec SP_LoginUser 'JPerez','123Abc'

create procedure SP_RegisterUser
@Name nvarchar(100),
@LastName nvarchar(100),
@UserName nvarchar(50),
@Password nvarchar(30)
as
insert into Tbl_Users values(@Name,@LastName,@UserName,@Password)

end

begin --Query Contact

create table Tbl_Contact(
IdContact int primary key identity(1,1),
ContactName nvarchar(100) not null,
LastName nvarchar(100) not null,
Adress nvarchar(150) not null,
PersonalPhone nvarchar(30) not null,
WorkPhone nvarchar(30) not null,
IdUser int foreign key references Tbl_Users(IdUser)
)

create procedure SP_ListContact 
@IdUser int
as
select cs.IdContact as Code, cs.ContactName, cs.LastName, cs.Adress, cs.PersonalPhone, cs.WorkPhone from Tbl_Contact as cs
inner join Tbl_Users as us
on cs.IdUser = us.IdUser
where us.IdUser = @IdUser

create procedure SP_ListContactById
@IdContact int
as
select cs.IdContact as Code, cs.ContactName, cs.LastName, cs.Adress, cs.PersonalPhone, cs.WorkPhone from Tbl_Contact as cs
inner join Tbl_Users as us
on cs.IdUser = us.IdUser
where cs.IdContact=@IdContact

create procedure SP_InsertContact
@ContactName nvarchar(100),
@LastName nvarchar(100),
@Adress nvarchar(150),
@PersonalPhone nvarchar(30),
@WorkPhone nvarchar(30),
@IdUser int
as
insert into Tbl_Contact values(@ContactName,@LastName,@Adress,@PersonalPhone,@WorkPhone,@IdUser)

create procedure SP_UpdateContact
@IdContact int,
@ContactName nvarchar(100),
@LastName nvarchar(100),
@Adress nvarchar(150),
@PersonalPhone nvarchar(30),
@WorkPhone nvarchar(30)
as
Update Tbl_Contact set ContactName = @ContactName,LastName=@LastName,Adress=@Adress,PersonalPhone=@PersonalPhone,WorkPhone=@WorkPhone
where IdContact = @IdContact
end