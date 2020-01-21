namespace ProjectDepartmentEmployee
{
    partial class frmAddEditEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbDocNumber = new System.Windows.Forms.TextBox();
            this.tbDocSeries = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.tbSurName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOtdel = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbPatronymic = new System.Windows.Forms.TextBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbDocNumber
            // 
            this.tbDocNumber.Location = new System.Drawing.Point(180, 273);
            this.tbDocNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbDocNumber.MaxLength = 6;
            this.tbDocNumber.Name = "tbDocNumber";
            this.tbDocNumber.Size = new System.Drawing.Size(321, 22);
            this.tbDocNumber.TabIndex = 10;
            this.tbDocNumber.TextChanged += new System.EventHandler(this.tb_TextChanged);
            this.tbDocNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDigits_KeyPress);
            // 
            // tbDocSeries
            // 
            this.tbDocSeries.Location = new System.Drawing.Point(180, 231);
            this.tbDocSeries.Margin = new System.Windows.Forms.Padding(4);
            this.tbDocSeries.MaxLength = 4;
            this.tbDocSeries.Name = "tbDocSeries";
            this.tbDocSeries.Size = new System.Drawing.Size(321, 22);
            this.tbDocSeries.TabIndex = 9;
            this.tbDocSeries.TextChanged += new System.EventHandler(this.tb_TextChanged);
            this.tbDocSeries.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLettters_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 320);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Должность:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 277);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Номер документа:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 235);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Серия документа:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Дата рождения:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Фамилия:";
            // 
            // tbPosition
            // 
            this.tbPosition.Location = new System.Drawing.Point(180, 316);
            this.tbPosition.Margin = new System.Windows.Forms.Padding(4);
            this.tbPosition.MaxLength = 50;
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(321, 22);
            this.tbPosition.TabIndex = 11;
            this.tbPosition.TextChanged += new System.EventHandler(this.tb_TextChanged);
            this.tbPosition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLettters_KeyPress);
            // 
            // tbSurName
            // 
            this.tbSurName.Location = new System.Drawing.Point(180, 69);
            this.tbSurName.Margin = new System.Windows.Forms.Padding(4);
            this.tbSurName.MaxLength = 50;
            this.tbSurName.Name = "tbSurName";
            this.tbSurName.Size = new System.Drawing.Size(321, 22);
            this.tbSurName.TabIndex = 14;
            this.tbSurName.TextChanged += new System.EventHandler(this.tb_TextChanged);
            this.tbSurName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLettters_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 38);
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
            this.cmbOtdel.Location = new System.Drawing.Point(180, 34);
            this.cmbOtdel.Margin = new System.Windows.Forms.Padding(4);
            this.cmbOtdel.Name = "cmbOtdel";
            this.cmbOtdel.Size = new System.Drawing.Size(321, 24);
            this.cmbOtdel.TabIndex = 16;
            this.cmbOtdel.SelectedIndexChanged += new System.EventHandler(this.cmbOtdel_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 111);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Имя:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 148);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Отчетство:";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(180, 107);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.tbFirstName.MaxLength = 50;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(321, 22);
            this.tbFirstName.TabIndex = 19;
            this.tbFirstName.TextChanged += new System.EventHandler(this.tb_TextChanged);
            this.tbFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLettters_KeyPress);
            // 
            // tbPatronymic
            // 
            this.tbPatronymic.Location = new System.Drawing.Point(180, 148);
            this.tbPatronymic.Margin = new System.Windows.Forms.Padding(4);
            this.tbPatronymic.MaxLength = 50;
            this.tbPatronymic.Name = "tbPatronymic";
            this.tbPatronymic.Size = new System.Drawing.Size(321, 22);
            this.tbPatronymic.TabIndex = 20;
            this.tbPatronymic.TextChanged += new System.EventHandler(this.tb_TextChanged);
            this.tbPatronymic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLettters_KeyPress);
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(180, 188);
            this.dtpDateOfBirth.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(201, 22);
            this.dtpDateOfBirth.TabIndex = 22;
            this.dtpDateOfBirth.ValueChanged += new System.EventHandler(this.dtpDateOfBirth_ValueChanged);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::ProjectDepartmentEmployee.Properties.Resources.pict_close;
            this.btnExit.Location = new System.Drawing.Point(463, 348);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 37);
            this.btnExit.TabIndex = 24;
            this.toolTip1.SetToolTip(this.btnExit, "Выход");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Image = global::ProjectDepartmentEmployee.Properties.Resources.save_edit;
            this.btnSave.Location = new System.Drawing.Point(415, 348);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(40, 37);
            this.btnSave.TabIndex = 23;
            this.toolTip1.SetToolTip(this.btnSave, "Сохранить");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddEditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 394);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.tbPatronymic);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbOtdel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSurName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbPosition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDocNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbDocSeries);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddEditEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddEditEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDocNumber;
        private System.Windows.Forms.TextBox tbDocSeries;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.TextBox tbSurName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOtdel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbPatronymic;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}