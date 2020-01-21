using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ProjectDepartmentEmployee.Interface
{
    interface IDepartment
    {
        Guid ID { get; set; }
        Guid? ParentDepartmentID { get; set; }
        string Code { get; set; }
        string Name { get; set; }
    }
}
