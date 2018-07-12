﻿using System;
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
        int i = 180;
        int count = 0;
        PoonehEntities db = null;
        List<Food> ListFood;
        bool AllowExit = false;
        public Bazbini(List<TraySchedule> List)
        {
            list = List;
            InitializeComponent();
            count = list.Count();

            progressBar1.Minimum = 0;
            progressBar1.Maximum = list.Count();
        }

        private void Bazbini_Load(object sender, EventArgs e)
        {
            SetLabel();
          
            db = new PoonehEntities();

            ListFood = db.Foods.ToList();
        }

        public void SetLabel()
        {
            if(i<count)
            {
                lblDate.Text = list.ElementAt(i + 0).schedule.SDate;

                LblLunch1.Text = list.ElementAt(i + 0).tray.Name + "\n+" + list.ElementAt(i + 0).tray.Note;
                LblLunch2.Text = list.ElementAt(i + 1).tray.Name + "\n+" + list.ElementAt(i + 1).tray.Note;
                LblLunch3.Text = list.ElementAt(i + 2).tray.Name + "\n+" + list.ElementAt(i + 2).tray.Note;

                lblDinner1.Text = list.ElementAt(i + 3).tray.Name + "\n+" + list.ElementAt(i + 3).tray.Note;
                lblDinner2.Text = list.ElementAt(i + 4).tray.Name + "\n+" + list.ElementAt(i + 4).tray.Note;
                lblDinner3.Text = list.ElementAt(i + 5).tray.Name + "\n+" + list.ElementAt(i + 5).tray.Note;

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
            if(!AllowExit)
            {
                label3.Text = "در حال ثبت در دیتابیس";
                label3.ForeColor = Color.Navy;
                button3.Enabled = false;
                button4.Enabled = false;
                Bg.RunWorkerAsync();
            }
            else
            {
                this.Close();
            }



        }

        private void Bg_DoWork(object sender, DoWorkEventArgs e)
        {
            int i = 0;
            foreach (var item in list)
            {
                db.Trays.Add(item.tray);
                db.SaveChanges();

                item.schedule.Tray_Id_Fk = Convert.ToInt16(item.tray.Id);

                db.Schedules.Add(item.schedule);
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
            this.Close();
        }
    }
}
