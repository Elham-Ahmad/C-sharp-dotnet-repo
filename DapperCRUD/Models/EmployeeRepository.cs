using Dapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;

namespace DapperCRUD.Models
{
    public class EmployeeRepository
    {
        private string connectionString;

        public EmployeeRepository()
        {
            connectionString = @"Server=localhost\\SQLEXPRESS;Database=DapperCRUD;Trusted_Connection=True;";
        }
        public IDbConnection Connection
        {
            get { return new SqlConnection(connectionString); }
        }

        public void Add(Employee employee)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sql = @"Insert into EmployeeInfo(EmpName,Designation,Department)Values (@EmpName,@Designation,@Department)";
                dbConnection.Open();
                dbConnection.Execute(sql, employee);
                dbConnection.Close();
            }
        }

        //Get All 
        public IEnumerable<Employee> GetAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sql = @"select * from EmployeeInfo";
                dbConnection.Open();
                return dbConnection.Query<Employee>(sql);


            }
        }

        //Get by Id 
        public IEnumerable<Employee> GetById(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sql = @"select * from EmployeeInfo where EmpId =@id";
                dbConnection.Open();
                yield return dbConnection.Query<Employee>(sql, new { Id = id }).FirstOrDefault();
            }
        }


        //Update 
        public void Update(Employee employee, int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sql = @"Update EmployeeInfo set EmpName =@EmpName,Designation=@Designation,Department=@Department where EmpId =@id";
                dbConnection.Open();
                dbConnection.Query<Employee>(sql, employee);
                dbConnection.Close();

            }
        }

        //Delete 
        public void Delete(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sql = @"delete from EmployeeInfo where EmpId =@id";
                dbConnection.Open();
                dbConnection.Query<Employee>(sql, new {Id = id });
                dbConnection.Close();

            }

        }

        internal void Update(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
