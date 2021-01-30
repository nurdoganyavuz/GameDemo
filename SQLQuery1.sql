--Select
--ANSII
select * from Customers

select ContactName, CompanyName, City from Customers

Select ContactName Adi, CompanyName SirketAdi, City Sehir from Customers 

Select * from Customers where City = 'London'

Select * from Customers where City = 'Berlin'

select * from Products

Select * from Products where CategoryID = 1 

Select * from Products where CategoryID = 1 or CategoryID = 3

Select * from Products where CategoryID = 1 and UnitPrice >= 10

Select * from Products where CategoryID = 1 and UnitPrice <> 10 --UnitPrice'ı 10'dan farklı olanları

select * from Products order by ProductName

select * from Products order by CategoryID

select * from Products order by CategoryID, ProductName

select * from Products order by UnitPrice

select * from  Products order by UnitPrice asc  --ascending(artan degerlere göre sıralar) bunu yazmasak da olur, default olarak asc'dir.

select * from  Products order by UnitPrice desc --descending (azalan)

select * from  Products where CategoryID=1 order by UnitPrice desc

select count(*) from Products --satır sayısı, kaç tane ürün oldugunu ögrendik

select count(*) from Products where CategoryID = 2

select count(*) Adet from Products where CategoryID = 2

select CategoryID from Products group by CategoryID

--select CategoryId, ProductName from Products group by CategoryId, ProductName

select CategoryID, count(*)  from Products group by CategoryID

select CategoryID, count(*) from Products group by CategoryID having count(*)<10

select CategoryID, count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10

select * from Products inner join Categories on Products.CategoryID = Categories.CategoryID

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName from Products inner join Categories on Products.CategoryID = Categories.CategoryID

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName 
from Products inner join Categories on Products.CategoryID = Categories.CategoryID where Products.UnitPrice>10

--DTO Data Transformation object

select * from Products p inner join [Order Details] od on p.ProductID = od.ProductID 

select * from Products p left join [Order Details] od on p.ProductID = od.ProductID 

select * from Customers c inner join Orders o on c.CustomerID = o.CustomerID

select * from Customers c left join Orders o on c.CustomerID = o.CustomerID

select * from Customers c left join Orders o on c.CustomerID = o.CustomerID where o.CustomerID is null

select * from Products p inner join [Order Details] od on p.ProductID = od.ProductID inner join Orders o on o.OrderID = od.OrderID


