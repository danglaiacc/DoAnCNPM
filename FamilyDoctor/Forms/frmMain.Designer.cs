﻿namespace GUI.Forms
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelSide = new System.Windows.Forms.Panel();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnHospital = new System.Windows.Forms.Button();
            this.btnExamination = new System.Windows.Forms.Button();
            this.btnMedicine = new System.Windows.Forms.Button();
            this.btnPatient = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.panelControls = new System.Windows.Forms.Panel();
            this.panelLeft.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panelLeft.Controls.Add(this.panelSide);
            this.panelLeft.Controls.Add(this.btnUsers);
            this.panelLeft.Controls.Add(this.btnHospital);
            this.panelLeft.Controls.Add(this.btnExamination);
            this.panelLeft.Controls.Add(this.btnMedicine);
            this.panelLeft.Controls.Add(this.btnPatient);
            this.panelLeft.Controls.Add(this.panel3);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(215, 720);
            this.panelLeft.TabIndex = 0;
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.White;
            this.panelSide.Location = new System.Drawing.Point(1, 142);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(7, 60);
            this.panelSide.TabIndex = 1;
            // 
            // btnUsers
            // 
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnUsers.Image")));
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(12, 402);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(203, 60);
            this.btnUsers.TabIndex = 2;
            this.btnUsers.Text = "     Thống kê";
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnHospital
            // 
            this.btnHospital.FlatAppearance.BorderSize = 0;
            this.btnHospital.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHospital.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHospital.ForeColor = System.Drawing.Color.White;
            this.btnHospital.Image = ((System.Drawing.Image)(resources.GetObject("btnHospital.Image")));
            this.btnHospital.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHospital.Location = new System.Drawing.Point(12, 336);
            this.btnHospital.Name = "btnHospital";
            this.btnHospital.Size = new System.Drawing.Size(203, 60);
            this.btnHospital.TabIndex = 2;
            this.btnHospital.Text = "     Chuyển viện";
            this.btnHospital.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHospital.UseVisualStyleBackColor = true;
            this.btnHospital.Click += new System.EventHandler(this.btnHospital_Click);
            // 
            // btnExamination
            // 
            this.btnExamination.FlatAppearance.BorderSize = 0;
            this.btnExamination.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExamination.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExamination.ForeColor = System.Drawing.Color.White;
            this.btnExamination.Image = ((System.Drawing.Image)(resources.GetObject("btnExamination.Image")));
            this.btnExamination.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExamination.Location = new System.Drawing.Point(12, 271);
            this.btnExamination.Name = "btnExamination";
            this.btnExamination.Size = new System.Drawing.Size(203, 60);
            this.btnExamination.TabIndex = 2;
            this.btnExamination.Text = "       Xét nghiệm";
            this.btnExamination.UseVisualStyleBackColor = true;
            this.btnExamination.Click += new System.EventHandler(this.btnExamination_Click);
            // 
            // btnMedicine
            // 
            this.btnMedicine.FlatAppearance.BorderSize = 0;
            this.btnMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicine.ForeColor = System.Drawing.Color.White;
            this.btnMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnMedicine.Image")));
            this.btnMedicine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedicine.Location = new System.Drawing.Point(12, 205);
            this.btnMedicine.Name = "btnMedicine";
            this.btnMedicine.Size = new System.Drawing.Size(203, 60);
            this.btnMedicine.TabIndex = 2;
            this.btnMedicine.Text = "     Thuốc";
            this.btnMedicine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMedicine.UseVisualStyleBackColor = true;
            this.btnMedicine.Click += new System.EventHandler(this.btnMedicine_Click);
            // 
            // btnPatient
            // 
            this.btnPatient.FlatAppearance.BorderSize = 0;
            this.btnPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatient.ForeColor = System.Drawing.Color.White;
            this.btnPatient.Image = ((System.Drawing.Image)(resources.GetObject("btnPatient.Image")));
            this.btnPatient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPatient.Location = new System.Drawing.Point(11, 140);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(203, 60);
            this.btnPatient.TabIndex = 2;
            this.btnPatient.Text = "     Bệnh nhân";
            this.btnPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPatient.UseVisualStyleBackColor = true;
            this.btnPatient.Click += new System.EventHandler(this.btnPatient_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 140);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bác sĩ gia đình";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(64, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.button9);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(215, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(985, 48);
            this.panel4.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(6, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 41);
            this.label4.TabIndex = 0;
            this.label4.Text = "Khoa nội";
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Right;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.Location = new System.Drawing.Point(937, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(48, 48);
            this.button9.TabIndex = 2;
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.labelTime);
            this.panel2.Controls.Add(this.lblDoctor);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(215, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(985, 92);
            this.panel2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(8, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(285, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Trạng thái: Đang làm việc";
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(709, 33);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(264, 25);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "HH:MM:SS DD/MM/YYYY";
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctor.ForeColor = System.Drawing.Color.White;
            this.lblDoctor.Location = new System.Drawing.Point(8, 14);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(378, 32);
            this.lblDoctor.TabIndex = 0;
            this.lblDoctor.Text = "Bác sĩ Chuyên khoa I Họ tên gì đó";
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // panelControls
            // 
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControls.Location = new System.Drawing.Point(215, 140);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(985, 580);
            this.panelControls.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelLeft);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Family Doctor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelLeft.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Button btnPatient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnHospital;
        private System.Windows.Forms.Button btnExamination;
        private System.Windows.Forms.Button btnMedicine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Panel panelControls;
    }
}