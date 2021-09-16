using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using blazormey.Models;

namespace blazormey.Pages 
{
    public partial class EmployeePage 
    {
        public IEnumerable <Employee> Employees { get; set; }
        
        protected override Task OnInitializedAsync()
        {
            LoadEmployees();
            return base.OnInitializedAsync();
        }

        private void LoadEmployees(){
            Employee e1 = new Employee{
                EmployeeId=1,
                FirstName="Meylisa",
                LastName="Ishariyanti",
                Email="meylisaishariyanti@gmail.com",
                DateOfBirth = new DateTime(2001,05,20),
                Gender = Gender.Female,
                Department = new Department{DepartmentId=1,DepartmentName="IT"},
                PhotoPath = "images/meylisa.jpg"
            };

             Employee e2 = new Employee{
                EmployeeId=2,
                FirstName="Jelena",
                LastName="Imelia",
                Email="jelenaimelia@gmail.com",
                DateOfBirth = new DateTime(2001,01,24),
                Gender = Gender.Female,
                Department = new Department{DepartmentId=2,DepartmentName="Human Resource"},
                PhotoPath = "images/jelena.jpg"
                  };
                  
             Employee e3 = new Employee{
                EmployeeId=3,
                FirstName="Juan",
                LastName="Dien",
                Email="juandien@gmail.com",
                DateOfBirth = new DateTime(2001,11,05),
                Gender = Gender.Male,
                Department = new Department{DepartmentId=2,DepartmentName="IT"},
                PhotoPath = "images/juan.jpg"
                   };

                   Employees = new List<Employee>{e1,e2,e3};
        }
    }
}

