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
            loadSkin();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //UControls.UC_WebBrowser frm = new UControls.UC_WebBrowser();
            UC_Main frm = new UC_Main();
            frm.Dock = DockStyle.Fill;
            this.Controls.Add(frm);
        }

        private void loadSkin()
        {
            if (DateTime.Now.ToString("dd-MM-yyyy").Equals("14-02-" + DateTime.Now.Year)
                || DateTime.Now.ToString("dd-MM-yyyy").Equals("13-02-" + DateTime.Now.Year)
                || DateTime.Now.ToString("dd-MM-yyyy").Equals("15-02-" + DateTime.Now.Year))
                skinApp.LookAndFeel.SkinName = "Valentine";
            else if (DateTime.Now.Year == 9)
                skinApp.LookAndFeel.SkinName = "Xmas 2008 Blue";
            else if (DateTime.Now.ToString("dd-MM-yyyy").Equals("29-10-" + DateTime.Now.Year)
                || DateTime.Now.ToString("dd-MM-yyyy").Equals("30-10-" + DateTime.Now.Year)
                || DateTime.Now.ToString("dd-MM-yyyy").Equals("31-10-" + DateTime.Now.Year))
                skinApp.LookAndFeel.SkinName = "Pumpkin";
            else if (DateTime.Now.Year == 6)
                skinApp.LookAndFeel.SkinName = "Summer 2008";
            else if (DateTime.Now.Year == 1)
                skinApp.LookAndFeel.SkinName = "Springtime";
        }
    }
}
