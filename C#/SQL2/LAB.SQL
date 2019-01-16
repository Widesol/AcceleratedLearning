use Chinook
--select * from Artist where name LIKE  'Academy%'	;
--select Title from Album where Title LIKE '[a,e,i,o,u,y,å,ä,ö]%';

--8
--select Album as AlbumTitle, Name as ArtistName
--from Album Join Artist
--ON Artist.Name=Album.Title;

--10

--select Album as NrOfAlbums, Name as ArtistName

--select top 10 COUNT(*) as NrOfAlbums,Album.ArtistId
--from Album inner Join Artist On Album.ArtistId=Artist.ArtistId
--Group by album.ArtistId Order by NrOfAlbums DESC;   FEL

--select top 10 COUNT(*) as NrOfAlbums,artist.Name from Album inner Join Artist On Album.ArtistId=Artist.ArtistId
--Group by artist.Name Order by NrOfAlbums DESC;

--11


--select distinct Album as AlbumTitle from Album where Name='Blues' or Name='Jazz';

--15

--CREATE TABLE #CustomerWithSupport (
--    supportfirstname varchar(255),
--    supportlastname varchar(255),
--    customerfirstname varchar(255),
--    customerlastname varchar(255)
--)

--insert into #CustomerWithSupport(supportfirstname,supportlastname)
--select firstname, lastname
--from Employee

--insert into #CustomerWithSupport(customerfirstname,customerlastname)
--select firstname, lastname
--from Customer

--select*from #CustomerWithSupport;

--Alter table #CustomerWithSupport
--Add employeeid varchar(255);


--Alter table #CustomerWithSupport
--Add invoiceid varchar(255);


--insert into #CustomerWithSupport(employeeid)
--select employeeid
--from Employee

--insert into #CustomerWithSupport(invoiceid)
--select invoiceid
--from Invoice

--insert into #CustomerWithSupport(custtomerid)
--select customerid
--from Customer

--drop table #customerwithsupport

--select Customer.FirstName as customerFirstName, Customer.LastName as customerLastName, Employee.FirstName as supportFirstName, Employee.LastName as supportLastName,
--Customer.CustomerId as customerid, Employee.EmployeeId as employeeid
--into #customerwithsupport
--from customer
--join Employee
--on customerid=EmployeeId

--select * from #customerwithsupport

--16

--select concat (e1.Lastname, ' ', e1.Firstname) as person, concat (e2.Lastname, ' ', e2.Firstname) as boss
--from Employee e1
--join Employee e2
--on e1.ReportsTo=e2.EmployeeId

--17
--select  len(Email) as emailLength
--from customer
--order by emailLength desc;

--18
--select top 1 Name as Name, (Milliseconds/60000) as Minutes
--from Track
--order by Minutes desc

--19

--Alter table Customer
--Add unique (Fax)

--20
--select sum(total) as summa, YEAR (invoiceDate) as year
--from Invoice
--group by YEAR (invoicedate)
--order by year desc

--21

--select top 1 SUM(Track.milliseconds/3600000.0) as totalhours, playlist.name as name
--from Playlist
--join PlaylistTrack on
--Playlist.PlaylistId=PlaylistTrack.PlaylistId
--join Track on
--PlaylistTrack.TrackId=Track.TrackId
--group by playlist.name
--order by SUM(Track.milliseconds/3600000.0) desc

--22
--select concat (e1.Lastname, ' ', e1.Firstname) as person,
--concat (e3.Lastname, ' ', e3.Firstname) as bossesboss
--from Employee e1
--join Employee e2
--on e1.ReportsTo=e2.EmployeeId
--join Employee e3
--on e2.ReportsTo=e3.EmployeeId

--23
--Create Table AlbumWithRec as

--select Album.albumid, album.title, album.artistid
--from Album;

--3
--select Name as artistname
--from Artist
--order by name

--4
--select top 10 artistid, name
--from Artist
--order by name

--5
--select name
--from artist
--where Name like 'academy%'

--6
--select title as name
--from Album
--where Title like '_ar%'

--7
--select title
--from album
--where title like '[a,e,i,o,u,y,å,ä,ö]%'

--8
--select artist.Name as artistname ,Album.Title as albumtitle
--from Artist
--inner join Album
--on artist.ArtistId=Album.ArtistId
--order by artist.name

--10
--select top 10 artist.Name as ArtistName, Count(*) as NrOfAlbums
--from Artist
--join Album
--on Artist.ArtistId=album.ArtistId
--group by artist.name
--order by NrOfAlbums desc

--11
--select distinct Album.Title as AlbumTitle
--from Album
--join Track on
--Album.AlbumId=Track.AlbumId
--join Genre on
--Track.GenreId=Genre.GenreId
--where genre.name='Jazz' or genre.name= 'Blues';

--12




