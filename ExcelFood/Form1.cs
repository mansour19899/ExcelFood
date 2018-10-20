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
using System.IO;
using ExcelDataReader;
using System.Text.RegularExpressions;

namespace ExcelFood
{
    public partial class Form1 : Form
    {
        string filePath = "E:\\123كدينگ.xls";
        PoonehEntities db = null;
        List<TraySchedule> list = new List<TraySchedule>();
        List<Food> ListFood;
        bool AllowSaveCode = true;
        bool AllowSaveNull = true;
        bool AllowTrueDate = true;
        IExcelDataReader excelReader;
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
                lblNotification.ForeColor = Color.Black;
                lblNotification.Text = "فایل انتخاب شده را بارگذاری کنید";
                btnRead.Enabled = true;

                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
            }
            radioButton1.Checked = true;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;

            int StartDay = 0, EndDay = 0;

            var CheckFormat = filePath.Split('.').Last();

            AllowSaveCode = true;
            AllowSaveNull = true;
            list.Clear();

            Regex emp1 = new Regex(@"1(3|4)(9|0)[\d]/(0[1-9]|1[0-2])/(0[1-9]|[1-2][\d]|3[0-1])");

            if (CheckFormat.CompareTo("xls") == 0|| CheckFormat.CompareTo("xlsx") == 0)
            {


                try
                {
                    //open excel

                    FileStream stream = File.Open(filePath, FileMode.Open, FileAccess.Read);

                    //1. Reading from a binary Excel file ('97-2003 format; *.xls)
                    excelReader = ExcelReaderFactory.CreateBinaryReader(stream);
                    //...
                    //2. Reading from a OpenXml Excel file (2007 format; *.xlsx)
                    //IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                    //...
                    //3. DataSet - The result of each spreadsheet will be created in the result.Tables
                    DataSet result = excelReader.AsDataSet();
                    //...
                    //4. DataSet - Create column names from first row
                    //excelReader.IsFirstRowAsColumnNames = true;
                    //DataSet result = excelReader.AsDataSet();

                    if (radioButton2.Checked)
                    {
                        var Sheet2 = result.Tables[0];
                        //var rrr = Sheet2[1].ItemArray[1];
                        int count = 0;

                        TraySchedule NimehShab;

                        var Datemounth =Sheet2.Rows[3][1].ToString().Substring(5,2);
                        if(Datemounth.CompareTo("06")==1)
                        {
                            EndDay = 1;
                        }

                        foreach (DataRow item in Sheet2.Rows)
                        {

                            if (count < 34-EndDay & count > 2+StartDay&AllowTrueDate)
                            {
                                NimehShab = new TraySchedule();

                                try
                                {

                                    var Date = item[1].ToString();

                                    var IsTrueDate = emp1.IsMatch(Date);

                                    if (!IsTrueDate)
                                    {
                                        MessageBox.Show(string.Format(" تاریخ {0} را با فرمت درست وارد کنید", Date));
                                        AllowTrueDate = false;

                                    }


                                    List<TrayItem> t = new List<TrayItem>();

                                    NimehShab.tray = CreateTray(Convert.ToInt16(item[5]),0,out t);
                                    NimehShab.schedule = CreateSchedule(Date, 3);
                                    NimehShab.trayItem = t.ToList();
                                    t.Clear();

                                    list.Add(NimehShab);



                                }
                                catch (IOException)
                                {
                                    MessageBox.Show("فایل اکسل را ببندید");
                                }
                                catch (InvalidCastException)
                                {

                                    AllowSaveNull = false;
                                    MessageBox.Show(" دارای فیلد خالی");
                                }
                                catch
                                {
                                    MessageBox.Show("");
                                }

                                finally
                                {
                                    //5. Data Reader methods
                                    while (excelReader.Read())
                                    {
                                        //excelReader.GetInt32(0);
                                    }



                                }
                            }

                            count = count + 1;

                        }

                    }

                    else
                    {
                        TraySchedule Lunch1;
                        TraySchedule Lunch2;
                        TraySchedule Lunch3;

                        TraySchedule Dinner1;
                        TraySchedule Dinner2;
                        TraySchedule Dinner3;


                        var Sheet2 = result.Tables["code"];
                        //var rrr = Sheet2[1].ItemArray[1];
                        int count = 0;

                        var Datemounth = Sheet2.Rows[3][2].ToString().Substring(5, 2);
                        if (Datemounth.CompareTo("06") == 1)
                        {
                            EndDay = 1;
                        }

                       

                        foreach (DataRow item in Sheet2.Rows)
                        {

                            if (count < 34-EndDay & count > 2+StartDay&AllowTrueDate)
                            {
                                Lunch1 = new TraySchedule();
                                Lunch2 = new TraySchedule();
                                Lunch3 = new TraySchedule();

                                Dinner1 = new TraySchedule();
                                Dinner2 = new TraySchedule();
                                Dinner3 = new TraySchedule();

                               

                                try
                                {
                                    var Date = item[2].ToString();

                                    var IsTrueDate = emp1.IsMatch(Date);

                                    if(!IsTrueDate)
                                    {
                                        MessageBox.Show(string.Format(" تاریخ {0} را با فرمت درست وارد کنید", Date));
                                        AllowTrueDate = false;

                                    }

                                    List<TrayItem> t = new List<TrayItem>();

                                    Lunch1.tray = CreateTray(Convert.ToInt16(item[4]), Convert.ToInt16(item[5]),out t);
                                    Lunch1.schedule = CreateSchedule(Date, 1);
                                    Lunch1.trayItem = t.ToList();
                                    t.Clear();

                                    Lunch2.tray = CreateTray(Convert.ToInt16(item[6]), Convert.ToInt16(item[7]),out t);
                                    Lunch2.schedule = CreateSchedule(Date, 1);
                                    Lunch2.trayItem = t.ToList();
                                    t.Clear();

                                    Lunch3.tray = CreateTray(Convert.ToInt16(item[8]), Convert.ToInt16(item[9]),out t);
                                    Lunch3.schedule = CreateSchedule(Date, 1);
                                    Lunch3.trayItem = t.ToList();
                                    t.Clear();

                                    Dinner1.tray = CreateTray(Convert.ToInt16(item[14]), Convert.ToInt16(item[15]),out t);
                                    Dinner1.schedule = CreateSchedule(Date, 2);
                                    Dinner1.trayItem = t.ToList();
                                    t.Clear();

                                    Dinner2.tray = CreateTray(Convert.ToInt16(item[16]), Convert.ToInt16(item[17]),out t);
                                    Dinner2.schedule = CreateSchedule(Date, 2);
                                    Dinner2.trayItem = t.ToList();
                                    t.Clear();

                                    Dinner3.tray = CreateTray(Convert.ToInt16(item[18]), Convert.ToInt16(item[19]),out t);
                                    Dinner3.schedule = CreateSchedule(Date, 2);
                                    Dinner3.trayItem = t.ToList();
                                    t.Clear();
                                    list.Add(Lunch1);
                                    list.Add(Lunch2);
                                    list.Add(Lunch3);
                                    list.Add(Dinner1);
                                    list.Add(Dinner2);
                                    list.Add(Dinner3);


                                }
                                catch (IOException)
                                {
                                    MessageBox.Show("فایل اکسل را ببندید");
                                }
                                catch (InvalidCastException)
                                {

                                    AllowSaveNull = false;
                                    MessageBox.Show(" دارای فیلد خالی");
                                }
                                catch
                                {
                                    MessageBox.Show("");
                                }

                                finally
                                {
                                    //5. Data Reader methods
                                    while (excelReader.Read())
                                    {
                                        //excelReader.GetInt32(0);
                                    }



                                }
                            }

                            count = count + 1;
                        }
                    }




                }
                catch (IOException)
                {

                    MessageBox.Show("فایل انتخاب شده را ببندید");
                    AllowSaveNull = false;
                }

                //6. Free resources (IExcelDataReader is IDisposable)
                excelReader.Close();
                AllowSaveCode = list.All(p => p.tray != null);


                // ----------------------------------------------------------
                

                if (AllowSaveNull & AllowSaveCode&AllowTrueDate)
                {
                    lblNotification.Text = "بارگذاری فایل اکسل با موفقیت انجام شد";
                    lblNotification.ForeColor = Color.DarkGreen;
                    btnBazbini.Visible = true;
                    btnEnteshar.Visible = true;
                    if (radioButton2.Checked)
                        btnEnteshar.Enabled = false;
                    else
                        btnEnteshar.Enabled = true;

                }

                if(!AllowTrueDate)
                {
                    lblNotification.Text = "فایل را دوباره بارگذاری کنید";
                    lblNotification.ForeColor = Color.DarkRed;
                    AllowTrueDate = true;
                    btnBazbini.Visible = false;
                    btnEnteshar.Visible = false;
                }


            }
            else
            {
                MessageBox.Show("فایل ورودی اکسل  نیست ");
            }










        }

        private Tray CreateTray(int code1, int code2,out List<TrayItem> trayitem)
        {
            trayitem = new List<TrayItem>();

            string MokamelName = "";
            var main = ListFood.Where(p => p.Id == code1).FirstOrDefault();
            if (main == null)
                MessageBox.Show("کد :  " + code1.ToString() + "  موجود نمی باشد.");
            trayitem.Add(new TrayItem() {Food_Id_Fk=main.Id });
            var mokamel = ListFood.Where(p => p.Id == code2).FirstOrDefault();

            if (code2 == 0)
            {

            }
            else if (mokamel == null & code2 != 0)
                MessageBox.Show(code2.ToString() + "  موجود نمی باشد. فایل اکسل را مجددا بررسی کنید");
            else
            {
                MokamelName = mokamel.Name;
                trayitem.Add(new TrayItem() {Food_Id_Fk=mokamel.Id });
            }
                

            if (main == null)
            {
                return null;
            }
            else
            {
                return new Tray() { Name = main.Name, Image = main.Image, Note = MokamelName,Food_Id_Fk=main.Id };
            }

        }

        private Schedule CreateSchedule(string date, int meal)
        {
            return new Schedule() { SDate = date, Meal_Id_Fk = meal, Restaurant_Id_Fk = 26, RegDate = DateTime.Now.ToPersianDateString(), Res_Cont_Contract_Id_Fk = 2021, PorsNo = 0 };
        }

        private void btnBazbini_Click(object sender, EventArgs e)
        {

            if(radioButton1.Checked)
            {
                string temp = list.ElementAt(0).schedule.SDate;

                bool CheckExist = db.Schedules.Any(p => p.SDate.CompareTo(temp) == 1&p.Meal_Id_Fk==1);
                if (CheckExist)
                {
                    lblNotification.Text = "برنامه غذایی قبلا ثبت شده است";
                    lblNotification.ForeColor = Color.DarkRed;
                }
                else
                {
 
                    Bazbini frm = new Bazbini(list, true);
                    frm.ShowDialog();
                }



            }
            else
            {

                string temp = list.ElementAt(0).schedule.SDate;

                bool CheckExist = db.Schedules.Any(p => p.SDate.CompareTo(temp) == 1 & p.Meal_Id_Fk == 3);
                if (CheckExist)
                {
                    lblNotification.Text = "برنامه غذایی قبلا ثبت شده است";
                    lblNotification.ForeColor = Color.DarkRed;
                }
                else
                {

                    Bazbini frm = new Bazbini(list, false);
                    frm.ShowDialog();
                }


            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnteshar_Click(object sender, EventArgs e)
        {
            Enteshar frm = new Enteshar(list.ElementAt(0).schedule.SDate);
            frm.ShowDialog();
        }

        private void btnNimehShab_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "File 1";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //save selected file name
                filePath = openFileDialog1.FileName;

                lblFilePath.Text = filePath;
                lblNotification.ForeColor = Color.Black;
                lblNotification.Text = "فایل انتخاب شده را بارگذاری کنید";
                btnRead.Enabled = true;

            }
            radioButton2.Checked = true;
        }
    }
}
