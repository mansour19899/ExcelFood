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
        string filePath = "D:\\projects\\ExcelFood\\Book1.xlsx";
        PoonehEntities db = null;
        List<TraySchedule> list = new List<TraySchedule>();
        List<Food> ListFood;
        bool AllowSave = true;
        public Form1()
        {
            InitializeComponent();
            db = new PoonehEntities();

           ListFood = db.Foods.ToList();
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
            AllowSave = true;
            list.Clear();
            //open excel
            Excel.Application xlApp = new Excel.Application();
            //open workbook
            Excel.Workbook workbook = xlApp.Workbooks.Open(filePath);
            //open sheet
            Excel._Worksheet sheet = workbook.Sheets[2];
            Excel.Range excelFile = sheet.UsedRange;
            // int row = int.Parse(txtRow.Text), column = int.Parse(txtColumn.Text);
            int row = 20, column = 5;

            var t = ListFood;

            bool x = true;
            int i = 1;
            int code = 0;



            TraySchedule Lunch1;
            TraySchedule Lunch2;
            TraySchedule Lunch3;

            TraySchedule Dinner1;
            TraySchedule Dinner2;
            TraySchedule Dinner3;

            

            while (x)
            {
                if (excelFile.Cells[i, 1].Value2 != null)
                {

                    Lunch1 = new TraySchedule();
                    Lunch2 = new TraySchedule();
                    Lunch3 = new TraySchedule();

                     Dinner1 = new TraySchedule();
                    Dinner2 = new TraySchedule();
                    Dinner3 = new TraySchedule();

                    var Date= excelFile.Cells[i, 1].Value2.ToString();

                    var yyy =excelFile.Cells[i, 5].Value2.ToString();
                    var yy = Convert.ToInt16(excelFile.Cells[i, 4].Value2);

                    Lunch1.tray = CreateTray (Convert.ToInt16(excelFile.Cells[i, 2].Value2), Convert.ToInt16(excelFile.Cells[i, 3].Value2));
                    Lunch1.schedule = CreateSchedule(Date, 1);
                    
                    Lunch2.tray = CreateTray(Convert.ToInt16(excelFile.Cells[i, 4].Value2), Convert.ToInt16(excelFile.Cells[i, 5].Value2));
                    Lunch2.schedule = CreateSchedule(Date, 1);

                    Lunch3.tray = CreateTray(Convert.ToInt16(excelFile.Cells[i, 6].Value2), Convert.ToInt16(excelFile.Cells[i, 7].Value2));
                    Lunch3.schedule = CreateSchedule(Date, 1);

                    Dinner1.tray = CreateTray(Convert.ToInt16(excelFile.Cells[i, 8].Value2), Convert.ToInt16(excelFile.Cells[i, 9].Value2));
                    Dinner1.schedule = CreateSchedule(Date, 2);

                    Dinner2.tray = CreateTray(Convert.ToInt16(excelFile.Cells[i, 10].Value2), Convert.ToInt16(excelFile.Cells[i, 11].Value2));
                    Dinner2.schedule = CreateSchedule(Date, 2);

                    Dinner3.tray = CreateTray(Convert.ToInt16(excelFile.Cells[i, 12].Value2), Convert.ToInt16(excelFile.Cells[i, 13].Value2));
                    Dinner3.schedule = CreateSchedule(Date, 2);
                    

                    list.Add(Lunch1);
                    list.Add(Lunch2);
                    list.Add(Lunch3);
                    list.Add(Dinner1);
                    list.Add(Dinner2);
                    list.Add(Dinner3);

                    if (list.Any(p => p.tray == null))
                    {
                        x = false;
                        AllowSave = false;
                    }
                       
                    i = i + 1;

                }
                else
                    x = false;
            }

            if(AllowSave)
            {
                foreach (var item in list)
                {
                    db.Trays.Add(item.tray);
                    db.SaveChanges();

                    item.schedule.Tray_Id_Fk = Convert.ToInt16(item.tray.Id);

                    db.Schedules.Add(item.schedule);
                    db.SaveChanges();

                  //  MessageBox.Show(item.schedule.SDate);
                }


            }





            // MessageBox.Show("Value:  " + excelFile.Cells[row, column].Value2.ToString());
            GC.Collect();
            GC.WaitForPendingFinalizers();
            //release com objects to fully kill excel process from running in the background
            Marshal.ReleaseComObject(excelFile);
            //close and release
            workbook.Close();
            Marshal.ReleaseComObject(workbook);
            //quit and release
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);


        }

        private Tray CreateTray(int code1,int code2)
        {

            var main = ListFood.Where(p => p.Id == code1).FirstOrDefault();
            if (main == null)
                MessageBox.Show(code1.ToString() + "  موجود نمی باشد. فایل اکسل را مجددا بررسی کنید");
            var mokamel = ListFood.Where(p => p.Id == code2).FirstOrDefault();
            if (mokamel == null)
                MessageBox.Show(code2.ToString() + "  موجود نمی باشد. فایل اکسل را مجددا بررسی کنید");
            if(main==null||mokamel==null)
            {
                return null; 
            }
            else
            {
                return new Tray() { Name = main.Name, Image = main.Image, Note = mokamel.Name };
            }
         
        }

        private Schedule CreateSchedule(string date,int meal)
        {
            return new Schedule() { SDate=date,Meal_Id_Fk=meal,Restaurant_Id_Fk=26,RegDate=DateTime.Now.ToPersianDateString(),Res_Cont_Contract_Id_Fk=2020,PorsNo=0};
        }
    }
}
