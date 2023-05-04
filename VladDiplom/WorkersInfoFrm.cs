using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VladDiplom
{
    public partial class WorkersInfoFrm : Form
    {
        private string login;
        public WorkersInfoFrm(string login)
        {
            this.login = login;
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=VladCheremDiplom.mssql.somee.com;Initial Catalog=VladCheremDiplom;User ID=VladCherem_SQLLogin_1;Password=gn6l2nwhw4");
                con.Open();
                string query = "Select * from WorkersView ";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();
                List<string[]> data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[10]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                    data[data.Count - 1][5] = reader[5].ToString();
                    data[data.Count - 1][6] = reader[6].ToString();
                    data[data.Count - 1][7] = reader[7].ToString();
                    data[data.Count - 1][8] = reader[8].ToString();
                    data[data.Count - 1][9] = reader[9].ToString();

                }
                reader.Close();
                con.Close();
                foreach (string[] s in data)
                    workersInfoPredDataGridView.Rows.Add(s);
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < workersInfoPredDataGridView.Rows.Count; i++)
                {
                    workersInfoPredDataGridView.Rows[i].Visible = workersInfoPredDataGridView[1, i].Value.ToString() == workerBox.Text;
                }
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < workersInfoPredDataGridView.Rows.Count; i++)
                {
                    workersInfoPredDataGridView.Rows[i].Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=VladCheremDiplom.mssql.somee.com;Initial Catalog=VladCheremDiplom;User ID=VladCherem_SQLLogin_1;Password=gn6l2nwhw4");
                con.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Workers WHERE Id =@pId", con);
                command.Parameters.Add(new SqlParameter("@pId", this.workersInfoPredDataGridView.CurrentRow.Cells["Id"].Value));
                command.ExecuteNonQuery();
                MessageBox.Show("Успешно!");
                workersInfoPredDataGridView.Rows.Clear();
                LoadData();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                AddWorkerFrm addWorkerFrm = new AddWorkerFrm(login);
                this.Hide();
                addWorkerFrm.Show();
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

        private void docBtn_Click(object sender, EventArgs e)
        {
            try
            {
                result = "\n                                  ИНФОРМАЦИЯ О СОТРУДНИКЕ \n \n";
                result += "Фамилия: " + workersInfoPredDataGridView.CurrentRow.Cells[1].Value.ToString() + "\n";
                result += "Имя: " + workersInfoPredDataGridView.CurrentRow.Cells[2].Value.ToString() + "\n";
                result += "Отчество: " + workersInfoPredDataGridView.CurrentRow.Cells[3].Value.ToString() + "\n";
                result += "Дата рождения: " + workersInfoPredDataGridView.CurrentRow.Cells[4].Value.ToString().Remove(11,7) + "\n";
                result += "Номер телефона: " + workersInfoPredDataGridView.CurrentRow.Cells[5].Value.ToString() + "\n";
                result += "Адрес: " + workersInfoPredDataGridView.CurrentRow.Cells[6].Value.ToString() + "\n";
                result += "Должность: " + workersInfoPredDataGridView.CurrentRow.Cells[7].Value.ToString() + "\n";
                result += "Размер заработной платы: " + workersInfoPredDataGridView.CurrentRow.Cells[8].Value.ToString() +" рублей" + "\n";
                result += "Пол: " + workersInfoPredDataGridView.CurrentRow.Cells[9].Value.ToString() + "\n";
                PrintDocument printDocument = new PrintDocument();
                printDocument.PrintPage += PrintPageHandler;
                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDocument;
                if (printDialog.ShowDialog() == DialogResult.OK)
                    printDialog.Document.Print();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }
        private string result;
        void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            try
            {
                e.Graphics.DrawString(result, new Font("Arial", 18), Brushes.Black, 0, 0);
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }
    }
}
