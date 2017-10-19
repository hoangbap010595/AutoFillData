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

        Timer t = new Timer();
        public static string title = "Auto Fill Data 1.0.0";
        public frmMain()
        {
            InitializeComponent();
            loadSkin();
            this.Text = title;
        }
        private void disableForm()
        {
            if (this.Controls.Count > 0)
                this.Controls[0].Enabled = false;
            t.Enabled = false;
            this.Text = "[Blocked] " + title;
            this.ControlBox = true;
            frmActive frmActive = new frmActive();
            frmActive.isActive = new frmActive.ActiveOK(isActive);
            frmActive.ShowDialog();
        }

        private void T_Tick(object sender, EventArgs e)
        {
            if (!UserConfig.getIsActive())
            {
                int tl = UserConfig.getTimeLeft();
                tl--;
                int phut = tl / 60;
                int giay = tl % 60;
                Text = "[" + phut + " phút : " + giay + "giây] " + title;
                UserConfig.setTimeLeft(tl);
                if (tl <= 0)
                {
                    t.Enabled = false;
                    disableForm();
                }
            }
        }
        private void isActive(bool active)
        {
            if (active)
                if (this.Controls.Count > 0)
                    this.Controls[0].Enabled = true;
            this.Text = title;
            this.ControlBox = false;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            //UControls.UC_WebBrowser frm = new UControls.UC_WebBrowser();
            UC_Main frm = new UC_Main();
            frm.Dock = DockStyle.Fill;
            this.Controls.Add(frm);
            if (!UserConfig.getIsActive())
            {
                if (UserConfig.getTimeLeft() > 0)
                {
                    t.Interval = 1000;
                    t.Enabled = true;
                    t.Tick += T_Tick;
                }
                else
                {
                    if (this.Controls.Count > 0)
                        this.Controls[0].Enabled = false;
                    t.Enabled = false;
                    this.Text = "[Blocked] " + title;
                    this.ControlBox = true;
                }
            }
        }

        private void loadSkin()
        {
            if (DateTime.Now.ToString("dd-MM-yyyy").Equals("14-02-" + DateTime.Now.Year)
                || DateTime.Now.ToString("dd-MM-yyyy").Equals("13-02-" + DateTime.Now.Year)
                || DateTime.Now.ToString("dd-MM-yyyy").Equals("15-02-" + DateTime.Now.Year))
                skinApp.LookAndFeel.SkinName = "Valentine";
            else if (DateTime.Now.Month == 12)
                skinApp.LookAndFeel.SkinName = "Xmas 2008 Blue";
            else if (DateTime.Now.ToString("dd-MM-yyyy").Equals("29-10-" + DateTime.Now.Year)
                || DateTime.Now.ToString("dd-MM-yyyy").Equals("30-10-" + DateTime.Now.Year)
                || DateTime.Now.ToString("dd-MM-yyyy").Equals("31-10-" + DateTime.Now.Year))
                skinApp.LookAndFeel.SkinName = "Pumpkin";
            else if (DateTime.Now.Month == 6)
                skinApp.LookAndFeel.SkinName = "Summer 2008";
            else if (DateTime.Now.Month == 1)
                skinApp.LookAndFeel.SkinName = "Springtime";
        }

        private void frmMain_MouseClick(object sender, MouseEventArgs e)
        {
            if (!UserConfig.getIsActive())
            {
                if (UserConfig.getTimeLeft() <= 0)
                {
                    disableForm();
                }
            }
        }
    }
}
