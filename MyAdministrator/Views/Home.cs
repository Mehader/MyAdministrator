using System;
using System.Linq;
using System.Windows.Forms;

namespace MyAdministrator
{
    public partial class Home : Form
    {
        // обьекты для кнопок в колонке
        private DataGridViewButtonColumn btnColumnDel = new DataGridViewButtonColumn();
        private DataGridViewButtonColumn btnColumnEdit = new DataGridViewButtonColumn();

        // проверка textbox
        bool isTxtSubject = false;

        public Home()
        {
            InitializeComponent();
            DbHandler.refreshTable = null;
            DbHandler.refreshTable += InitTable;
            DbHandler.refreshTable += InitHistory;
            DbHandler.refreshTable?.Invoke();


            // создаем кнопки в колонке
            btnColumnEdit.Text = "изменить";
            btnColumnEdit.UseColumnTextForButtonValue = true;
            gridStudents.Columns.Add(btnColumnEdit);

            btnColumnDel.Text = "удалить";
            btnColumnDel.UseColumnTextForButtonValue = true;
            gridStudents.Columns.Add(btnColumnDel);

            // заполняем combobox
            DbHandler.InitComboBox(listSubject);

            // пряем ошибку
            labelSubjectError.Visible = false;

        }

        #region ElementMethods

        private void btnSearch1_Click(object sender, EventArgs e)
        {
            InitTableSearch(txtSearch.Text);
            txtSearch.Text = "";
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            AddStudent addStudentForm = new AddStudent();
            addStudentForm.Show();
        }

        private void gridStudents_btnClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentSubject entry = ReaderFieldEntry(e);

            // проверка кнопки удалить
            if (e.ColumnIndex == 6)
            {
                if (DbHandler.DeleteStudent(entry))
                {
                    DbHandler.refreshTable();
                    MessageBox.Show($"Удален(а): {entry.Student.Name} {entry.Student.Surname}");
                }
            }

            // проверка кнопки изменить
            if (e.ColumnIndex == 5)
            {
                AddStudent editStudentForm = new AddStudent();
                editStudentForm.Show();
                editStudentForm.txtNameAdd.Text = entry.Student.Name;
                editStudentForm.txtSurnameAdd.Text = entry.Student.Surname;
                editStudentForm.listSubjectAdd.Text = entry.Subject.Title;
                editStudentForm.listGradeAdd.Text = entry.Grade.ToString();

                editStudentForm.btnEdit.Visible = true;
                editStudentForm.BtnCreateAdd.Visible = false;


                void UpdateEntry(object? sender, EventArgs e)
                {

                    Student student = new Student();
                    student.Name = entry.Student.Name;
                    student.Surname = entry.Student.Surname;

                    Subject subject = new Subject();
                    subject.Title = entry.Subject.Title;

                    StudentSubject entryOld = new StudentSubject();
                    entryOld.Student = student;
                    entryOld.Subject = subject;
                    entryOld.Grade = entry.Grade;



                    entry.Student.Name = editStudentForm.txtNameAdd.Text;
                    entry.Student.Surname = editStudentForm.txtSurnameAdd.Text;
                    entry.Subject.Title = editStudentForm.listSubjectAdd.Text;
                    entry.Grade = Convert.ToInt32(editStudentForm.listGradeAdd.Text);

                    if (DbHandler.UpdateStudent(entry, entryOld))
                    {
                        DbHandler.refreshTable?.Invoke();
                        MessageBox.Show($"Запись изменина");
                    };

                }
                editStudentForm.btnEdit.Click += UpdateEntry;
            }
        }

        private void btnSubjectAdd_Click(object sender, EventArgs e)
        {
            if (isTxtSubject)
            {
                Subject subject = new Subject() { Title = txtNewSubject.Text };
                if (DbHandler.CreateSubject(subject))
                {
                    DbHandler.InitComboBox(listSubject);
                    DbHandler.refreshTable?.Invoke();
                    txtNewSubject.Clear();
                    MessageBox.Show("Новый предмет добавлен");
                }
            }
            else
            {
                labelSubjectError.Visible = true;
            }
        }

        private void btnSubjectDel_Click(object sender, EventArgs e)
        {
            string title = listSubject.SelectedItem.ToString() ?? string.Empty;

            if (DbHandler.DelSubject(title))
            {
                DbHandler.InitComboBox(listSubject);
                DbHandler.refreshTable?.Invoke();
                MessageBox.Show($"Предмет {title} удален");
            }
        }

        private void txtNewSubject_TextChanged(object sender, EventArgs e)
        {
            isTxtSubject = Validation.TxtCheck(txtNewSubject, labelSubjectError);
        }

        #endregion ElementMethods

        #region Methods

        // считываем запись таблицы
        private StudentSubject ReaderFieldEntry(DataGridViewCellEventArgs e)
        {

            Student student = new Student();
            student.Name = gridStudents.Rows[e.RowIndex].Cells[1].Value.ToString();
            student.Surname = gridStudents.Rows[e.RowIndex].Cells[2].Value.ToString();

            Subject subject = new Subject();
            subject.Title = gridStudents.Rows[e.RowIndex].Cells[3].Value.ToString();

            StudentSubject entry = new StudentSubject();
            entry.Id = Convert.ToInt32(gridStudents.Rows[e.RowIndex].Cells[0].Value);
            entry.Student = student;
            entry.Subject = subject;
            entry.Grade = Convert.ToInt32(gridStudents.Rows[e.RowIndex].Cells[4].Value);

            return entry;
        }

        // заполняем таблицу
        private void InitTable()
        {
            using (Context db = new Context())
            {
                try
                {
                    var students = from studentSubject in db.StudentsSubjects
                                   join student in db.Students on studentSubject.StudentId equals student.Id
                                   join subject in db.Subjects on studentSubject.SubjectId equals subject.Id
                                   select new
                                   {
                                       Id = student.Id,
                                       Name = student.Name,
                                       Surname = student.Surname,
                                       Subject = subject.Title,
                                       Grade = studentSubject.Grade,
                                   };
                    gridStudents.Rows.Clear();
                    foreach (var item in students)
                    {
                        gridStudents.Rows.Add($"{item.Id}", $"{item.Name}", $"{item.Surname}", $"{item.Subject}", $"{item.Grade}");
                    }
                }
                catch
                {
                    MessageBox.Show("Что-то пошло не так!");
                }

            }
        }

        // заполняем таблицу поиска
        private void InitTableSearch(string text)
        {
            using (Context db = new Context())
            {
                try
                {
                    var students = from studentSubject in db.StudentsSubjects
                                   join student in db.Students on studentSubject.StudentId equals student.Id
                                   join subject in db.Subjects on studentSubject.SubjectId equals subject.Id
                                   where student.Name.Contains(text) || student.Surname.Contains(text)
                                   select new
                                   {
                                       Id = student.Id,
                                       Name = student.Name,
                                       Surname = student.Surname,
                                       Subject = subject.Title,
                                       Grade = studentSubject.Grade,
                                   };
                    gridStudents.Rows.Clear();
                    foreach (var item in students)
                    {
                        gridStudents.Rows.Add($"{item.Id}", $"{item.Name}", $"{item.Surname}", $"{item.Subject}", $"{item.Grade}");
                    }
                }
                catch
                {
                    MessageBox.Show("Что-то пошло не так!");
                }

            }
        }

        // заполняем историю
        private void InitHistory()
        {
            txtHistory.Clear();
            using (Context db = new Context())
            {
                try
                {
                    foreach (var item in db.History)
                    {
                        txtHistory.Text += item.HistoryStamp + Environment.NewLine;
                    }
                }
                catch
                {
                    MessageBox.Show("Что-то пошло не так!");
                }

            }
        }
        #endregion Methods


    }
}