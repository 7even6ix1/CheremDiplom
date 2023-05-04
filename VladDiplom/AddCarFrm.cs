using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VladDiplom
{
    public partial class AddCarFrm : Form
    {
        private int numFrm;
        private string login;
        ClientCars model = new ClientCars();
        public AddCarFrm(int numFrm, string login)
        {
          this.numFrm = numFrm;
            this.login = login;
            
            InitializeComponent();
            using(VDEntities db = new VDEntities())
            {
                
                List<CarModels> carModels = db.CarModels.ToList();
                modelBox.DataSource=carModels;
                modelBox.DisplayMember = "Name";
                modelBox.ValueMember = "Id";
                List<Clients> clients = db.Clients.ToList();
                ownerBox.DataSource=clients;
                ownerBox.DisplayMember = "Surname";
                ownerBox.ValueMember = "Id";
                List<Sostoyanie> sostoyanies = db.Sostoyanie.ToList();
                sostBox.DataSource=sostoyanies;
                sostBox.DisplayMember = "Name";
                sostBox.ValueMember = "Id";
                List<Colors> colors = db.Colors.ToList();
                colorBox.DataSource=colors;
                colorBox.DisplayMember="Name";
                colorBox.ValueMember = "Id";
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (numFrm == 1)
                {
                    model.Model = (int)modelBox.SelectedValue;
                    model.GosNomer = gosNomerBox.Text;
                    model.VINNomer = VINBox.Text;
                    model.Owner = (int)ownerBox.SelectedValue;
                    model.Cost = Convert.ToInt32(costBox.Text);
                    model.Description = descBox.Text;
                    model.Sostoyanie = (int)sostBox.SelectedValue;
                    model.Color = (int)colorBox.SelectedValue;
                    model.OwnerCount = Convert.ToInt32(countOwnBox.Text);
                    using(VDEntities db = new VDEntities())
                    {
                        db.ClientCars.Add(model);
                        db.SaveChanges();
                    }
                    MessageBox.Show("Автомобиль успешно добавлен!");
                    ClientsFrm clientsFrm = new ClientsFrm(login);
                    this.Hide();
                    clientsFrm.Show();
                }
                else
                {
                    model.Model = (int)modelBox.SelectedValue;
                    model.GosNomer = gosNomerBox.Text;
                    model.VINNomer = VINBox.Text;
                    model.Owner = (int)ownerBox.SelectedValue;
                    model.Cost = Convert.ToInt32(costBox.Text);
                    model.Description = descBox.Text;
                    model.Sostoyanie = (int)sostBox.SelectedValue;
                    model.Color = (int)colorBox.SelectedValue;
                    model.OwnerCount = Convert.ToInt32(countOwnBox.Text);
                    using (VDEntities db = new VDEntities())
                    {
                        db.ClientCars.Add(model);
                        db.SaveChanges();
                    }
                    MessageBox.Show("Автомобиль успешно добавлен!");
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

        private void backBtn_Click(object sender, EventArgs e)
        {
            if(numFrm==1)
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
