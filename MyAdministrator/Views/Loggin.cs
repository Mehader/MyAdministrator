using System;
using System.Windows.Forms;

namespace MyAdministrator
{
    public partial class Loggin : Form
    {
        public Loggin()
        {
            InitializeComponent();
        }

        #region ElementMethods

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (CheckLoggin())
            {
                Home homeForm = new Home();
                homeForm.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!");
            }

        }


        #endregion ElementMethods

        #region Methods

        private bool CheckLoggin()
        {
            Administrator admin = new Administrator();
            admin.Login = txtLogin.Text;
            admin.Password = txtPassword.Text;
            return DbHandler.CheckLoginPassword(admin);
        }

        #endregion

    }
}