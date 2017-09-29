using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using System.Threading;

namespace DXAutoFillData.UControls
{
    public partial class UC_Main : XtraUserControl
    {
        private System.Windows.Forms.Timer _timer;
        private int timeRight = 0;
        public UC_Main()
        {
            InitializeComponent();
            loadConfig();

        }
        private void loadConfig()
        {
            txtTarget.Text = UserConfig.getUTargetUrl();
            txtPassword.Text = UserConfig.getUPassword();
            ckAutoLogin.Checked = UserConfig.getUAutoLogin();

            ckAutoCloseForm.Checked = UserConfig.getSAutoCloseForm();
            ckAutoClickSubmit.Checked = UserConfig.getSAutoSubmit();
            ckAutoChooseOptions.Checked = UserConfig.getSAutoChooseOptions();
            ckClearCache.Checked = UserConfig.getSAutoClearCache();

            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 1000;
            _timer.Tick += _timer_Tick;

        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            timeRight++;
            lblTimeExecute.Text = timeRight.ToString() + "s";
        }

        private void btnUpdateHeThong_Click(object sender, EventArgs e)
        {
            try
            {
                var ckAuto = ckAutoLogin.Checked;
                var url = txtTarget.Text.Trim();
                var pass = txtPassword.Text.Trim();
                UserConfig.setUTargetUrl(url);
                UserConfig.setUPassword(pass);
                UserConfig.setUAutoLogin(ckAuto);

                XtraMessageBox.Show("Cập nhật thành công");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("" + ex.Message, "Lỗi");
            }

        }
        private void btnUpdateSystem_Click(object sender, EventArgs e)
        {
            try
            {
                var ckClose = ckAutoCloseForm.Checked;
                var ckClick = ckAutoClickSubmit.Checked;
                var ckChoose = ckAutoChooseOptions.Checked;
                var ckClear = ckClearCache.Checked;

                UserConfig.setSAutoCloseForm(ckClose);
                UserConfig.setSAutoSubmit(ckClick);
                UserConfig.setSAutoChooseOptions(ckChoose);
                UserConfig.setSAutoClearCache(ckClear);

                XtraMessageBox.Show("Cập nhật thành công");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("" + ex.Message, "Lỗi");
            }
        }
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "Excel .xlsx|*.xlsx|Excel .xls|*.xls";
                if (DialogResult.OK == op.ShowDialog())
                {
                    txtFilePath.Text = op.FileName.Trim();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("" + ex.Message, "Lỗi");
            }
        }

        private void btnViewData_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFilePath.Text != "")
                {
                    //DataTable dt = OpenFileExcel.getDataExcelFromFileToDataTable(txtFilePath.Text);
                    //dt.Rows.RemoveAt(0);
                    //UC_ViewData uc = new UC_ViewData(dt);
                    //frmShowWindow frm = new frmShowWindow();
                    //frm.Controls.Clear();
                    //uc.Dock = DockStyle.Fill;
                    //frm.Text = "Hiển thị dữ liệu";
                    //frm.Controls.Add(uc);
                    //frm.ShowDialog();
                }
                else
                {
                    XtraMessageBox.Show("Bạn chưa chọn file để hiển thị");
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("" + ex.Message, "Lỗi");
            }
        }

        private void btnGetForm_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            f.Description = "Chọn thư mục lưu trữ form dữ liệu";
            string filePath = "";
            if (f.ShowDialog() == DialogResult.OK)
            {
                filePath = OpenFileExcel.moveFile(f.SelectedPath);
                if (DialogResult.OK == XtraMessageBox.Show("Mở file \"" + Path.GetFileName(filePath) + "\" ?", "", MessageBoxButtons.OKCancel))
                {
                    System.Diagnostics.Process.Start(filePath);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == XtraMessageBox.Show("Đóng ứng dụng ?", "Thông báo", MessageBoxButtons.OKCancel))
            {
                Application.Exit();
            }
        }

        private void setCountSubmit(int count)
        {
            lblSubmitSuccess.Text = count.ToString();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFilePath.Text == "")
                {
                    timeRight = 0;
                    lblSubmitSuccess.Text = "0";
                    _timer.Enabled = true;
                    btnStart.Enabled = false;
                    btnStop.Enabled = true;
                    //DataTable dt = OpenFileExcel.getDataExcelFromFileToDataTable(txtFilePath.Text);
                    UC_WebBrowser uc = new UC_WebBrowser();
                    uc.sendCount = new UC_WebBrowser.sendCountSubmit(setCountSubmit);
                    frmShowWindow frm = new frmShowWindow();
                    frm.Controls.Clear();
                    uc.Dock = DockStyle.Fill;
                    frm.Text = "Đang thực hiện quá trình Auto Fill Data...";
                    frm.ControlBox = false;
                    frm.Controls.Add(uc);
                    frm.Show();
                }
                else
                {
                    XtraMessageBox.Show("Bạn chưa chọn file để hiển thị");
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("" + ex.Message, "Lỗi");
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["frmShowWindow"];
            if (f != null)
                f.Close();

            _timer.Enabled = false;
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void btnInfomation_Click(object sender, EventArgs e)
        {
            string message = "Phần mềm Auto Fill Data V1.0.0";
            message += "\nDate: \t\t\t\t29.09.2017 01:30 AM";
            message += "\nDescription:\t\t...";
            message += "\nDesign by:\t\t HoangLC";
            message += "\nEmail:\t\t\t\t ...@gmail.com";
            XtraMessageBox.Show(message, "Thông tin");
        }
    }
}
