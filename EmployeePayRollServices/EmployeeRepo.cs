using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace EmployeePayRollServices
{
    public class EmployeeRepo
    {
        //create connection between mssql and visual studio program
        SqlConnection con = new SqlConnection("Data Source = DESKTOP-R91EQR6\\SQLEXPRESS;Initial Catalog = Ado_db;Integrated Security = true;");

        //UC1 Create DataBase 
        public void CreateDatabase()
        {
            SqlCommand cmd = new SqlCommand("Create database EmpPayroll", con);//create database
            con.Open();
            cmd.ExecuteNonQuery();
            Console.WriteLine("Database Created Successfully");
        }
        public void CreateTable()
        {
            SqlCommand cmd = new SqlCommand("Create Table EmployeeTable(zd int primary key identity(1,1),Name varchar(200),Salary bigint,Startdate date,phone bigint," +
                    "Emp_Address varchar(200),Department varchar(200),Gender varchar(10), Basic_Pay bigint," +
                    "Deductions bigint,Taxable_Pay bigint,Income_Tax bigint,Net_Pay bigint )", con);
            con.Open();
            cmd.ExecuteNonQuery();
            Console.WriteLine("Table Created Successfully");
        }

    }
}
