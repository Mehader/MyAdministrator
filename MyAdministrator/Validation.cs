using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MyAdministrator
{
    public static class Validation
    {
        /// <summary>
        /// проверка строки на наличие только букв
        /// </summary>
        /// <param name="textBox">строка</param>
        /// <returns>bool</returns>
        public static bool TextValidation(TextBox textBox)
        {
            Regex regex = new Regex(@"^[a-zA-Zа-яА-Я]+$");

            return regex.IsMatch(textBox.Text) ? true : false;
        }

        /// <summary>
        /// проверяет и выдает ошибку
        /// </summary>
        /// <param name="textBox">textbox</param>
        /// <param name="label">label для ошибки</param>
        /// <returns>bool</returns>
        public static bool TxtCheck(TextBox textBox, Label label)
        {
            if (textBox.Text == "")
            {
                label.Visible = false;
                textBox.ForeColor = System.Drawing.Color.Black;
                return false;
            }
            else if (!TextValidation(textBox))
            {
                label.Visible = true;
                textBox.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            else
            {
                label.Visible = false;
                textBox.ForeColor = System.Drawing.Color.Black;
                return true;
            }
        }


        public static bool TxtLoginAdd()
        { return false; }

        public static bool TxtPasswordAdd()
        { return false; }
    }
}