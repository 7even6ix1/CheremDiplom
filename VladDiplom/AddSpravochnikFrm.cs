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
    public partial class AddSpravochnikFrm : Form
    {
        private string login;
        public AddSpravochnikFrm(string login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MenuFrm menuFrm = new MenuFrm(login);
                this.Hide();
                menuFrm.Show();
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
                AddColorFrm addColorFrm = new AddColorFrm(login);
                this.Hide();
                addColorFrm.Show();
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
                AddCountryFrm addCountryFrm = new AddCountryFrm(login);
                this.Hide();
                addCountryFrm.Show();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                AddPostFrm addPostFrm = new AddPostFrm(login);
                this.Hide();
                addPostFrm.Show();
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
                AddMarkFrm addMarkFrm = new AddMarkFrm(login);
                this.Hide();
                addMarkFrm.Show();
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
                AddEngineFrm addEngineFrm = new AddEngineFrm(login);
                this.Hide();
                addEngineFrm.Show();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }
    }
}
