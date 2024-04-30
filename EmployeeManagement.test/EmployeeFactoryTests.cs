using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using EmployeeManagement.Business;
using EmployeeManagement.DataAccess.Entities;


namespace EmployeeManagement.test
{
    public class EmployeeFactoryTests
    {
        [Fact] // Lo marco con el atributo "Fact". Significa que es un unit test method
        public void CreateEmployee_constructInternalEmployee_SalaryMustBe2500()
        {
            var employeeFactory = new EmployeeFactory();

            var employee = (InternalEmployee)employeeFactory.CreateEmployee("Kevin", "Dockx");

            Assert.Equal(2500, employee.Salary);
            /* NOTA: pueda haber más de un assert en un test, pero lo suyo es que haya solo uno*/
        }
    }
}
