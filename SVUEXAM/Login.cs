using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SVUEXAM
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Mangment.Exit();
        }

        private async void loginBtn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string passwordHash = PasswordHasher.HashPassword(password);
            string query = "SELECT * FROM [Users] WHERE Username = @Username AND PasswordHash = @PasswordHash";

            SqlParameter[] parameters = {
            new SqlParameter("@Username", SqlDbType.NVarChar) { Value = username },
            new SqlParameter("@PasswordHash", SqlDbType.NVarChar) { Value = passwordHash }};

            DataTable userTable = await SQL.ExecuteQueryAsync(query,false ,parameters);

            if (userTable != null && userTable.Rows.Count == 1)
            {
                Subject subject = new Subject(username);
                Mangment.Show_and_Hide(subject, this);
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtPassword_IconRightClick(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
