insert into SalesDetails values ('FF11', 2000, 3, 'South')
insert into SalesDetails values ('NF11', 4000, 4, 'North')
insert into SalesDetails values ('GF11', 3000, 1, 'East')
insert into SalesDetails values ('RF11', 1000, 2, 'West')
insert into SalesDetails values ('EF11', 3000, 1, 'East')
insert into SalesDetails values ('LF11', 1000, 2, 'West')

select * from SalesDetails

select Area, Sum(UnitPrice*OrderQty) as TotalSales
From SalesDetails
Group By Area

select top 1 Area, Sum(UnitPrice*OrderQty) as TotalSales
From SalesDetails
Group By Area
Order by TotalSales Desc
