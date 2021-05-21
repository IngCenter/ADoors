using MySql.Data.MySqlClient;
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

            DoorsRefresh();
        }

        void DoorsRefresh()
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

        /// <summary>
        /// Выбор дверки
        /// </summary>
        private void SelectDoorInDGV(object sender, DataGridViewCellEventArgs e)
        {
            Id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            List<string> list = SQLClass.Select(
                "SELECT Name, Price FROM models WHERE id = " + Id);
            NameTextBox.Text = list[0];
            PriceTextBox.Text = list[1];

            Image image = SQLClass.SelectImages("SELECT Picture FROM models WHERE id = " + Id)[0];
            PhotoPB.Image = image;

            List<string> colors = SQLClass.Select(
                "SELECT DISTINCT Name" +
                " FROM colors JOIN model_colors ON colors.id = model_colors.color_id" +
                " WHERE model_colors.model_id = " + Id);
            for (int i = 0; i < ColorsCLB.Items.Count; i++)
            {
                ColorsCLB.SetItemChecked(i, colors.Contains(ColorsCLB.Items[i].ToString()));
            }
        }

        String Id = "";
        String Address = "";

        private void button1_Click(object sender, EventArgs e)
        {
            if (Id != "")
            {
                var pars = new List<MySqlParameter>() {
                    new MySqlParameter("Name", NameTextBox.Text),
                    new MySqlParameter("Price", PriceTextBox.Text) };

                SQLClass.Update("UPDATE models SET Name = ?Name, Price = ?Price WHERE Id = " + Id, pars);
            }
            //Новая дверь
            else
            {
                List<MySqlParameter> pars = new List<MySqlParameter>();
                pars.Add(new MySqlParameter("Name", NameTextBox.Text));
                pars.Add(new MySqlParameter("Price", PriceTextBox.Text));

                Id = SQLClass.Update("INSERT INTO models(Name, Price)" +
                    " VALUES(?Name, ?Price)", pars).ToString();
            }

            if (Address != "")
                SQLClass.UpdateImg("UPDATE models SET Picture = ?Image WHERE Id = " + Id, Address);

            SQLClass.Update("DELETE FROM model_colors WHERE door_id = " + Id);
            for (int i = 0; i < ColorsCLB.Items.Count; i++)
            {
                if (ColorsCLB.GetItemChecked(i))
                {
                    SQLClass.Update("INSERT INTO model_colors(model_id, color_id)" +
                        " SELECT " + Id + ", id FROM colors WHERE Name = '" + ColorsCLB.Items[i].ToString() + "'");
                }
            }

            MessageBox.Show("Сохранено");
            DoorsRefresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Id = "";
            Address = "";
            NameTextBox.Text = "";
            PriceTextBox.Text = "0";
            PhotoPB.Image = null;

            for (int i = 0; i < ColorsCLB.Items.Count; i++)
                ColorsCLB.SetItemChecked(i, false);
        }

        private void PhotoPB_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Address = openFileDialog1.FileName;
                PhotoPB.Load(Address);
            }
        }
    }
}
