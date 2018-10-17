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
    public partial class Bazbini : Form
    {
        List<TraySchedule> list;
        int i = 0;
        int count = 0;
        PoonehEntities db = null;
        List<Food> ListFood;
        bool AllowExit = false;
        bool Type;
        public Bazbini(List<TraySchedule> List, bool type)
        {
            list = List;
            InitializeComponent();
            count = list.Count();

            progressBar1.Minimum = 0;
            progressBar1.Maximum = list.Count();

            Type = type;
            

        }

        private void Bazbini_Load(object sender, EventArgs e)
        {
            SetLabel();
          
            db = new PoonehEntities();

            ListFood = db.Foods.ToList();
        }

        public void SetLabel()
        {
            if(i<count&Type)
            {
                lblDate.Text = list.ElementAt(i + 0).schedule.SDate;

                LblLunch1.Text = list.ElementAt(i + 0).tray.Name + "\n((" + list.ElementAt(i + 0).tray.Note+"))";
                LblLunch2.Text = list.ElementAt(i + 1).tray.Name + "\n((" + list.ElementAt(i + 1).tray.Note + "))";
                LblLunch3.Text = list.ElementAt(i + 2).tray.Name + "\n((" + list.ElementAt(i + 2).tray.Note + "))";

                lblDinner1.Text = list.ElementAt(i + 3).tray.Name + "\n((" + list.ElementAt(i + 3).tray.Note + "))";
                lblDinner2.Text = list.ElementAt(i + 4).tray.Name + "\n((" + list.ElementAt(i + 4).tray.Note + "))";
                lblDinner3.Text = list.ElementAt(i + 5).tray.Name + "\n((" + list.ElementAt(i + 5).tray.Note + "))";

                i = i + 6;
            }

           else if (i < count & !Type)
            {
                label1.Text = "";
                label2.Text = "";
                lblDate.Text = "";
                LblLunch1.TextAlign = ContentAlignment.MiddleCenter;
                LblLunch2.TextAlign = ContentAlignment.MiddleCenter;
                LblLunch3.TextAlign = ContentAlignment.MiddleCenter;

                lblDinner1.TextAlign = ContentAlignment.MiddleCenter;
                lblDinner2.TextAlign = ContentAlignment.MiddleCenter;
                lblDinner3.TextAlign = ContentAlignment.MiddleCenter;

                if (i<30)
                {
                    LblLunch1.Text = list.ElementAt(i + 0).schedule.SDate + "\n" + list.ElementAt(i + 0).tray.Name;
                    LblLunch2.Text = list.ElementAt(i + 1).schedule.SDate + "\n" + list.ElementAt(i + 1).tray.Name;
                    LblLunch3.Text = list.ElementAt(i + 2).schedule.SDate + "\n" + list.ElementAt(i + 2).tray.Name;

                    lblDinner1.Text = list.ElementAt(i + 3).schedule.SDate + "\n" + list.ElementAt(i + 3).tray.Name;
                    lblDinner2.Text = list.ElementAt(i + 4).schedule.SDate + "\n" + list.ElementAt(i + 4).tray.Name;
                    lblDinner3.Text = list.ElementAt(i + 5).schedule.SDate + "\n" + list.ElementAt(i + 5).tray.Name;
                }
                if (i == 30)
                {
                    LblLunch1.Text = list.ElementAt(i + 0).schedule.SDate + "\n" + list.ElementAt(i + 0).tray.Name;
                    LblLunch2.Text = "";
                    LblLunch3.Text = "";

                    lblDinner1.Text = "";
                    lblDinner2.Text = "";
                    lblDinner3.Text = "";
                }


                i = i + 6;
            }

            else
            {
                panel1.Visible = true;
             
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetLabel();
        }

        private void button2_Click(object sender, EventArgs e)
        {



}

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!AllowExit)
            {

                DialogResult dialogResult = RtlMessageBox.Show("آیا اطمینان از ثبت اطلاعات در دیتا بیس را دارید؟", "تاییدیه ثبت ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    label3.Text = "در حال ثبت در دیتابیس";
                    label3.ForeColor = Color.Navy;
                    button3.Enabled = false;
                    button4.Enabled = false;
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

        private void Bg_DoWork(object sender, DoWorkEventArgs e)
        {
            int i = 0;
            bool nimeshab = list.Any(p => p.schedule.Meal_Id_Fk == 3);
            
            foreach (var item in list)
            {
                db.Trays.Add(item.tray);
                db.SaveChanges();

                item.schedule.Tray_Id_Fk = Convert.ToInt16(item.tray.Id);
                db.Schedules.Add(item.schedule);

                foreach (var itemm in item.trayItem)
                {
                    itemm.Tray_Id_Fk= Convert.ToInt16(item.tray.Id);
                    db.TrayItems.Add(itemm);
                }


                if(nimeshab)
                {
                    Schedule nimeshab2 = new Schedule() {SDate=item.schedule.SDate,Restaurant_Id_Fk=27,Tray_Id_Fk=item.schedule.Tray_Id_Fk,
                    RegDate=item.schedule.RegDate,Meal_Id_Fk=3,Res_Cont_Contract_Id_Fk=2022,PorsNo=0};

                    db.Schedules.Add(nimeshab2);
                }
                db.SaveChanges();

                i = i + 1;

                lblDarsad.Invoke(new Action(() =>
                {
                    lblDarsad.Text = "%"+( i * 100 / list.Count()).ToString();
                }));

                Bg.ReportProgress(i);
                System.Threading.Thread.Sleep(100);

            }

        }

        private void Bg_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void Bg_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
            label3.Text = " ثبت با موفقیت انجام شد";
            label3.ForeColor = Color.DarkGreen;
            button3.Text = " خروج";
            button3.Enabled = true;
            AllowExit = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = RtlMessageBox.Show("آیا اطمینان از انصراف را دارید؟", " ", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();

            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
    }
}
