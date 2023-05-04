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
    public partial class AddColorFrm : Form
    {
        private string login;
        Colors model = new Colors();
        public AddColorFrm(string login)
        {
            InitializeComponent();
            this.login = login;
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

        private void enterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                model.Name = textBox1.Text;
                model.Description = textBox2.Text;
                using (VDEntities db = new VDEntities())
                {
                    db.Colors.Add(model);
                    db.SaveChanges();
                    MessageBox.Show("Цвет успешно добавлен!");
                    this.Hide();
                    AddSpravochnikFrm addSpravochnikFrm = new AddSpravochnikFrm(login);
                    addSpravochnikFrm.Show();
                }
            }
            catch
            {
                MessageBox.Show("Возникла ошибка.");
            }
        }
    }
}
