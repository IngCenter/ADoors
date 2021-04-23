using System;
using System.Windows.Forms;

namespace ADoors
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ComputeButton_Click(object sender, EventArgs e)
        {
            new Door(
                (ModelId)Enum.Parse(typeof(ModelId), ModelChoice.SelectedItem.ToString()),
                (ColorId)Enum.Parse(typeof(ColorId), ColorChoice.SelectedItem.ToString()),
                TypeChoice.SelectedItem.ToString(),
                Convert.ToInt32(WidthChoice.Value),
                DoorHandleChoice.Checked,
                PlatbandChoice.Checked
            ).ComputeCost(Convert.ToInt32(DoorCountChoice.Value));
        }
    }
}
