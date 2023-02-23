Create Database EmployeePayRollServices;

Create Table EmployeeTable(EmployeeId int primary key identity(1,1),EmployeeName varchar(200),Salary bigint, Startdate date,PhoneNumber bigint,
                    Address varchar(200),Department varchar(200),Gender varchar(10), Basic_Pay bigint,
                    Deductions bigint,Taxable_Pay bigint,Income_Tax bigint,Net_Pay bigint);
select *from EmployeeTable; 
