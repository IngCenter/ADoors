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
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
