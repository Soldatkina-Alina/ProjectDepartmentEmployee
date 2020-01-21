using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using ProjectDepartmentEmployee.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectDepartmentEmployee.Class
{
    class Employee : IEmployee
    {
        [Key]
        public decimal ID { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid? DepartmentID { get; set; }
        public string SurName { get; set; }
        public string FirstName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Patronymic { get; set; }
        public string DocSeries { get; set; }
        public string DocNumber { get; set; }
        public string Position { get; set; }

        [ForeignKey("DepartmentID")]
        public virtual Department Department { get; set; }

        //public List<Employee> listEmp {
        //    get 
        //    {
        //        using (DataBase db = new DataBase())
        //        {
        //            //if (this.DepartmentID == null)
        //            //    return listEmp = db.Empoyees.Where(x=> x==x).ToList();
        //            //else
        //            return db.Empoyees.Where(x => x.DepartmentID == this.DepartmentID ).Select(r=>  new
        //                { ID = r.ID,
        //                DepartmentID= r.DepartmentID,
        //                SurName = r.SurName,
        //                FirstName = r.FirstName,
        //                Patronymic = r.Patronymic
        //            }
        //            ).ToList();
        //        }
        //    }
        //    set { } }
        
        public bool isEdit;
        public string filter = "";
        public int EmployeeAge
        {
            get
            {
                if (DateOfBirth == null)
                    return 0;
                else if (DateOfBirth.Month < DateTime.Now.Month || (DateOfBirth.Month == DateTime.Now.Month && DateOfBirth.Day <= DateTime.Now.Day) )
                    return DateTime.Now.Year - DateOfBirth.Year;
                else if (DateOfBirth.Month > DateTime.Now.Month || (DateOfBirth.Month == DateTime.Now.Month && DateOfBirth.Day > DateTime.Now.Day))
                    return DateTime.Now.Year - DateOfBirth.Year - 1;
                else return 0;
            }
        }
        public Employee ()
        { }

        public Employee(Guid DepartmentID, string SurName, string FirstName, DateTime DateOfBirth, string Patronymic,
            string DocSeries, string DocNumber, string Position)
        {
            this.DepartmentID = DepartmentID;
            this.SurName = SurName;
            this.FirstName = FirstName;
            this.Patronymic = Patronymic;
            this.DocNumber = DocNumber;
            this.DocSeries = DocSeries;
            this.DocNumber = DocNumber;
            this.Position = Position;
        }

        //public Employee (int ID)
        //{
        //    // заполнить все поля из БД
        //    isEdit = true;
        //}

        

        public void addEmployee(Employee em)
        {
            using (DataBase db = new DataBase())
            {
                //em.Department = em.DepartmentID;
                db.Employees.Add(em);
                db.SaveChanges();
            }
        }

        public void editEmployee()
        {
            using (DataBase db = new DataBase())
            {
                Employee e = db.Employees.Where(x => x.ID == this.ID).FirstOrDefault();
                e.DepartmentID = this.DepartmentID;
                e.SurName = this.SurName;
                e.FirstName = this.FirstName;
                e.Patronymic = this.Patronymic;
                e.DateOfBirth = this.DateOfBirth;
                e.DocSeries = this.DocSeries;
                e.DocNumber = this.DocNumber;
                e.Position = this.Position;
                db.SaveChanges();
            }
        }
            
    }
}
