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
    public partial class WikiRiver : Form
    {
        public WikiRiver()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dGV1.AutoGenerateColumns = false;
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.Name = "Назва";
            dGV1.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Lenght";
            column.Name = "Довжина";
            dGV1.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Country";
            column.Name = "Країна";
            dGV1.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Depth";
            column.Name = "Глибина";
            dGV1.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Height";
            column.Name = "Висота";
            column.Width = 120;
            dGV1.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Bridge";
            column.Name = "К-сть мостів";
            column.Width = 80;
            dGV1.Columns.Add(column);
            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "HasBridge";
            column.Name = "Міст";
            column.Width = 60;
            dGV1.Columns.Add(column);


            bindSrcRivers.Add(new River("Буг", 123, "Україна", 800,
            2000, 3, true));

            EventArgs args = new EventArgs();
            OnResize(args);
        }

        private void tlB1_Click(object sender, EventArgs e)
        {
            River river = new River();
            FRiver fr = new FRiver(river);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                bindSrcRivers.Add(river);
            }
        }

        private void tlB2_Click(object sender, EventArgs e)
        {
            River river = (River)bindSrcRivers.List[bindSrcRivers.Position];
            FRiver ft = new FRiver(river);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                bindSrcRivers.List[bindSrcRivers.Position] = river;
            }
        }

        private void tlB3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Видалити поточний запис?",
                "Видалення запису", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bindSrcRivers.RemoveCurrent();
            }
        }

        private void tlB4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Очистити таблицю?\n\nВсі дані будуть втрачені",
                "Очищення даних", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bindSrcRivers.Clear();
            }
        }

        private void tlB5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити застосунок?", "Вихід з програми",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
