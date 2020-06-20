using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuisnessObject;
using DataAccess;

namespace BusinessLayer
{
    public class EmployeeBL
    {
        EmployeeDAL emp;

        public EmployeeBL()
        {
            emp = new EmployeeDAL();
        }

        public void AddEmployee(EmployeeBO Employee,EmployeeDetails ED)
        {
            emp.AddEmployee(Employee,ED);
        }

        public void RemoveEmployee(EmployeeBO Employee)
        {

            emp.RemoveEmployee(Employee);

        }
        public EmployeeBO UpdateEmployee (EmployeeBO Employee){

            return emp.UpdateEmployee(Employee);
        }
        //retrieve by id
        public EmployeeBO RetrieveEmployeeInfo(int id) {
            return emp.RetrieveEmployeeInfo(id);
        }
        //retrieve by name
        public SqlDataAdapter RetrieveEmployeeInfo(string name) {
            return emp.RetrieveEmployeeInfo(name);
        }
        public SqlDataAdapter ShowEmployeeList(){
            return emp.ShowEmployeeList();
        }
        public WorkProperties EmployeeWorkProperties(EmployeeBO employee) {
            return emp.EmployeeWorkProperties(employee);
        }
    }
}


