Create Table Employee_Test
(
	Emp_ID Int Identity,
	Emp_Name Varchar(100),
	Emp_Sal Decimal(10,2)

)

Create Table Employee_Test_Audit
(
	Emp_ID Int,
	Emp_Name Varchar(100),
	Emp_Sal Decimal(10,2),
	Audit_Action Varchar(100),
	Audit_Timestamp Datetime
)
Go

Create Trigger trigAfterInsert On [dbo].[Employee_Test]
For Insert
As 
	declare @empid Int;
	declare @empname Varchar(100);
	declare @empsal decimal(10,2);
	declare @audit_action varchar(100);

	Select @empid = i.Emp_ID from inserted i;
	Select @empname = i.Emp_Name from inserted i;
	Select @empsal = i.Emp_Sal from inserted i;
	Set @audit_action =  'Inserted Record -- After Insert Trigger';

	insert into Employee_Test_Audit
		(Emp_ID,Emp_Name,Emp_Sal,Audit_Action,Audit_Timestamp)
	Values(@empid,@empname,@empsal,@audit_action,GETDATE());

	Print 'After Insert trigger fired'
Go


insert into Employee_Test Values('ABC',100000)
insert into Employee_Test Values('XYZ',200000)
insert into Employee_Test Values('DEF',150000)
insert into Employee_Test Values('MNO',120000)

select * from Employee_Test

select * from Employee_Test_Audit
Go

Create Trigger trigInsteadOfDelete On [dbo].[Employee_Test]
Instead of Delete
As 
	declare @empid Int;
	declare @empname Varchar(100);
	declare @empsal decimal(10,2);
	declare @audit_action varchar(100);

	Select @empid = i.Emp_ID from deleted i;
	Select @empname = i.Emp_Name from deleted i;
	Select @empsal = i.Emp_Sal from deleted i;
	Set @audit_action =  'Inserted Record -- After Insert Trigger';
	
	Begin 
		if(@empsal > 120000)
			begin
				Raiserror('Cannot Delete!',16,1);
				Rollback;
			end
		else
			begin
				Delete from Employee_Test where Emp_ID = @empid
				Commit;
				insert into Employee_Test_Audit(Emp_ID, Emp_Name,Emp_Sal,Audit_Action,Audit_Timestamp)
				values(@empid,@empname,@empsal,'Deleted -- Instead of Delete Trigger',GETDATE());
				Print 'Record Deleted -- Instead of delete'
			end
	end
Go

Delete from Employee_Test where Emp_Sal = 200000

Alter Table Employee_Test Disable Trigger trigInsteadOfDelete

Alter Table Employee_Test Enable Trigger All
Go

Create Procedure EmployeeCount_Salary_Filter
@salary decimal(10,2)
As
Begin 
	Declare @TotalEmployee int
	Select @TotalEmployee = Count(Emp_ID) from Employee_Test Where Emp_Sal = @salary
	Print @TotalEmployee
End
Go

Exec EmployeeCount_Salary_Filter 150000
Go

Create Function GetCount(@Salary decimal(10,2))
Returns int
Begin
	Declare @TotalEmployee int
	Select @TotalEmployee = Count(Emp_ID) from Employee_Test where Emp_Sal = @Salary
	Return @TotalEmployee
End
Go

Select Total = dbo.GetCount(120000)
Go