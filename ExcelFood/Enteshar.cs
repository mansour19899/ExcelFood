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
        string date = "";
        public Enteshar(string datee)
        {
            InitializeComponent();

            db = new PoonehEntities();
            date = datee;
        }

        private void Enteshar_Load(object sender, EventArgs e)
        {

             CheckEnteshar();
           


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


            CheckExist = db.Schedules.Any(p => p.SDate.CompareTo(date) == 1 & p.Meal_Id_Fk == 1 & p.Restaurant_Id_Fk!=26);

            if(CheckExist)
            {
                lblNotification.Text = string.Format(" برنامه غذایی {0} قبلا منتشر شده است", mounth);
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
    }
}
