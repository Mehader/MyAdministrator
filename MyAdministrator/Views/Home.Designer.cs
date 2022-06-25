namespace MyAdministrator
{
    partial class Home
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelSubjectError = new System.Windows.Forms.Label();
            this.btnSubjectDel = new System.Windows.Forms.Button();
            this.listSubject = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewSubject = new System.Windows.Forms.TextBox();
            this.btnSubjectAdd = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSearch1 = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAdd1 = new System.Windows.Forms.Button();
            this.gridStudents = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtHistory = new System.Windows.Forms.TextBox();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStudents)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelSubjectError);
            this.tabPage2.Controls.Add(this.btnSubjectDel);
            this.tabPage2.Controls.Add(this.listSubject);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtNewSubject);
            this.tabPage2.Controls.Add(this.btnSubjectAdd);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Предметы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelSubjectError
            // 
            this.labelSubjectError.AutoSize = true;
            this.labelSubjectError.ForeColor = System.Drawing.Color.Red;
            this.labelSubjectError.Location = new System.Drawing.Point(296, 110);
            this.labelSubjectError.Name = "labelSubjectError";
            this.labelSubjectError.Size = new System.Drawing.Size(92, 15);
            this.labelSubjectError.TabIndex = 16;
            this.labelSubjectError.Text = "Неверный ввод";
            // 
            // btnSubjectDel
            // 
            this.btnSubjectDel.Location = new System.Drawing.Point(394, 157);
            this.btnSubjectDel.Name = "btnSubjectDel";
            this.btnSubjectDel.Size = new System.Drawing.Size(75, 23);
            this.btnSubjectDel.TabIndex = 15;
            this.btnSubjectDel.Text = "Удалить";
            this.btnSubjectDel.UseVisualStyleBackColor = true;
            this.btnSubjectDel.Click += new System.EventHandler(this.btnSubjectDel_Click);
            // 
            // listSubject
            // 
            this.listSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listSubject.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listSubject.FormattingEnabled = true;
            this.listSubject.Location = new System.Drawing.Point(394, 128);
            this.listSubject.Name = "listSubject";
            this.listSubject.Size = new System.Drawing.Size(169, 23);
            this.listSubject.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Список предметов";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Предмет";
            // 
            // txtNewSubject
            // 
            this.txtNewSubject.Location = new System.Drawing.Point(212, 128);
            this.txtNewSubject.Name = "txtNewSubject";
            this.txtNewSubject.Size = new System.Drawing.Size(176, 23);
            this.txtNewSubject.TabIndex = 11;
            this.txtNewSubject.TextChanged += new System.EventHandler(this.txtNewSubject_TextChanged);
            // 
            // btnSubjectAdd
            // 
            this.btnSubjectAdd.Location = new System.Drawing.Point(212, 157);
            this.btnSubjectAdd.Name = "btnSubjectAdd";
            this.btnSubjectAdd.Size = new System.Drawing.Size(75, 23);
            this.btnSubjectAdd.TabIndex = 7;
            this.btnSubjectAdd.Text = "Добавить";
            this.btnSubjectAdd.UseVisualStyleBackColor = true;
            this.btnSubjectAdd.Click += new System.EventHandler(this.btnSubjectAdd_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSearch1);
            this.tabPage1.Controls.Add(this.txtSearch);
            this.tabPage1.Controls.Add(this.btnAdd1);
            this.tabPage1.Controls.Add(this.gridStudents);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Студенты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSearch1
            // 
            this.btnSearch1.Location = new System.Drawing.Point(228, 392);
            this.btnSearch1.Name = "btnSearch1";
            this.btnSearch1.Size = new System.Drawing.Size(75, 23);
            this.btnSearch1.TabIndex = 5;
            this.btnSearch1.Text = "Поиск";
            this.btnSearch1.UseVisualStyleBackColor = true;
            this.btnSearch1.Click += new System.EventHandler(this.btnSearch1_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(8, 392);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(190, 23);
            this.txtSearch.TabIndex = 4;
            // 
            // btnAdd1
            // 
            this.btnAdd1.Location = new System.Drawing.Point(709, 393);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(75, 23);
            this.btnAdd1.TabIndex = 3;
            this.btnAdd1.Text = "Добавить";
            this.btnAdd1.UseVisualStyleBackColor = true;
            this.btnAdd1.Click += new System.EventHandler(this.btnAdd1_Click);
            // 
            // gridStudents
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnName,
            this.ColumnSurname,
            this.ColumnSubject,
            this.ColumnGrade});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridStudents.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridStudents.Location = new System.Drawing.Point(9, 6);
            this.gridStudents.Name = "gridStudents";
            this.gridStudents.RowTemplate.Height = 25;
            this.gridStudents.Size = new System.Drawing.Size(776, 379);
            this.gridStudents.TabIndex = 0;
            this.gridStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridStudents_btnClick);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.Visible = false;
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnName.HeaderText = "Имя";
            this.ColumnName.Name = "ColumnName";
            // 
            // ColumnSurname
            // 
            this.ColumnSurname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnSurname.HeaderText = "Фамилия";
            this.ColumnSurname.Name = "ColumnSurname";
            // 
            // ColumnSubject
            // 
            this.ColumnSubject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnSubject.HeaderText = "Предмет";
            this.ColumnSubject.Name = "ColumnSubject";
            // 
            // ColumnGrade
            // 
            this.ColumnGrade.HeaderText = "Оценка";
            this.ColumnGrade.Name = "ColumnGrade";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 450);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtHistory);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 422);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "История";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtHistory
            // 
            this.txtHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHistory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHistory.Location = new System.Drawing.Point(3, 3);
            this.txtHistory.Multiline = true;
            this.txtHistory.Name = "txtHistory";
            this.txtHistory.ReadOnly = true;
            this.txtHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHistory.Size = new System.Drawing.Size(786, 416);
            this.txtHistory.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "Home";
            this.Text = "Обзор данных";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStudents)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSubjectAdd;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnSearch1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAdd1;
        private System.Windows.Forms.DataGridView gridStudents;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGrade;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewSubject;
        public System.Windows.Forms.ComboBox listSubject;
        private System.Windows.Forms.Button btnSubjectDel;
        private System.Windows.Forms.Label labelSubjectError;
        public System.Windows.Forms.TextBox txtHistory;
    }
}