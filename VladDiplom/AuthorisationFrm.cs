using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VladDiplom
{
    public partial class AuthorisationFrm : Form
    {
        public AuthorisationFrm()
        {
            InitializeComponent();
        }
        private string login;
        private string role;

        private void enterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=VladCheremDiplom.mssql.somee.com;Initial Catalog=VladCheremDiplom;User ID=VladCherem_SQLLogin_1;Password=gn6l2nwhw4");
                SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from LoginData where Login='" + loginBox.Text + "' and Password='" + passBox.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                SqlDataAdapter sdaId = new SqlDataAdapter("Select Worker from LoginData where Login='" + loginBox.Text + "'", con);
                DataTable dtId = new DataTable();
                sdaId.Fill(dtId);
                string workerId = dtId.Rows[0][0].ToString();
                SqlDataAdapter sda1 = new SqlDataAdapter("Select Post from Workers where Id='" + workerId + "'", con);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                string postId = dt1.Rows[0][0].ToString();
                SqlDataAdapter sdaPost = new SqlDataAdapter("Select Name from Posts where Id='" + postId + "'", con);
                DataTable dtPost = new DataTable();
                sda1.Fill(dtPost);
                if (dt.Rows[0][0].ToString()=="1")
                {
                    login = workerId;
                    MenuFrm menuFrm = new MenuFrm(login);
                    this.Hide();
                    menuFrm.Show();
                }
                else
                {
                    errorBox.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка. Проверьте правильность введённых данных.");
            }
        }

        private void seePassBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (passBox.UseSystemPasswordChar == true)
                {
                    passBox.UseSystemPasswordChar = false;
                }
                else
                {
                    passBox.UseSystemPasswordChar = true;
                }
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Minimized;
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }
    }
}
