using System;
using System.IO;
using System.Windows.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Core.ExcelPackage;

namespace UtilityLayer.Excel
{
    public class ExportToExcel
    {
        public ExportToExcel(DataGridView dataGridView)
        {
            using (SaveFileDialog SFD = new SaveFileDialog() { Filter = "Excel Document (*.xls) | *.xls|AllFile (*.*)|*.*",Title = "Save To..",})
            {
                SFD.FileName = "Themometer Data";
                if (SFD.ShowDialog() == DialogResult.OK)
                {
                    FileStream filestream = new FileStream(SFD.FileName, FileMode.Create);
                    ToXls(SFD, dataGridView, "Temprature", filestream);
                }
            }
        }
        private void ToXls(SaveFileDialog sfd, DataGridView dataGridView, string SheetName,FileStream filestream)
        {

            OfficeOpenXml.ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (OfficeOpenXml.ExcelPackage excelPackage = new OfficeOpenXml.ExcelPackage())
            {

                OfficeOpenXml.ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add(SheetName);

                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1].Value = dataGridView.Columns[i].HeaderText;
                }

                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j+1].Value = dataGridView.Rows[i].Cells[j].Value;
                    }
                }

                try
                {
                    //excelPackage.Save();
                    excelPackage.SaveAs(filestream);

                    MessageBox.Show("Save Done :)", "Saving...", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can;t Save file...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            
        }



    }
    
}
