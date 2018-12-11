using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_10
{
    public partial class FRiver : Form
    {
        public River TheRiver;

        public FRiver(River t)
        {
            TheRiver = t;
            InitializeComponent();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            TheRiver.Name = tB1.Text.Trim();
            TheRiver.Lenght = double.Parse(tB2.Text.Trim());
            TheRiver.Country = tB3.Text.Trim();
            TheRiver.Depth = double.Parse(tB4.Text.Trim());
            TheRiver.Height = double.Parse(tB6.Text.Trim());
            TheRiver.Bridge = double.Parse(tB5.Text.Trim());
            TheRiver.HasBridge = cB2.Checked;
            DialogResult = DialogResult.OK;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FRiver_Load(object sender, EventArgs e)
        {
            if (TheRiver != null)
            {
                tB1.Text = TheRiver.Name;
                tB2.Text = TheRiver.Lenght.ToString();
                tB3.Text = TheRiver.Country;
                tB4.Text = TheRiver.Depth.ToString();
                tB6.Text = TheRiver.Height.ToString("0.0");
                tB5.Text = TheRiver.Bridge.ToString("0.0");
                cB2.Checked = TheRiver.HasBridge;
            }
        }

        private void cB2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
