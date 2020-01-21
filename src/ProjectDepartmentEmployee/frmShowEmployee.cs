using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProjectDepartmentEmployee.Class;

namespace ProjectDepartmentEmployee
{
    public partial class frmShowEmployee : Form
    {
        public frmShowEmployee(decimal ID)
        {
            InitializeComponent();
            setData(ID);
        }

        private void setData(decimal ID)
        {
            using (DataBase db = new DataBase())
            {
                Employee empInf = db.Employees.Where(x => x.ID == ID).FirstOrDefault();
                tbFIO.Text = empInf.SurName + " " + empInf.FirstName + " " + empInf.Patronymic;
                tbDateOfBirth.Text = empInf.DateOfBirth.ToLongDateString();
                tbDocNumber.Text = empInf.DocNumber;
                tbDocSeries.Text = empInf.DocSeries;
                tbAllEmployeeYear.Text = empInf.EmployeeAge.ToString();
                tbOtdel.Text = db.Departments.Where(x=> x.ID == empInf.DepartmentID).FirstOrDefault().Name;
                tbPosition.Text = empInf.Position;
            }
        }

        private void btnExitProgramm_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
