using DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilityLayer.Excel;

namespace Thermometer_APP.ViewData
{
    public partial class frmVeiwData : Form
    {
        public frmVeiwData()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVeiwData_Load(object sender, EventArgs e)
        {
            DbContext db = new DbContext();
            var data = db.GetAllData();
            foreach (var item in data)
            {
                dgvData.Rows.Add(item.temperature, item.humidity, item.Wetness, item.DataTime);
            }
            db.Dispose();
        }

        private void btnConvertToExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel ex = new ExportToExcel(dgvData);
        }

        private void dgvData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //dgvData.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
            dgvData.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            
        }
    }
}
