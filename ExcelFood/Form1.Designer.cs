namespace ExcelFood
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.lblNotification = new System.Windows.Forms.Label();
            this.btnBazbini = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBrowse.FlatAppearance.BorderSize = 4;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.ForeColor = System.Drawing.Color.Black;
            this.btnBrowse.Location = new System.Drawing.Point(599, 556);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(109, 61);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblFilePath
            // 
            this.lblFilePath.AllowDrop = true;
            this.lblFilePath.BackColor = System.Drawing.Color.Transparent;
            this.lblFilePath.Location = new System.Drawing.Point(476, 620);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFilePath.Size = new System.Drawing.Size(235, 23);
            this.lblFilePath.TabIndex = 1;
            this.lblFilePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRead.Enabled = false;
            this.btnRead.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRead.FlatAppearance.BorderSize = 4;
            this.btnRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRead.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnRead.ForeColor = System.Drawing.Color.Black;
            this.btnRead.Location = new System.Drawing.Point(343, 557);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(174, 61);
            this.btnRead.TabIndex = 2;
            this.btnRead.Text = "بارگذاری فایل اکسل";
            this.btnRead.UseVisualStyleBackColor = false;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // lblNotification
            // 
            this.lblNotification.AllowDrop = true;
            this.lblNotification.BackColor = System.Drawing.Color.Transparent;
            this.lblNotification.Font = new System.Drawing.Font("B Titr", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblNotification.Location = new System.Drawing.Point(266, 24);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNotification.Size = new System.Drawing.Size(314, 79);
            this.lblNotification.TabIndex = 3;
            this.lblNotification.Text = "فایل اکسل را انتخاب کنید";
            this.lblNotification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBazbini
            // 
            this.btnBazbini.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBazbini.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBazbini.FlatAppearance.BorderSize = 5;
            this.btnBazbini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBazbini.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnBazbini.ForeColor = System.Drawing.Color.Black;
            this.btnBazbini.Location = new System.Drawing.Point(343, 219);
            this.btnBazbini.Name = "btnBazbini";
            this.btnBazbini.Size = new System.Drawing.Size(153, 101);
            this.btnBazbini.TabIndex = 4;
            this.btnBazbini.Text = "بازبینی رزروها";
            this.btnBazbini.UseVisualStyleBackColor = false;
            this.btnBazbini.Visible = false;
            this.btnBazbini.Click += new System.EventHandler(this.btnBazbini_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 4;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(66, 557);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 61);
            this.button1.TabIndex = 5;
            this.button1.Text = "خروج";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold);
            this.radioButton1.Location = new System.Drawing.Point(754, 556);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton1.Size = new System.Drawing.Size(98, 28);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "برنامه غذایی";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold);
            this.radioButton2.Location = new System.Drawing.Point(775, 589);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton2.Size = new System.Drawing.Size(77, 28);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.Text = "نیمه شب";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ExcelFood.Properties.Resources.sky_blue_color_wallpaper_4;
            this.ClientSize = new System.Drawing.Size(884, 652);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBazbini);
            this.Controls.Add(this.lblNotification);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.btnBrowse);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label lblNotification;
        private System.Windows.Forms.Button btnBazbini;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

