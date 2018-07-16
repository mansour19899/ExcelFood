using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelFood
{
    public partial class Enteshar : Form
    {
        PoonehEntities db = null;
        bool CheckExist;
        bool Check;
        string date = "";
        List<RestaurantContract> listRes;
        List<Schedule> listSchedules;
        int countTotal = 0;
        bool AllowExit = false;
        public Enteshar(string datee)
        {
            InitializeComponent();

            db = new PoonehEntities();
            date = datee;
        }

        private void Enteshar_Load(object sender, EventArgs e)
        {

             CheckEnteshar();

            progressBar1.Minimum = 0;
          


        }
        void CheckEnteshar()
        {
            //date="1396/12/01";
            var mounth = date.Substring(5, 2);

            switch (mounth)
            {
                case "01":
                    mounth = "فروردین ماه";
                    break;
                case "02":
                    mounth = "اردیبهشت ماه";
                    break;
                case "03":
                    mounth = "خرداد ماه";
                    break;
                case "04":
                    mounth = "تیر ماه";
                    break;
                case "05":
                    mounth = "مرداد ماه";
                    break;
                case "06":
                    mounth = "شهریور ماه";
                    break;
                case "07":
                    mounth = "مهر ماه";
                    break;
                case "08":
                    mounth = "آبان ماه";
                    break;
                case "09":
                    mounth = "آذر ماه";
                    break;
                case "10":
                    mounth = "دی ماه";
                    break;
                case "11":
                    mounth = "بهمن ماه";
                    break;
                case "12":
                    mounth = "اسفند ماه";
                    break;
                default:
                    mounth = "";
                    break;
            }

            Check = db.Schedules.Any(p => p.SDate.CompareTo(date) == 1 & p.Meal_Id_Fk == 1 & p.Restaurant_Id_Fk == 26);
            CheckExist = db.Schedules.Any(p => p.SDate.CompareTo(date) == 1 & p.Meal_Id_Fk == 1 & p.Restaurant_Id_Fk!=26);

            if(CheckExist)
            {
                lblNotification.Text = string.Format(" برنامه غذایی {0} قبلا منتشر شده است", mounth);
                lblNotification.ForeColor = Color.DarkRed;
                btnEnteshar.Enabled = false;

            }
            else if(!Check&!CheckExist)
            {
                lblNotification.Text = string.Format(" برنامه غذایی {0} را ابتدا ثبت کنید", mounth);
                lblNotification.ForeColor = Color.DarkRed;
                btnEnteshar.Enabled = false;
            }
            else
            {

                lblNotification.Text = string.Format(" برنامه غذایی {0} آماده انتشار است", mounth);
                lblNotification.ForeColor = Color.DarkGreen;
            }
           

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnteshar_Click(object sender, EventArgs e)
        {
            if (!AllowExit)
            {

                listRes = new List<RestaurantContract>()
            {
                new RestaurantContract(){Restaurant=28,Contract=2021},
                new RestaurantContract(){Restaurant=29,Contract=2021},
                new RestaurantContract(){Restaurant=32,Contract=2021},
                new RestaurantContract(){Restaurant=38,Contract=2021},
                new RestaurantContract(){Restaurant=39,Contract=2021},
                new RestaurantContract(){Restaurant=40,Contract=2021},
                new RestaurantContract(){Restaurant=41,Contract=2021},
                new RestaurantContract(){Restaurant=42,Contract=2021},
                new RestaurantContract(){Restaurant=44,Contract=2021},
                new RestaurantContract(){Restaurant=49,Contract=2021},
                new RestaurantContract(){Restaurant=50,Contract=2021},
                new RestaurantContract(){Restaurant=50,Contract=2021},
                new RestaurantContract(){Restaurant=27,Contract=2020},
                new RestaurantContract(){Restaurant=30,Contract=2020},
                new RestaurantContract(){Restaurant=31,Contract=2020},
                new RestaurantContract(){Restaurant=33,Contract=2020},
                new RestaurantContract(){Restaurant=34,Contract=2020},
                new RestaurantContract(){Restaurant=37,Contract=2020},
                new RestaurantContract(){Restaurant=36,Contract=2020},
                new RestaurantContract(){Restaurant=53,Contract=2020}

            };



                listSchedules = db.Schedules.Where(p => p.SDate.CompareTo(date) >= 0 & p.Meal_Id_Fk != 3 & p.Restaurant_Id_Fk == 26).ToList();
                countTotal = listRes.Count() * listSchedules.Count();
                progressBar1.Maximum = countTotal;
                int x = 0;

                DialogResult dialogResult = RtlMessageBox.Show("آیا اطمینان از ثبت اطلاعات در دیتا بیس را دارید؟", "تاییدیه ثبت ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    lblNotification.Text = "در حال ثبت در دیتابیس";
                    lblNotification.ForeColor = Color.Navy;

                    Bg.RunWorkerAsync();


                }
                else if (dialogResult == DialogResult.No)
                {

                }

            }
             
            else
            {
                this.Close();
            }

        }

        class RestaurantContract
        {
            public int Contract { get; set; }
            public int Restaurant { get; set; }
        }

        private void Bg_DoWork(object sender, DoWorkEventArgs e)
        {
            int i = 0;

            foreach (var item in listRes)
            {
                foreach (var item2 in listSchedules)
                {
                    item2.Restaurant_Id_Fk = item.Restaurant;
                    item2.Res_Cont_Contract_Id_Fk = item.Contract;

                    db.Schedules.Add(item2);
                    db.SaveChanges();

                    Bg.ReportProgress(i);

                    i = i + 1;

                }
                

                lblDarsad.Invoke(new Action(() =>
                {
                    lblDarsad.Text = "%" + (i * 100 /countTotal).ToString();
                }));

               

            }

        
        }

        private void Bg_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void Bg_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblNotification.Text = " ثبت با موفقیت انجام شد";
            lblNotification.ForeColor = Color.DarkGreen;

            AllowExit = true;
            btnEnteshar.Text = "خروج";
        }
    }
}
