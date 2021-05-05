using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SheduleEditor_Amina
{
    public partial class SheduleEditor : Form
    {
        public SheduleEditor()
        {
            InitializeComponent();
        }

        private void SheduleEditor_Load(object sender, EventArgs e)
        {
            dataGridShedule.RowTemplate.Height = 50;
            dataGridShedule.Rows.Add();
            dataGridShedule.Rows.Add();
            dataGridShedule.Rows.Add();
            dataGridShedule.Rows.Add();
            dataGridShedule.Rows.Add();

            dataGridShedule.Rows[0].Cells[0].Value = "1";
            dataGridShedule.Rows[1].Cells[0].Value = "2";
            dataGridShedule.Rows[2].Cells[0].Value = "3";
            dataGridShedule.Rows[3].Cells[0].Value = "4";
            dataGridShedule.Rows[4].Cells[0].Value = "5";
        }

        private void dataGridShedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Audiences s = new Audiences();
            s.ShowDialog();
            dataGridShedule.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = s.number;
        }
    }
}
