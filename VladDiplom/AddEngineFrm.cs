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
using static VladDiplom.VladCheremDiplomDataSet;

namespace VladDiplom
{
    public partial class AddEngineFrm : Form
    {
        private string login;
        int b;
        public AddEngineFrm(string login)
        {
            try
            {
                InitializeComponent();
                this.login = login;
                using (VDEntities db = new VDEntities())
                {
                    List<EngineTypes> engineTypes = db.EngineTypes.ToList();
                    typeBox.DataSource = engineTypes;
                    typeBox.DisplayMember = "Type";
                    typeBox.ValueMember = "Id";
                    List<EngineVolume> engineVolumes = db.EngineVolume.ToList();
                    volumeBox.DataSource = engineVolumes;
                    volumeBox.DisplayMember = "Volume";
                    volumeBox.ValueMember = "Id";
                    List<FuelType> fuelTypes = db.FuelType.ToList();
                    fuelBox.DataSource = fuelTypes;
                    fuelBox.DisplayMember = "Type";
                    fuelBox.ValueMember = "Id";
                }
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

        private void AddEngineFrm_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=VladCheremDiplom.mssql.somee.com;Initial Catalog=VladCheremDiplom;User ID=VladCherem_SQLLogin_1;Password=gn6l2nwhw4");
                SqlDataAdapter sda = new SqlDataAdapter("Select top 1 * from Engines order by Id DESC", con);
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

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Engines model = new Engines();
                model.Id = b;
                model.Name = nameBox.Text;
                model.Type = (int)typeBox.SelectedValue;
                model.Volume = (int)volumeBox.SelectedValue;
                model.Fuel = (int)fuelBox.SelectedValue;
                model.Cilinders = Convert.ToInt32(cylindersBox.Text);
                using (VDEntities db = new VDEntities())
                {
                    db.Engines.Add(model);
                    db.SaveChanges();
                    this.Hide();
                    AddSpravochnikFrm addSpravochnikFrm = new AddSpravochnikFrm(login);
                    addSpravochnikFrm.Show();
                }
                MessageBox.Show("Двигатель успешно добавлен!");
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }
    }
}
