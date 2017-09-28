using DXAutoFillData.UControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXAutoFillData
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //UControls.UC_WebBrowser frm = new UControls.UC_WebBrowser();
            UC_Main frm = new UC_Main();
            frm.Dock = DockStyle.Fill;
            this.Controls.Add(frm);
        }
    }
}
