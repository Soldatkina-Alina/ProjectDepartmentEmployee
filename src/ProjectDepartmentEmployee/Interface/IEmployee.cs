using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ProjectDepartmentEmployee.Interface
{
    interface IEmployee
    {
        decimal ID { get; set; }
        Guid? DepartmentID { get; set; }
        string SurName { get; set; }
        string FirstName { get; set; }
        string Patronymic { get; set; }
        DateTime DateOfBirth { get; set; }
        string DocSeries { get; set; }
        string DocNumber { get; set; }
        string Position { get; set; }
        int EmployeeAge { get;  }

    }
}
