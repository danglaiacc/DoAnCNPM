﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using GUI.global;
using GUI.Forms;

namespace GUI.UserControls
{
    public partial class UC_Patient : UserControl
    {
        public UC_Patient()
        {
            InitializeComponent();
        }

        private void UC_Home_Load(object sender, EventArgs e)
        {
            if(List.lstPatient.Count == 0)
            { // mảng chưa có bệnh nhân nào
                List.lstPatient = Patient_BLL.getPatient();
            }
            foreach (Patient_DTO p in List.lstPatient)
            {
                grvLstBenhNhan.Rows.Add(new string[] {
                        p.Pat_id.ToString(),
                    p.Pat_fullname,
                    p.Pat_phone1,
                    p.Pat_dob.ToString("dd/MM/yyyy"),
                    p.Pat_address
                });
            }

            grvLstBenhNhan.Columns[0].Width = 100;
        }

        private void grvLstBenhNhan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmRecord f = new frmRecord(List.lstPatient[e.RowIndex]);
            f.ShowDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmAdd f = new frmAdd("Thêm bệnh nhân mới", new UC_AddPatient());
            f.ShowDialog();
        }
    }
}
