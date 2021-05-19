using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADoors
{
    public partial class AdminDoors : Form
    {
        public AdminDoors()
        {
            InitializeComponent();

            List<string> colors = SQLClass.Select("SELECT DISTINCT Name FROM colors ORDER BY Name");
            ColorsCLB.Items.AddRange(colors.ToArray());

            Refresh();
        }
        void Refresh()
        { 
            List<string> list = SQLClass.Select(
                "SELECT Id, Name, Price FROM models ORDER BY id");

            dataGridView1.Rows.Clear();
            for (int i = 0; i < list.Count; i+= 3)
            {
                object[] row = new object[3];
                row[0] = list[i];
                row[1] = list[i + 1];
                row[2] = list[i + 2];
                dataGridView1.Rows.Add(row);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            List<string> list = SQLClass.Select(
                "SELECT Name, Price FROM models WHERE id = " + Id);
            Image image = SQLClass.SelectImages("SELECT Picture FROM models WHERE id = " + Id)[0];

            NameTextBox.Text = list[0];
            PriceTextBox.Text = list[1];
            PhotoPB.Image = image;
        }

        String Id = "";
        String Address = "";

        private void button1_Click(object sender, EventArgs e)
        {
            if (Id != "")
            {
                var pars = new List<MySql.Data.MySqlClient.MySqlParameter>() {
                    new MySql.Data.MySqlClient.MySqlParameter("Name", NameTextBox.Text),
                    new MySql.Data.MySqlClient.MySqlParameter("Price", PriceTextBox.Text) };

                SQLClass.Update("UPDATE models SET Name = @Name, Price = @Price WHERE Id = " + Id, pars);

                MessageBox.Show("Обновлено");
                Refresh();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Id = "";
        }
    }
}
