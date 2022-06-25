namespace MyAdministrator
{
    partial class AddStudent
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSurnameAdd = new System.Windows.Forms.TextBox();
            this.BtnCreateAdd = new System.Windows.Forms.Button();
            this.listSubjectAdd = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listGradeAdd = new System.Windows.Forms.ComboBox();
            this.labelNameError = new System.Windows.Forms.Label();
            this.labelSurnameError = new System.Windows.Forms.Label();
            this.labelBtnError = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // txtNameAdd
            // 
            this.txtNameAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNameAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNameAdd.Location = new System.Drawing.Point(82, 57);
            this.txtNameAdd.Name = "txtNameAdd";
            this.txtNameAdd.PlaceholderText = "Введите имя";
            this.txtNameAdd.Size = new System.Drawing.Size(169, 23);
            this.txtNameAdd.TabIndex = 1;
            this.txtNameAdd.TextChanged += new System.EventHandler(this.txtNameAdd_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фамалия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Предмет";
            // 
            // txtSurnameAdd
            // 
            this.txtSurnameAdd.ForeColor = System.Drawing.Color.Black;
            this.txtSurnameAdd.Location = new System.Drawing.Point(82, 109);
            this.txtSurnameAdd.Name = "txtSurnameAdd";
            this.txtSurnameAdd.PlaceholderText = "Введите фамилию";
            this.txtSurnameAdd.Size = new System.Drawing.Size(169, 23);
            this.txtSurnameAdd.TabIndex = 4;
            this.txtSurnameAdd.TextChanged += new System.EventHandler(this.txtSurnameAdd_TextChanged);
            // 
            // BtnCreateAdd
            // 
            this.BtnCreateAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCreateAdd.Location = new System.Drawing.Point(82, 265);
            this.BtnCreateAdd.Name = "BtnCreateAdd";
            this.BtnCreateAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnCreateAdd.TabIndex = 6;
            this.BtnCreateAdd.Text = "Создать";
            this.BtnCreateAdd.UseVisualStyleBackColor = true;
            this.BtnCreateAdd.Click += new System.EventHandler(this.BtnCreateAdd_Click);
            // 
            // listSubjectAdd
            // 
            this.listSubjectAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listSubjectAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listSubjectAdd.FormattingEnabled = true;
            this.listSubjectAdd.Location = new System.Drawing.Point(82, 163);
            this.listSubjectAdd.Name = "listSubjectAdd";
            this.listSubjectAdd.Size = new System.Drawing.Size(169, 23);
            this.listSubjectAdd.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Оценка";
            // 
            // listGradeAdd
            // 
            this.listGradeAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listGradeAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listGradeAdd.FormattingEnabled = true;
            this.listGradeAdd.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.listGradeAdd.Location = new System.Drawing.Point(82, 216);
            this.listGradeAdd.Name = "listGradeAdd";
            this.listGradeAdd.Size = new System.Drawing.Size(169, 23);
            this.listGradeAdd.TabIndex = 9;
            // 
            // labelNameError
            // 
            this.labelNameError.AutoSize = true;
            this.labelNameError.ForeColor = System.Drawing.Color.Red;
            this.labelNameError.Location = new System.Drawing.Point(159, 39);
            this.labelNameError.Name = "labelNameError";
            this.labelNameError.Size = new System.Drawing.Size(92, 15);
            this.labelNameError.TabIndex = 10;
            this.labelNameError.Text = "Неверный ввод";
            this.labelNameError.Visible = false;
            // 
            // labelSurnameError
            // 
            this.labelSurnameError.AutoSize = true;
            this.labelSurnameError.ForeColor = System.Drawing.Color.Red;
            this.labelSurnameError.Location = new System.Drawing.Point(159, 91);
            this.labelSurnameError.Name = "labelSurnameError";
            this.labelSurnameError.Size = new System.Drawing.Size(92, 15);
            this.labelSurnameError.TabIndex = 11;
            this.labelSurnameError.Text = "Неверный ввод";
            this.labelSurnameError.Visible = false;
            // 
            // labelBtnError
            // 
            this.labelBtnError.AutoSize = true;
            this.labelBtnError.ForeColor = System.Drawing.Color.Red;
            this.labelBtnError.Location = new System.Drawing.Point(82, 301);
            this.labelBtnError.Name = "labelBtnError";
            this.labelBtnError.Size = new System.Drawing.Size(137, 15);
            this.labelBtnError.TabIndex = 12;
            this.labelBtnError.Text = "Не все поля заполнены";
            this.labelBtnError.Visible = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(176, 265);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Visible = false;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 338);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.labelBtnError);
            this.Controls.Add(this.labelSurnameError);
            this.Controls.Add(this.labelNameError);
            this.Controls.Add(this.listGradeAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listSubjectAdd);
            this.Controls.Add(this.BtnCreateAdd);
            this.Controls.Add(this.txtSurnameAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNameAdd);
            this.Controls.Add(this.label1);
            this.Name = "AddStudent";
            this.Text = "Студент";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtNameAdd;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtSurnameAdd;
        public System.Windows.Forms.Button BtnCreateAdd;
        public System.Windows.Forms.ComboBox listSubjectAdd;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox listGradeAdd;
        public System.Windows.Forms.Label labelNameError;
        public System.Windows.Forms.Label labelSurnameError;
        public System.Windows.Forms.Label labelBtnError;
        public System.Windows.Forms.Button btnEdit;
    }
}