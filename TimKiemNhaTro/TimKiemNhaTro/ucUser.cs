﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimKiemNhaTro.Model;

namespace TimKiemNhaTro
{
    public partial class ucUser : UserControl
    {
        public ucUser()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Checked == true)
            {
                btnEdit.Checked = false;
                btnEditImage.Visible = true;
            }
            else
            {
                btnEdit.Checked = true;
                btnEditImage.Visible = false;
            }
        }

        private void btnNhaDaDang_Click(object sender, EventArgs e)
        {
            (this.Parent.Parent as frmMain).getUCNhaDaDang();
            (this.Parent.Parent as frmMain).setUCNhaDaDangBringtoFront();
        }
    }
}
