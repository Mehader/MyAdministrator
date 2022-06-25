using System.Linq;
using System.Windows.Forms;

namespace MyAdministrator
{
    public static class DbHandler
    {

        public delegate void RefreshTable();

        /// <summary>
        /// делегат для обнавления таблицы
        /// </summary>
        public static RefreshTable? refreshTable;

        /// <summary>
        /// удаляет запись в таблице
        /// </summary>
        /// <param name="id">id записи</param>
        /// <returns>bool</returns>
        public static bool DeleteStudent(StudentSubject entry)
        {
            using (Context db = new Context())
            {
                try
                {
                    db.Students.Remove(db.Students.Find(entry.Id));
                    db.History.Add(HistoryStamp.DeleteStudent(entry));
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    MessageBox.Show("Что-то пошло не так!");
                    return false;
                }
            }
        }

        /// <summary>
        /// обнавляет запись в таблице
        /// </summary>
        /// <param name="entry">новая запись</param>
        /// <returns>bool</returns>
        public static bool UpdateStudent(StudentSubject entryNew, StudentSubject entryOld)
        {
            using (Context db = new Context())
            {
                try
                {
                    StudentSubject entryStudent = (from studentSubject in db.StudentsSubjects
                                                   join student in db.Students on studentSubject.StudentId equals student.Id
                                                   join subject in db.Subjects on studentSubject.SubjectId equals subject.Id
                                                   where student.Id == entryNew.Id
                                                   select studentSubject).First();

                    db.Students.Find(entryStudent.StudentId).Name = entryNew.Student.Name;
                    db.Students.Find(entryStudent.StudentId).Surname = entryNew.Student.Surname;

                    var subjectId = db.Subjects.Where(s => s.Title == entryNew.Subject.Title).First().Id;

                    entryStudent.SubjectId = subjectId;
                    entryStudent.Grade = entryNew.Grade;

                    db.History.Add(HistoryStamp.UpdateStudent(entryOld, entryNew));

                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    MessageBox.Show("Что-то пошло не так!");
                    return false;
                }
            }
        }

        /// <summary>
        ///  создает запись в таблице
        /// </summary>
        /// <param name="entry">созданая запись</param>
        /// <returns>bool</returns>
        public static bool CreateStudent(StudentSubject entry)
        {
            using (Context db = new Context())
            {
                try
                {
                    // ищем такую же запись в бд
                    var existStudent = db.StudentsSubjects.Where(s => s.Student.Name == entry.Student.Name
                                                             && s.Student.Surname == entry.Student.Surname
                                                             && s.Subject.Title == entry.Subject.Title);

                    // проверяем результат существующей записи
                    if (!existStudent.Any())
                    {
                        StudentSubject student = new StudentSubject();
                        student.Student = entry.Student;
                        student.SubjectId = db.Subjects.Where(s => s.Title == entry.Subject.Title).First().Id;
                        student.Grade = entry.Grade;

                        db.StudentsSubjects.Add(student);
                        db.History.Add(HistoryStamp.CreateStudent(student));
                        db.SaveChanges();

                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Запись уже существует");
                        return false;
                    }
                }
                catch
                {
                    MessageBox.Show("Что-то пошло не так!");
                    return false;
                }
            }
        }

        /// <summary>
        /// заполняет лист combobox
        /// </summary>
        /// <param name="list">combobox</param>
        public static void InitComboBox(ComboBox list)
        {
            list.Items.Clear();
            using (Context db = new Context())
            {
                try
                {
                    foreach (var item in db.Subjects)
                    {
                        list.Items.Add(item.Title);
                    }
                }
                catch
                {
                    MessageBox.Show("Что-то пошло не так!");
                }
            }
        }

        /// <summary>
        /// создает новый предмет
        /// </summary>
        /// <param name="subject">предмет</param>
        /// <returns>bool</returns>
        public static bool CreateSubject(Subject subject)
        {
            using (Context db = new Context())
            {
                try
                {
                    db.Subjects.Add(subject);
                    db.History.Add(HistoryStamp.CreateSubject(subject));
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    MessageBox.Show("Что-то пошло не так!");
                    return false;
                }

            }

        }

        /// <summary>
        /// удаляет предмет
        /// </summary>
        /// <param name="title">предмет</param>
        /// <returns>bool</returns>
        public static bool DelSubject(string title)
        {
            using (Context db = new Context())
            {
                try
                {
                    db.Subjects.Remove(db.Subjects.Where(s => s.Title == title).First());
                    db.History.Add(HistoryStamp.DeleteSubject(title));
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    MessageBox.Show("Что-то пошло не так!");
                    return false;
                }
            }
        }

        /// <summary>
        /// проверяет логин и пароль
        /// </summary>
        /// <param name="admin">администратор</param>
        /// <returns>bool</returns>
        public static bool CheckLoginPassword(Administrator admin)
        {
            using (Context db = new Context())
            {
                try
                {
                    var administrator = (from a in db.Administrators
                                         where a.Password == admin.Password && a.Login == admin.Login
                                         select a).FirstOrDefault();

                    return administrator != null ? true:false;
                }
                catch
                {
                    MessageBox.Show("Что-то пошло не так!");
                    return false;
                }
            }
        }
    }
}