namespace ProjectDepartmentEmployee
{
    partial class frmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tbSearchEmployee = new System.Windows.Forms.TextBox();
            this.btnExitProgramm = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grbTableEmployee = new System.Windows.Forms.GroupBox();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmenrID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOtdel = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.grbTableEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSearchEmployee
            // 
            this.tbSearchEmployee.Location = new System.Drawing.Point(17, 36);
            this.tbSearchEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearchEmployee.Name = "tbSearchEmployee";
            this.tbSearchEmployee.Size = new System.Drawing.Size(499, 22);
            this.tbSearchEmployee.TabIndex = 3;
            this.toolTip1.SetToolTip(this.tbSearchEmployee, "Поиск сотрудника");
            this.tbSearchEmployee.TextChanged += new System.EventHandler(this.tbSearchEmployee_TextChanged_1);
            this.tbSearchEmployee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearchEmployee_KeyPress);
            // 
            // btnExitProgramm
            // 
            this.btnExitProgramm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExitProgramm.Image = global::ProjectDepartmentEmployee.Properties.Resources.pict_close;
            this.btnExitProgramm.Location = new System.Drawing.Point(591, 571);
            this.btnExitProgramm.Margin = new System.Windows.Forms.Padding(4);
            this.btnExitProgramm.Name = "btnExitProgramm";
            this.btnExitProgramm.Size = new System.Drawing.Size(40, 37);
            this.btnExitProgramm.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnExitProgramm, "Выход");
            this.btnExitProgramm.UseVisualStyleBackColor = true;
            this.btnExitProgramm.Click += new System.EventHandler(this.btnExitProgramm_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = global::ProjectDepartmentEmployee.Properties.Resources.reload_8055;
            this.btnUpdate.Location = new System.Drawing.Point(571, 21);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(40, 37);
            this.btnUpdate.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btnUpdate, "Обновить таблицу");
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Image = global::ProjectDepartmentEmployee.Properties.Resources.edit_1761;
            this.btnEditEmployee.Location = new System.Drawing.Point(571, 184);
            this.btnEditEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(40, 37);
            this.btnEditEmployee.TabIndex = 19;
            this.toolTip1.SetToolTip(this.btnEditEmployee, "Редактировать сотрудника");
            this.btnEditEmployee.UseVisualStyleBackColor = true;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Image = global::ProjectDepartmentEmployee.Properties.Resources.document_add;
            this.btnAddEmployee.Location = new System.Drawing.Point(571, 130);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(40, 37);
            this.btnAddEmployee.TabIndex = 16;
            this.toolTip1.SetToolTip(this.btnAddEmployee, "Добавить сотрудника ");
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnUpdate);
            this.tabPage2.Controls.Add(this.btnEditEmployee);
            this.tabPage2.Controls.Add(this.btnAddEmployee);
            this.tabPage2.Controls.Add(this.grbTableEmployee);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.cmbOtdel);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(632, 519);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Список сотрудников";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grbTableEmployee
            // 
            this.grbTableEmployee.Controls.Add(this.tbSearchEmployee);
            this.grbTableEmployee.Controls.Add(this.dgvEmployee);
            this.grbTableEmployee.Location = new System.Drawing.Point(20, 62);
            this.grbTableEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.grbTableEmployee.Name = "grbTableEmployee";
            this.grbTableEmployee.Padding = new System.Windows.Forms.Padding(4);
            this.grbTableEmployee.Size = new System.Drawing.Size(533, 432);
            this.grbTableEmployee.TabIndex = 17;
            this.grbTableEmployee.TabStop = false;
            this.grbTableEmployee.Text = "Список сотрудников";
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            this.dgvEmployee.AllowUserToResizeRows = false;
            this.dgvEmployee.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DepartmenrID,
            this.SurName,
            this.FirstName,
            this.Patronymic});
            this.dgvEmployee.GridColor = System.Drawing.SystemColors.Control;
            this.dgvEmployee.Location = new System.Drawing.Point(17, 68);
            this.dgvEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEmployee.MultiSelect = false;
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.RowHeadersVisible = false;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployee.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.Size = new System.Drawing.Size(500, 335);
            this.dgvEmployee.TabIndex = 2;
            this.dgvEmployee.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // DepartmenrID
            // 
            this.DepartmenrID.DataPropertyName = "DepartmenrID";
            this.DepartmenrID.HeaderText = "DepartmenrID";
            this.DepartmenrID.Name = "DepartmenrID";
            this.DepartmenrID.ReadOnly = true;
            this.DepartmenrID.Visible = false;
            // 
            // SurName
            // 
            this.SurName.DataPropertyName = "SurName";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.SurName.DefaultCellStyle = dataGridViewCellStyle5;
            this.SurName.HeaderText = "Фамилия";
            this.SurName.Name = "SurName";
            this.SurName.ReadOnly = true;
            this.SurName.Width = 140;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "Имя";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // Patronymic
            // 
            this.Patronymic.DataPropertyName = "Patronymic";
            this.Patronymic.HeaderText = "Отчество";
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Отдел:";
            // 
            // cmbOtdel
            // 
            this.cmbOtdel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOtdel.FormattingEnabled = true;
            this.cmbOtdel.Location = new System.Drawing.Point(105, 28);
            this.cmbOtdel.Margin = new System.Windows.Forms.Padding(4);
            this.cmbOtdel.Name = "cmbOtdel";
            this.cmbOtdel.Size = new System.Drawing.Size(423, 24);
            this.cmbOtdel.TabIndex = 14;
            this.cmbOtdel.SelectedIndexChanged += new System.EventHandler(this.cmbOtdel_SelectedIndexChanged);
            this.cmbOtdel.TabIndexChanged += new System.EventHandler(this.cmbOtdel_TabIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.treeView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(632, 519);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Структура предприятия";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(64, 32);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(489, 467);
            this.treeView1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(640, 548);
            this.tabControl1.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 614);
            this.Controls.Add(this.btnExitProgramm);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тестовое задание";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.grbTableEmployee.ResumeLayout(false);
            this.grbTableEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnExitProgramm;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.GroupBox grbTableEmployee;
        private System.Windows.Forms.TextBox tbSearchEmployee;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmenrID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patronymic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOtdel;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TreeView treeView1;
    }
}

