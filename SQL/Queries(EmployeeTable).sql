insert into [Employee] values(2,'Sunil',40000,null,'B')
insert into [Employee] values(3,'Suresh',35000,3,'D')
insert into [Employee] values(4,'Ramesh',33000,4,'B')
insert into [Employee] values(5,'John',41000,1,'A')
insert into [Employee] values(6,'Mikhil',52000,7,'C')
insert into [Employee] values(7,'Nikhil',39000,6,'A')
insert into [Employee] values(8,'Mansi',28000,null,'B')
insert into [Employee] values(9,'Neha',25000,null,'C')
insert into [Employee] values(10,'Krutika',36000,5,'A')

select * from [Employee]

update Employee
Set Grade = 'D'
where Salary Between 1 and 30000

update Employee
Set Grade = 'C'
where Salary Between 31000 and 40000

update Employee
Set Grade = 'B'
where Salary Between 41000 and 50000

update Employee
Set Grade = 'A '
where Salary Between 51000 and 100000

update Employee
Set Salary = Case
	When Grade = 'A' then Salary + (.12 * Salary)
	When Grade = 'B' then Salary + (.10 * Salary)
	When Grade = 'C' then Salary + (.5 * Salary)
	Else Salary
End
	
Delete from Employee
Where Grade = 'D' and Salary < 26000

Select MAX(Salary) 
From Employee
Where Salary < (Select MAX(Salary) From Employee)
 
