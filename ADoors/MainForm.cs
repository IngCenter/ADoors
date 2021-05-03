﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ADoors
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            List<string> list = SQLClass.Select("SELECT Name, Price, Mass, Id FROM doors");
            List<Image> images = SQLClass.SelectImages("SELECT Image FROM doors");
        }

        private void ComputeButton_Click(object sender, EventArgs e)
        {
            try
            {
                Door door = new Door(
                    (ModelId)Enum.Parse(typeof(ModelId), ModelChoice.Text.ToString()),
                    (ColorId)Enum.Parse(typeof(ColorId), ColorChoice.Text.ToString()),
                    TypeChoice.Text.ToString(),
                    Convert.ToInt32(WidthChoice.Value),
                    DoorHandleChoice.Checked,
                    PlatbandChoice.Checked
                );
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
            if (ModelChoice.Text != "" && ColorChoice.Text != "")
                ComputeButton_Click(sender, e);
        }
    }
}
