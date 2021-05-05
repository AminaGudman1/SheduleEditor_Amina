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

            
        }

        private void dataGridShedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Audiences s = new Audiences();
            s.ShowDialog();
            dataGridShedule.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = s.number;
            
        }
    }
}
