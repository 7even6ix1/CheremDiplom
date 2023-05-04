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
    public partial class AddSdelkaFrm : Form
    {
        int b;
        private string login;
        Sdelki model = new Sdelki();
        public AddSdelkaFrm(string login)
        {
            try
            {
                InitializeComponent();
                this.login = login;
                using (VDEntities db = new VDEntities())
                {
                    List<ClientCars> cars = db.ClientCars.ToList();
                    carBox.DataSource = cars;
                    carBox.ValueMember = "Id";
                    carBox.DisplayMember = "GosNomer";
                    List<Clients> clients = db.Clients.ToList();
                    phoneBox.DataSource = clients;
                    phoneBox.ValueMember = "Id";
                    phoneBox.DisplayMember = "Phone";
                }
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }

        private void AddSdelkaFrm_Load(object sender, EventArgs e)
        {
            try
            {
                phoneBox.DropDownHeight = 300;
                carBox.DropDownHeight = 300;
                SqlConnection con = new SqlConnection("Data Source=VladCheremDiplom.mssql.somee.com;Initial Catalog=VladCheremDiplom;User ID=VladCherem_SQLLogin_1;Password=gn6l2nwhw4");
                SqlDataAdapter sda = new SqlDataAdapter("Select top 1 * from Sdelki order by Id DESC", con);
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
            SdelkiFrm sdelkiFrm = new SdelkiFrm(login);
                this.Hide();
            sdelkiFrm.Show();
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
                model.Id = b;
                model.Car =(int)carBox.SelectedValue;
                model.Pokupatel = (int)phoneBox.SelectedValue;
                model.Date = dateTimePicker1.Value;
                model.Summa =Convert.ToDecimal(patrBox.Text);
                using (VDEntities db = new VDEntities())
                {
                    db.Sdelki.Add(model);
                    db.SaveChanges();
                    MessageBox.Show("Сделка успешно добавлена!");
                    this.Hide();
                    SdelkiFrm carsFrm = new SdelkiFrm(login);
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
