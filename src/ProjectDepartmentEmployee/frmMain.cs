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
    public partial class frmMain : Form
    {
        Department dep = new Department();
        Employee emp = new Employee();

        public frmMain()
        {
            InitializeComponent();
            TreeViewColor_Load();
            getOtdel();
        }

        #region Заполнение данными
        private void getOtdel()
        {
            cmbOtdel.DisplayMember = "Name";
            cmbOtdel.ValueMember = "ID";

            emp.DepartmentID = null;
            cmbOtdel.DataSource = dep.Otdel;
            
        }

        private void getTable()
        {
            dgvEmployee.AutoGenerateColumns = false;
            dgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            using (DataBase db = new DataBase())
            {
                dgvEmployee.DataSource  = db.Employees.Where(x => (x.DepartmentID == emp.DepartmentID || emp.DepartmentID == null) 
                && (x.FirstName.Contains(emp.filter) || x.SurName.Contains(emp.filter) || x.Position.Contains(emp.filter) || emp.filter == "" )).Select(r => new
                {
                    ID = r.ID,
                    DepartmentID = r.DepartmentID,
                    SurName = r.SurName,
                    FirstName = r.FirstName,
                    Patronymic = r.Patronymic
                }
                    ).ToList();
            }
        }

        private void getEmployeeInformation()
        {
            if (dgvEmployee.CurrentRow == null) return;

 
        }

        #endregion
        #region Дерево

        private DataTable dt;
        private static string noteID;
        private List<string> strName = new List<string>();
        
        private void TreeViewColor_Load()
        {
            CreateData();
            CreateNodes();
        }

        private void CreateData()
        {
            dt = new DataTable("CaseNotes");
            dt.Columns.Add("NoteID", typeof(string));
            dt.Columns.Add("NoteName", typeof(string));
            DataColumn dc = new DataColumn("ParentNoteID", typeof(string));
            dc.AllowDBNull = true;
            dt.Columns.Add(dc);

            // Add sample data.

            using (DataBase db = new DataBase())
            {
                var dep = db.Departments;
                foreach (Department d in dep)
                    dt.Rows.Add(new string[] { d.ID.ToString(), d.Name.ToString(), d.ParentDepartmentID.ToString() });
            }
        }

        private void CreateNodes()
        {
            DataRow[] rows = new DataRow[dt.Rows.Count];
            dt.Rows.CopyTo(rows, 0);

            treeView1.BeginUpdate();
            treeView1.Nodes.Clear();

            TreeNode[] nodes = RecurseRows(rows);
            treeView1.Nodes.AddRange(nodes);
            treeView1.EndUpdate();
        }

        private TreeNode[] RecurseRows(DataRow[] rows)
        {
            List<TreeNode> nodeList = new List<TreeNode>();
            TreeNode node = null;

            foreach (DataRow dr in rows)
            {
                node = new TreeNode(dr["NoteName"].ToString());
                noteID = dr["NoteID"].ToString();

                node.Name = noteID.ToString();
                node.ToolTipText = noteID.ToString();
                if (nodeList.Find(FindNode) == null)
                {
                    DataRow[] childRows = dt.Select("ParentNoteID LIKE \'" + dr["NoteID"] + "\'");
                    if (childRows.Length > 0)
                    {
                        TreeNode[] childNodes = RecurseRows(childRows);
                        node.Nodes.AddRange(childNodes);
                    }

                    if (!strName.Contains(dr["NoteName"].ToString()))
                    {
                        nodeList.Add(node);
                        strName.Add(dr["NoteName"].ToString());
                    }
                }
            }

            
            TreeNode[] nodeArr = nodeList.Distinct().ToArray();
            return nodeArr;
        }

        private static bool FindNode(TreeNode n)
        {
            if (n.Nodes.Count == 0)
                return n.Name == noteID.ToString();
            else
            {
                while (n.Nodes.Count > 0)
                {
                    foreach (TreeNode tn in n.Nodes)
                    {
                        if (tn.Name == noteID.ToString())
                            return true;
                        else
                            n = tn;
                    }
                }
                return false;
            }
        }
        #endregion

        private void tbSearchEmployee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Config.special_symbols.Contains(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void tbSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            tbSearchEmployee.Text = Config.ClearText(tbSearchEmployee.Text);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            getTable();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            frmAddEditEmployee frmAddEditEmployee = new frmAddEditEmployee();
            frmAddEditEmployee.ShowDialog();
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            frmAddEditEmployee frmAddEditEmployee = new frmAddEditEmployee(int.Parse(dgvEmployee.CurrentRow.Cells["ID"].Value.ToString()));
            frmAddEditEmployee.ShowDialog();
        }

        private void btnExitProgramm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = DialogResult.No == MessageBox.Show("Закрыть программу?", "Выход из программы", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }

        private void cmbOtdel_TabIndexChanged(object sender, EventArgs e)
        {
            using (DataBase db = new DataBase())
            {
                dgvEmployee.DataSource = db.Employees.Where(x=> x.DepartmentID.ToString() == cmbOtdel.SelectedValue.ToString());
            }
        }

        private void cmbOtdel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOtdel.SelectedIndex < 0) return;
            if (cmbOtdel.SelectedValue.ToString() == "")
                emp.DepartmentID = null;
            else
                emp.DepartmentID = Guid.Parse(cmbOtdel.SelectedValue.ToString());
            getTable();
        }

        private void tbSearchEmployee_TextChanged_1(object sender, EventArgs e)
        {
            emp.filter = Config.ClearText(tbSearchEmployee.Text);
            getTable();
        }

        private void dgvEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmployee.CurrentRow == null) return;
            frmShowEmployee frmShowEmployee = new frmShowEmployee(decimal.Parse(dgvEmployee.CurrentRow.Cells["ID"].Value.ToString()));
            frmShowEmployee.ShowDialog();
        }
    }
}
