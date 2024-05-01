using EmployeeManagement.Test.Fixtures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.test.Fixtures
{
    [CollectionDefinition("EmployeeServiceCollection")] // Para decorar la clase con la colección definición atributo
    public class EmployeeServiceCollectionFixture : ICollectionFixture<EmployeeServiceFixture>
    {
    }
}
