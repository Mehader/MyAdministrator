using MyAdministrator.Models;
using System;


namespace MyAdministrator
{
    public static class HistoryStamp
    {
        /// <summary>
        /// записывает в историю операцию добавления
        /// </summary>
        /// <param name="entry">StudentSubject</param>
        /// <returns>History</returns>
        public static History CreateStudent(StudentSubject entry)
        {
            History history = new History();
            history.HistoryStamp = $"{DateTime.Now} добавил '{entry.Student.Name} {entry.Student.Surname} {entry.Subject.Title} {entry.Grade}'";
            return history;
        }

        /// <summary>
        /// записывает в историю операцию удаления
        /// </summary>
        /// <param name="entry">StudentSubject</param>
        /// <returns>History</returns>
        public static History DeleteStudent(StudentSubject entry)
        {
            History history = new History();
            history.HistoryStamp = $"{DateTime.Now} удалил '{entry.Student.Name} {entry.Student.Surname} {entry.Subject.Title} {entry.Grade}'";
            return history;
        }

        /// <summary>
        /// записывает в историю операцию обнавления
        /// </summary>
        /// <param name="entryOld">StudentSubject old</param>
        /// <param name="entryNew">StudentSubject new</param>
        /// <returns>History</returns>
        public static History UpdateStudent(StudentSubject entryOld, StudentSubject entryNew)
        {
            History history = new History();
            history.HistoryStamp = $"{DateTime.Now} обнавил '{entryOld.Student.Name} {entryOld.Student.Surname} {entryOld.Subject.Title} {entryOld.Grade}'" +
                $" на '{entryNew.Student.Name} {entryNew.Student.Surname} {entryNew.Subject.Title} {entryNew.Grade}'";
            return history;
        }

        /// <summary>
        /// записывает в историю операцию добавления
        /// </summary>
        /// <param name="entry">Subject</param>
        /// <returns>History</returns>
        public static History CreateSubject(Subject entry)
        {
            History history = new History();
            history.HistoryStamp = $"{DateTime.Now} добавил предмет '{entry.Title}'";
            return history;
        }

        /// <summary>
        /// записывает в историю операцию удаления
        /// </summary>
        /// <param name="title">название предмета</param>
        /// <returns>History</returns>
        public static History DeleteSubject(string title)
        {
            History history = new History();
            history.HistoryStamp = $"{DateTime.Now} удалил предмет '{title}'";
            return history;
        }
    }
}
