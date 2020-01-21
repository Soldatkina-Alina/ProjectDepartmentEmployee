using System;
using System.Data;
using ProjectDepartmentEmployee.Interface;
using System.ComponentModel.DataAnnotations;

namespace ProjectDepartmentEmployee.Class
{
    public class Department : IDepartment
    {
        [Key]
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public Guid? ParentDepartmentID { get; set; }

        public DataTable Otdel { get
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("ID", typeof(Guid));
                dt.Columns.Add("Name", typeof(string));
                dt.Rows.Add(null, "Все отделы");

                using (DataBase db = new DataBase())
                {
                    var dep = db.Departments;
                    foreach (Department d in dep)
                        dt.Rows.Add(new object[] { d.ID, d.Name });

                }
                return dt;
            } }
    }



}
