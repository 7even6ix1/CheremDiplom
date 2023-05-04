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
using System.Data.Entity;

namespace VladDiplom
{
    public partial class AddWorkerFrm : Form
    {
        Workers model = new Workers();
        LoginData loginData = new LoginData();
        int b = 0;
        
        private string login;
        private int code;

        public AddWorkerFrm(string login)
        {
            try
            {
                InitializeComponent();
                using (VDEntities db = new VDEntities())
                {
                    List<Gender> genders = db.Gender.ToList();
                    genderBox.DataSource = genders;
                    genderBox.DisplayMember = "Name";
                    genderBox.ValueMember = "Id";
                    List<Posts> posts = db.Posts.ToList();
                    postBox.DataSource = posts;
                    postBox.DisplayMember = "Name";
                    postBox.ValueMember = "Id";
                }

                this.login = login;
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                model.Id = b;
                model.Surname = surnameBox.Text;
                model.Name = nameBox.Text;
                model.Patronymic = patronymicBox.Text;
                model.Birthdate = dateBox.Value;
                model.Gender = (int)genderBox.SelectedValue;
                model.Post = (int)postBox.SelectedValue;
                model.Phone = phoneBox.Text;
                model.Address = addressBox.Text;
                using (VDEntities db = new VDEntities())
                {
                    db.Workers.Add(model);
                    db.SaveChanges();
                }

                loginData.Id = code;
                loginData.Login = loginBox.Text;
                loginData.Password = passBox.Text;
                loginData.Worker = b;
                using (VDEntities db = new VDEntities())
                {
                    db.LoginData.Add(loginData);
                    db.SaveChanges();
                }
                MessageBox.Show("Успешно!");
                WorkersInfoFrm workersInfoFrm = new WorkersInfoFrm(login);
                this.Hide();
                workersInfoFrm.Show();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }

        private void AddWorkerFrm_Load(object sender, EventArgs e)
        {
            try
            {
                postBox.DropDownHeight = 300;
                SqlConnection con = new SqlConnection("Data Source=VladCheremDiplom.mssql.somee.com;Initial Catalog=VladCheremDiplom;User ID=VladCherem_SQLLogin_1;Password=gn6l2nwhw4");
                SqlDataAdapter sda = new SqlDataAdapter("Select top 1 * from Workers order by Id DESC", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                string a = dt.Rows[0][0].ToString();
                b = Convert.ToInt32(a) + 1;
                SqlDataAdapter sda1 = new SqlDataAdapter("Select top 1 * from LoginData order by Id DESC", con);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                string a1 = dt1.Rows[0][0].ToString();
                code = Convert.ToInt32(a1) + 1;
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            try
            {
                WorkersInfoFrm workersInfoFrm = new WorkersInfoFrm(login);
                this.Hide();
                workersInfoFrm.Show();
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
