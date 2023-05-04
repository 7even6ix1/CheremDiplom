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
    public partial class AddMarkFrm : Form
    {
        int b;
        private string login;
        public AddMarkFrm(string login)
        {
            this.login = login;
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            try
            {
                AddSpravochnikFrm addSpravochnikFrm = new AddSpravochnikFrm(login);
                this.Hide();
                addSpravochnikFrm.Show();
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Marks model = new Marks();
                model.Name = textBox1.Text;
                model.Id = b;
                using (VDEntities db = new VDEntities())
                {
                    db.Marks.Add(model);
                    db.SaveChanges();
                    MessageBox.Show("Марка успешно добавлена!");
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

        private void AddMarkFrm_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=VladCheremDiplom.mssql.somee.com;Initial Catalog=VladCheremDiplom;User ID=VladCherem_SQLLogin_1;Password=gn6l2nwhw4");
                SqlDataAdapter sda = new SqlDataAdapter("Select top 1 * from Marks order by Id DESC", con);
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
