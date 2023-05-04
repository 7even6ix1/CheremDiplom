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

    public partial class AddClientFrm : Form
    {
        private int numFrm;
        private string login;
        int b;
        Clients model = new Clients();
        public AddClientFrm(int numFrm, string login)
        {
            InitializeComponent();
            this.login=login;
            this.numFrm = numFrm;
            using(VDEntities db = new VDEntities())
            {
                List<Gender> genders = db.Gender.ToList();
                genderBox.DataSource = genders;
                genderBox.DisplayMember = "Name";
                genderBox.ValueMember = "Id";
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

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (numFrm == 1)
                {
                    model.Id = b;
                    model.Surname = surnameBox.Text;
                    model.Name = nameBox.Text;
                    model.Patronymic = patrBox.Text;
                    model.Phone = phoneBox.Text;
                    model.Gender = (int)genderBox.SelectedValue;
                    using (VDEntities db = new VDEntities())
                    {
                        db.Clients.Add(model);
                        db.SaveChanges();
                        MessageBox.Show("Клиент успешно сохранён");
                        this.Hide();
                        CarsFrm carsFrm = new CarsFrm(login);
                        carsFrm.Show();
                    }
                }
                else if (numFrm == 2)
                {
                    model.Id = b;
                    model.Surname = surnameBox.Text;
                    model.Name = nameBox.Text;
                    model.Patronymic = patrBox.Text;
                    model.Phone = phoneBox.Text;
                    model.Gender = (int)genderBox.SelectedValue;
                    using (VDEntities db = new VDEntities())
                    {
                        db.Clients.Add(model);
                        db.SaveChanges();
                        MessageBox.Show("Клиент успешно сохранён");
                        this.Hide();
                        ClientsFrm requestCreatingFrm = new ClientsFrm(login);
                        requestCreatingFrm.Show();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }

        private void AddClientFrm_Load(object sender, EventArgs e)
        {
            try
            {
                genderBox.DropDownHeight = 300;
                SqlConnection con = new SqlConnection("Data Source=VladCheremDiplom.mssql.somee.com;Initial Catalog=VladCheremDiplom;User ID=VladCherem_SQLLogin_1;Password=gn6l2nwhw4");
                SqlDataAdapter sda = new SqlDataAdapter("Select top 1 * from Clients order by Id DESC", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                string a = dt.Rows[0][0].ToString();
                b = Convert.ToInt32(a) + 1;
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
                if (numFrm == 2)
                {
                    ClientsFrm clientsFrm = new ClientsFrm(login);
                    this.Hide();
                    clientsFrm.Show();
                }
                else
                {
                    CarsFrm carsFrm = new CarsFrm(login);
                    this.Hide();
                    carsFrm.Show();
                }
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }
    }
}
