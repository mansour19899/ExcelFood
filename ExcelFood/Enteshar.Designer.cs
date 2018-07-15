namespace ExcelFood
{
    partial class Enteshar
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
            this.lblNotification = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEnteshar = new System.Windows.Forms.Button();
            this.lblDarsad = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lblNotification
            // 
            this.lblNotification.AllowDrop = true;
            this.lblNotification.BackColor = System.Drawing.Color.Transparent;
            this.lblNotification.Font = new System.Drawing.Font("B Titr", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblNotification.Location = new System.Drawing.Point(195, 81);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNotification.Size = new System.Drawing.Size(474, 79);
            this.lblNotification.TabIndex = 4;
            this.lblNotification.Text = "فایل اکسل را انتخاب کنید";
            this.lblNotification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderSize = 5;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCancel.Location = new System.Drawing.Point(253, 517);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(139, 55);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEnteshar
            // 
            this.btnEnteshar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEnteshar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEnteshar.FlatAppearance.BorderSize = 5;
            this.btnEnteshar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnteshar.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnEnteshar.Location = new System.Drawing.Point(502, 517);
            this.btnEnteshar.Name = "btnEnteshar";
            this.btnEnteshar.Size = new System.Drawing.Size(139, 55);
            this.btnEnteshar.TabIndex = 5;
            this.btnEnteshar.Text = "انتشار";
            this.btnEnteshar.UseVisualStyleBackColor = false;
            // 
            // lblDarsad
            // 
            this.lblDarsad.AutoSize = true;
            this.lblDarsad.BackColor = System.Drawing.Color.Transparent;
            this.lblDarsad.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblDarsad.Location = new System.Drawing.Point(601, 189);
            this.lblDarsad.Name = "lblDarsad";
            this.lblDarsad.Size = new System.Drawing.Size(36, 33);
            this.lblDarsad.TabIndex = 8;
            this.lblDarsad.Text = "%0";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(264, 179);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(325, 52);
            this.progressBar1.TabIndex = 7;
            // 
            // Enteshar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ExcelFood.Properties.Resources.sky_blue_color_wallpaper_4;
            this.ClientSize = new System.Drawing.Size(884, 700);
            this.Controls.Add(this.lblDarsad);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEnteshar);
            this.Controls.Add(this.lblNotification);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Enteshar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enteshar";
            this.Load += new System.EventHandler(this.Enteshar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNotification;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEnteshar;
        private System.Windows.Forms.Label lblDarsad;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}