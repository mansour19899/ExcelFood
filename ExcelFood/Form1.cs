using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelFood
{
    public partial class Form1 : Form
    {
        string filePath = "";
        PoonehEntities db = null;
        List<TraySchedule> list = new List<TraySchedule>();
        public Form1()
        {
            InitializeComponent();
            db = new PoonehEntities();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "File 1";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //save selected file name
                filePath = openFileDialog1.FileName;
                lblFilePath.Text = filePath;
                int x = 0;
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            //open excel
            Excel.Application xlApp = new Excel.Application();
            //open workbook
            Excel.Workbook workbook = xlApp.Workbooks.Open(filePath);
            //open sheet
            Excel._Worksheet sheet = workbook.Sheets[2];
            Excel.Range excelFile = sheet.UsedRange;
            // int row = int.Parse(txtRow.Text), column = int.Parse(txtColumn.Text);
            int row = 20, column = 5;

            

            bool x = true;
            int i = 1;
            while (x)
            {
                if (excelFile.Cells[i, 1].Value2 != null)
                {

                }
                else
                    x = false;
            }








            var t = excelFile.Cells[row, column];
            var tt = excelFile.Cells[row, column].Value2;
            var ttt = excelFile.Cells[row, column].Value;






            MessageBox.Show("Value:  " + excelFile.Cells[row, column].Value2.ToString());
            GC.Collect();
            GC.WaitForPendingFinalizers();
            ////release com objects to fully kill excel process from running in the background
            //Marshal.ReleaseComObject(excelFile);
            ////close and release
            ////workbook.Close();
            //Marshal.ReleaseComObject(workbook);
            ////quit and release
            //xlApp.Quit();
            //Marshal.ReleaseComObject(xlApp);


        }
    }
}
