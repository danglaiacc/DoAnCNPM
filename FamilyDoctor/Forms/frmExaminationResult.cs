﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI.Forms
{
    public partial class frmExaminationResult : Form
    {
        public Examination_DTO exa;
        public frmExaminationResult(Examination_DTO exa)
        {
            InitializeComponent();
            this.exa = exa;
        }
        public frmExaminationResult(string rec_id)
        {
            InitializeComponent();

            exa = Examination_BLL.getExaminationDetailById(rec_id);
        }
        private void frmExaminationResult_Load(object sender, EventArgs e)
        {
            lblExa_content.Text = exa.Exa_content;
            lblExa_place.Text = exa.Exa_place;
            if (exa.Exa_result != "")
            {
                // Xét nghiệm đã có kết quả, chỉ cho xem kết quả thôi
                txtExa_result.Enabled = false;
                txtExa_result.Text = exa.Exa_result;
                btnLuu.Enabled = false;

                lblTitle.Text = "Xem chi tiết xét nghiệm";
            }
            else
            {
                txtExa_result.Text = "Điền kết quả xét nghiệm vào đây.";
                txtExa_result.SelectAll();
                lblTitle.Text = "Cập nhật kết quả xét nghiệm";

            }
            txtExa_result.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string exa_result = txtExa_result.Text.Trim();
            if(exa_result != "" && exa_result != "Điền kết quả xét nghiệm vào đây.")
            {
                if (Examination_BLL.updateResultExamination(exa.Rec_id,exa_result))
                {
                    exa.Exa_result = exa_result;
                    frmAlert f = new frmAlert();
                    f.showAlert("Cập nhật thành công", frmAlert.enmType.Success);
                    Close();
                }
                else
                {
                    frmAlert f = new frmAlert();
                    f.showAlert("Cập nhật thất bại", frmAlert.enmType.Error);
                }
            }
            else
            {
                frmAlert f = new frmAlert();
                f.showAlert("Kết quả không được trống", frmAlert.enmType.Error);
            }
            txtExa_result.Focus();
        }
    }
}
