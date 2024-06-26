﻿using GUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Forms
{
    public partial class frmAlert : Form
    {
        public frmAlert()
        {
            InitializeComponent();
        }
        public enum enmAction
        {
            wait,
            start,
            close
        }

        public enum enmType
        {
            Success,
            Warning,
            Error,
            Info
        }
        private enmAction action;

        private int x, y;

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = enmAction.close;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (action)
            {
                case enmAction.wait:
                    timer1.Interval = 5000;
                    action = enmAction.close;
                    break;
                case enmAction.start:
                    timer1.Interval = 1;
                    Opacity += 0.1;
                    if (x < Location.X)
                    {
                        Left--;
                    }
                    else
                    {
                        if (Opacity == 1.0)
                        {
                            action = enmAction.wait;
                        }
                    }
                    break;
                case enmAction.close:
                    timer1.Interval = 1;
                    Opacity -= 0.1;
                    Left -= 3;
                    if (base.Opacity == 0.0) this.Dispose();

                    //if (base.Opacity == 0.0) this.Close();
                    break;
            }
        }
        public void showAlert(string msg, enmType type)
        {
            Opacity = 0.0;
            StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                frmAlert frm = (frmAlert)Application.OpenForms[fname];

                if (frm == null)
                {
                    Name = fname;
                    x = Screen.PrimaryScreen.WorkingArea.Width - Width + 15;
                    y = Screen.PrimaryScreen.WorkingArea.Height - Height * i - 5 * i;
                    Location = new Point(x, y);
                    break;
                }
            }
            x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            switch (type)
            {
                case enmType.Success:
                    pictureBox1.Image = Resources.success;
                    BackColor = Color.SeaGreen;
                    break;
                case enmType.Error:
                    pictureBox1.Image = Resources.error;
                    BackColor = Color.DarkRed;
                    break;
                case enmType.Info:
                    pictureBox1.Image = Resources.info;
                    BackColor = Color.RoyalBlue;
                    break;
                case enmType.Warning:
                    pictureBox1.Image = Resources.warning;
                    BackColor = Color.DarkOrange;
                    break;
            }
            label1.Text = msg;
            TopMost = true;
            Show();
            action = enmAction.start;
            timer1.Interval = 1;
            timer1.Start();
        }
    }
}
