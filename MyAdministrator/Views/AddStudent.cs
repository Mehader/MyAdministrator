using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAdministrator
{
    public partial class AddStudent : Form
    {
        private bool isName = false;
        private bool isSurname = false;

        public AddStudent()
        {
            InitializeComponent();
            DbHandler.InitComboBox(listSubjectAdd);
            btnEdit.Visible = false;
            BtnCreateAdd.Visible = true;
        }

        #region ElementMethods

        private void txtNameAdd_TextChanged(object sender, EventArgs e)
        {
            this.isName = Validation.TxtCheck(txtNameAdd, labelNameError);
        }

        private void txtSurnameAdd_TextChanged(object sender, EventArgs e)
        {
            this.isSurname = Validation.TxtCheck(txtSurnameAdd, labelSurnameError);
        }

        private void BtnCreateAdd_Click(object sender, EventArgs e)
        {
            AllCheck();
        }

        #endregion ElementMethods

        #region Methods

        // проверка всех заполненых полей
        private void AllCheck()
        {
            if (isName == true
                && isSurname == true
                && listSubjectAdd.SelectedIndex > -1
                && listGradeAdd.SelectedIndex > -1)
            {
                labelBtnError.Visible = false;

                if (DbHandler.CreateStudent(ReaderFieldEntry()))
                {
                    DbHandler.refreshTable?.Invoke();
                    MessageBox.Show("Студент добавлен");
                }


            }
            else
            {
                ShowErrorAsync();
            }
        }

        // всплывающая подсказка(ошибка заполненой записи)
        private async Task ShowErrorAsync()
        {
            labelBtnError.Visible = true;
            await Task.Delay(1000);
            labelBtnError.Visible = false;
        }

        // считываем данные с записи
        private StudentSubject ReaderFieldEntry()
        {
            Student student = new Student()
            {
                Name = txtNameAdd.Text,
                Surname = txtSurnameAdd.Text
            };

            Subject subject = new Subject() { Title = listSubjectAdd.Text };

            StudentSubject entry = new StudentSubject()
            {
                Student = student,
                Subject = subject,
                Grade = Convert.ToInt32(listGradeAdd.Text)
            };

            return entry;
        }

        #endregion Methods


    }
}