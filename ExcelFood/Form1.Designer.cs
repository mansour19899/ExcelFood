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
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(656, 346);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(98, 46);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblFilePath
            // 
            this.lblFilePath.AllowDrop = true;
            this.lblFilePath.Location = new System.Drawing.Point(469, 346);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFilePath.Size = new System.Drawing.Size(181, 46);
            this.lblFilePath.TabIndex = 1;
            this.lblFilePath.Text = "label1";
            this.lblFilePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRead
            // 
            this.btnRead.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnRead.Location = new System.Drawing.Point(300, 344);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(115, 61);
            this.btnRead.TabIndex = 2;
            this.btnRead.Text = "بارگذاری فایل اکسل";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // lblNotification
            // 
            this.lblNotification.AllowDrop = true;
            this.lblNotification.Font = new System.Drawing.Font("B Titr", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblNotification.Location = new System.Drawing.Point(206, 21);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNotification.Size = new System.Drawing.Size(314, 79);
            this.lblNotification.TabIndex = 3;
            this.lblNotification.Text = "label1";
            this.lblNotification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblNotification);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.btnBrowse);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label lblNotification;
    }
}

