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
    public partial class AddCountryFrm : Form
    {
        private string login;
        int b;
        Countries model = new Countries();
        public AddCountryFrm(string login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            AddSpravochnikFrm addSpravochnikFrm = new AddSpravochnikFrm(login);
            this.Hide();
            addSpravochnikFrm.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                model.Id = b;
                model.Name = textBox1.Text;
                using (VDEntities db = new VDEntities())
                {
                    db.Countries.Add(model);
                    db.SaveChanges();
                    MessageBox.Show("Страна успешно добавлена!");
                    this.Hide();
                    AddSpravochnikFrm addSpravochnikFrm = new AddSpravochnikFrm(login);
                    addSpravochnikFrm.Show();
                }
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
}

        private void AddCountryFrm_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=VladCheremDiplom.mssql.somee.com;Initial Catalog=VladCheremDiplom;User ID=VladCherem_SQLLogin_1;Password=gn6l2nwhw4");
                SqlDataAdapter sda = new SqlDataAdapter("Select top 1 * from Countries order by Id DESC", con);
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
    }
}
