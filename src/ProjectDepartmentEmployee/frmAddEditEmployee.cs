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
    public partial class frmAddEditEmployee : Form
    {
        Employee emp;
        Employee empOld;
        Department dep = new Department();

        public frmAddEditEmployee()
        {
            InitializeComponent();
            emp = new Employee();
            emp.isEdit = false;
            getOtdel();
            this.Text = "Добавление сотрудника";
        }

        public frmAddEditEmployee(int ID)
        {
            InitializeComponent();
            using (DataBase db = new DataBase())
            {
                emp  = db.Employees.Where(x => x.ID == ID).FirstOrDefault();
            }
            using (DataBase db = new DataBase())
            {
                empOld = db.Employees.Where(x => x.ID == ID).FirstOrDefault();
            }
            emp.isEdit = true;
            getOtdel();
            setData();
            this.Text = "Редактирование сотрудника";
        }

        private void getOtdel()
        {
            cmbOtdel.DisplayMember = "Name";
            cmbOtdel.ValueMember = "ID";

            DataTable dt = dep.Otdel;
            dt.Rows.RemoveAt(0);
            cmbOtdel.DataSource = dt;
        }

        private void setData()
        {
            tbSurName.Text = emp.SurName;
            tbFirstName.Text = emp.FirstName;
            tbPatronymic.Text = emp.Patronymic;
            tbDocNumber.Text = emp.DocNumber;
            tbDocSeries.Text = emp.DocSeries;
            dtpDateOfBirth.Value = emp.DateOfBirth;
            tbPosition.Text = emp.Position;
            cmbOtdel.SelectedValue = emp.DepartmentID;
        }

        private bool checkData()
        {
            if (dtpDateOfBirth.Value.Year > DateTime.Now.Year - 14)
            {
                MessageBox.Show("Неккоректное значение даты.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            if (emp.isEdit) return true;

            using (DataBase db = new DataBase())
            {
                if (db.Employees.Where(c => c.SurName == emp.SurName && c.FirstName == emp.FirstName &&
                                        c.Patronymic == emp.Patronymic).FirstOrDefault() != null)
                    if (DialogResult.No == MessageBox.Show(Config.centralText("Сотрудник с таким ФИО уже заведен.\n" +
                        "Продолжить сохранение?\n"), "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        return false;

                if (db.Employees.Where(c => c.DocNumber == emp.DocNumber && c.DocSeries == emp.DocSeries).FirstOrDefault() != null)
                    if (DialogResult.No == MessageBox.Show(Config.centralText("Сотрудник с такими номером и серией уже заведен.\n" +
                        "Продолжить сохранение?\n"), "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        return false;

            }

            return true;
        }

        private bool compareEmployee()
        {
            foreach (var e1 in emp.GetType().GetProperties())
                foreach (var e2 in empOld.GetType().GetProperties())
                    if (e1.Name == e2.Name && e1.Name != "Department")
                        //MessageBox.Show(e1.Name + " " + e1.GetValue(emp, null).ToString() + " " + e2.Name + " " + e2.GetValue(empOld, null).ToString());
                        if (e1.GetValue(emp, null).ToString() != e2.GetValue(empOld, null).ToString())
                            return true;

            return false;
        }

        private bool checkEmptyTextBox()
        {
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
                if (tb.Name != "" && tb.Text.Length < 1)
                    return false;

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!checkData()) return;
            if (emp.isEdit)
                emp.editEmployee();
            else emp.addEmployee(emp);
            MessageBox.Show("Сохранено.", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (btnSave.Enabled)
            {
                if (DialogResult.Yes == MessageBox.Show("Выйти без сохранения?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    DialogResult = DialogResult.OK;
                else return;
            }
            else DialogResult = DialogResult.OK; ;
        }

        private void tbLettters_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Config.special_symbols.Contains(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void tbDigits_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Config.special_symbols.Contains(e.KeyChar) || !Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            if (!checkEmptyTextBox())
            {
                btnSave.Enabled = false;
                return;
            }
            emp.SurName = tbSurName.Text;
            emp.FirstName = tbFirstName.Text;
            emp.Patronymic = tbPatronymic.Text;
            emp.DocNumber = tbDocNumber.Text;
            emp.DocSeries = tbDocSeries.Text;
            emp.DateOfBirth = dtpDateOfBirth.Value;
            emp.Position = tbPosition.Text;
            emp.DepartmentID = Guid.Parse(cmbOtdel.SelectedValue.ToString());
            if (emp.isEdit)
                btnSave.Enabled = compareEmployee() && emp.DocSeries.Length == 4 && emp.DocNumber.Length == 6;
            else btnSave.Enabled = checkEmptyTextBox() && emp.DocSeries.Length == 4 && emp.DocNumber.Length == 6;
        }

        private void dtpDateOfBirth_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
