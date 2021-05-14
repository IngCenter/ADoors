using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ADoors
{
    public partial class MainForm : Form
    {
        string GetFirst(List<string> values)
        {
            return values[0];
        }
        int GetFirst(List<int> values)
        {
            return values[0];
        }


        Dictionary<string, Door> doors = new Dictionary<string, Door>();

        public MainForm()
        {
            GetFirst(new List<int> { 1, 3, 5 });

            InitializeComponent();
            LoadDoors();
        }

        public void LoadDoors()
        {
            doors = new Dictionary<string, Door>();
            List<string> list = SQLClass.Select(
                "SELECT Name, Price, Id FROM models ORDER BY id");
            List<Image> images = SQLClass.SelectImages("SELECT Picture FROM models ORDER BY id");

            ModelChoice.Items.Clear();
            for (int i = 0; i < list.Count; i += 3)
            {
                ModelChoice.Items.Add(list[i]);
                List<string> colors = SQLClass.Select(
                    "SELECT Name FROM colors JOIN model_colors ON colors.Id = model_colors.color_id WHERE model_id = " + list[i+2]);
                
                Door door = new Door
                {
                    BasePrice = Convert.ToInt32(list[i + 1]),
                    Model = list[i],
                    Picture = images[i / 3],
                    ColorsList = colors
                };

                doors.Add(door.Model, door);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SQLClass.CloseConnection();
        }

        private void ComputeButton_Click(object sender, EventArgs e)
        {
            try
            {
                Door door = doors[ModelChoice.Text];
                door.HasDoorhandle = DoorHandleChoice.Checked;
                door.HasPlatband = PlatbandChoice.Checked;
                door.Color = ColorChoice.Text;
                door.Width = Convert.ToInt32(WidthChoice.Value);
                door.Type = TypeChoice.Text;

                Pricelabel.Text = door.ComputeCost(Convert.ToInt32(DoorCountChoice.Value)).ToString() + " рублей";
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Некорректные значения!",
                    "Ошибка ввода данных",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void ModelChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ModelChoice.Text != "")
                    DoorPB.Image = doors[ModelChoice.Text].Picture;
            }
            catch (Exception) { }
            
            if (ModelChoice.Text != "" && ColorChoice.Text != "")
                ComputeButton_Click(sender, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoginPanel.Visible = !LoginPanel.Visible;
        }

        public static string EncryptPassword(string Password)
        {
            var data = Encoding.UTF8.GetBytes(Password);
            SHA512 shaM = new SHA512Managed();
            var hashedInputBytes = shaM.ComputeHash(data);
            var hashedInputStringBuilder = new StringBuilder(128);
            foreach (var b in hashedInputBytes)
                hashedInputStringBuilder.Append(b.ToString("X2"));
            shaM.Dispose();
            return hashedInputStringBuilder.ToString();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (LoginTB.Text == "Admin" && 
                EncryptPassword(PasswordTB.Text) == "3C9909AFEC25354D551DAE21590BB26E38D53F2173B8D3DC3EEE4C047E7AB1C1EB8B85103E3BE7BA613B31BB5C9C36214DC9F14A42FD7A2FDB84856BCA5C44C2")
            {
                new AdminDoors().ShowDialog();
                LoadDoors();
            }
        }
    }
}
