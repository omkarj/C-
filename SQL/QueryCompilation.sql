sp_configure 'clr enabled', 1;
Go
reconfigure
Go

sp_dbcmptlevel
Go

sp_dbcmptlevel 'EmployeeDB', 100
GO
	
Create Function [dbo].AppendHelloWorld(@input nvarchar(max)) Returns nvarchar(max)
External Name QueryCompilation.[QueryCompilation.HelloWorld].AppendHelloWorld;
Go

select [dbo].AppendHelloWorld('Hi') 