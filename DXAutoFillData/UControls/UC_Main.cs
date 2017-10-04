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
        private List<Dictionary<string, object>> lsData;
        private List<List<Dictionary<string, object>>> lsAllData;
        public UC_Main()
        {
            InitializeComponent();           
            loadConfig();
        }
        private void loadConfig()
        {
            //UserConfig.setTimeLeft(600);//XmI5L3-G3ig93-102017
            //UserConfig.setIsActive(false);
            if (UserConfig.getIsActive())
            {
                btnUpdateHeThong.Enabled = btnUpdateSystem.Enabled = true;
                btnAcctive.Visible = false;
            }
            else
            {       
                btnUpdateHeThong.Enabled = btnUpdateSystem.Enabled = false;
                UserConfig.setUAutoLogin(false);
                UserConfig.setSAutoCloseForm(false);
                UserConfig.setSAutoSubmit(false);
                UserConfig.setSAutoEnterData(true);
                UserConfig.setSAutoClearCache(false);
                btnAcctive.Visible = true;
            }
            
            txtTarget.Text = UserConfig.getUTargetUrl();
            txtPassword.Text = UserConfig.getUPassword();
            ckAutoLogin.Checked = UserConfig.getUAutoLogin();

            ckAutoCloseForm.Checked = UserConfig.getSAutoCloseForm();
            ckAutoClickSubmit.Checked = UserConfig.getSAutoSubmit();
            ckAutoEnterData.Checked = UserConfig.getSAutoEnterData();
            ckClearCache.Checked = UserConfig.getSAutoClearCache();

            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 1000;
            _timer.Tick += _timer_Tick;
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            timeRight++;
            lblTimeExecute.Text = timeRight + "s";
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
                var ckChoose = ckAutoEnterData.Checked;
                var ckClear = ckClearCache.Checked;

                UserConfig.setSAutoCloseForm(ckClose);
                UserConfig.setSAutoSubmit(ckClick);
                UserConfig.setSAutoEnterData(ckChoose);
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
                    btnStart.Enabled = false;
                    txtFilePath.Text = op.FileName.Trim();
                    Thread t = new Thread(new ThreadStart(()=> {
                        try
                        {
                            lsData = OpenFileExcel.getDataExcelFromFileToList(op.FileName.Trim());
                            lsData.RemoveAt(0);
                            lsAllData = loadDataToList(lsData);
                            btnStart.Invoke((MethodInvoker)delegate { btnStart.Enabled = true; });
                        }
                        catch (Exception ex)
                        {
                            XtraMessageBox.Show("" + ex.Message, "Thông báo lỗi");
                        }
                    }));
                    t.Start();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("" + ex.Message, "Lỗi");
            }
        }
        private List<List<Dictionary<string, object>>> loadDataToList(List<Dictionary<string, object>> ls)
        {
            List<List<Dictionary<string, object>>> allData = new List<List<Dictionary<string, object>>>();
            List<Dictionary<string, object>> _lsDataOne = new List<Dictionary<string, object>>();
            List<Dictionary<string, object>> _lsDataTwo = new List<Dictionary<string, object>>();
            List<Dictionary<string, object>> _lsDataThree = new List<Dictionary<string, object>>();
            List<Dictionary<string, object>> _lsDataFour = new List<Dictionary<string, object>>();
            List<Dictionary<string, object>> _lsDataFive = new List<Dictionary<string, object>>();
            List<Dictionary<string, object>> _lsDataSix = new List<Dictionary<string, object>>();

            int total = ls.Count;
            int num = total / 6;
            int index = 0;
            if (num == 0)
            {
                for (; index < ls.Count; index++)
                {
                    _lsDataOne.Add(ls[index]);
                    index++;
                }
            }
            else
            {
                for (; index < num; index++)
                {
                    _lsDataOne.Add(ls[index]);
                }
                for (; index < num * 2; index++)
                {
                    _lsDataTwo.Add(ls[index]);
                }
                for (; index < num * 3; index++)
                {
                    _lsDataThree.Add(ls[index]);
                }
                for (; index < num * 4; index++)
                {
                    _lsDataFour.Add(ls[index]);
                }
                for (; index < num * 5; index++)
                {
                    _lsDataFive.Add(ls[index]);
                }
                for (; index < ls.Count; index++)
                {
                    _lsDataSix.Add(ls[index]);
                }
            }
            allData.Add(_lsDataOne);
            allData.Add(_lsDataTwo);
            allData.Add(_lsDataThree);
            allData.Add(_lsDataFour);
            allData.Add(_lsDataFive);
            allData.Add(_lsDataSix);
            return allData;

        }
        private void btnViewData_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFilePath.Text != "")
                {
                    DataTable dt = OpenFileExcel.getDataExcelFromFileToDataTable(txtFilePath.Text);
                    dt.Rows.RemoveAt(0);
                    UC_ViewData uc = new UC_ViewData(dt);
                    frmShowWindow frm = new frmShowWindow();
                    frm.Controls.Clear();
                    uc.Dock = DockStyle.Fill;
                    frm.Text = "Hiển thị dữ liệu";
                    frm.Controls.Add(uc);
                    frm.ShowDialog();
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
            if (count == lsData.Count() && UserConfig.getSAutoCloseForm())
            {
                _timer.Enabled = false;
                btnStart.Enabled = true;
                btnStop.Enabled = false;
                Form f = Application.OpenForms["frmShowWindow"];
                if (f != null)
                    f.Close();
                XtraMessageBox.Show("Đã xử lý thành công: " + count + "/" + lsData.Count + " bản ghi", "Thông báo");
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFilePath.Text != "")
                {
                    timeRight = 0;
                    lblSubmitSuccess.Text = "0";
                    _timer.Enabled = true;
                    btnStart.Enabled = false;
                    btnStop.Enabled = true;
                    UC_WebBrowser uc = new UC_WebBrowser(lsAllData);
                    uc.sendCount = new UC_WebBrowser.sendCountSubmit(setCountSubmit);
                    frmShowWindow frm = new frmShowWindow();
                    frm.Controls.Clear();
                    uc.Dock = DockStyle.Fill;
                    frm.Text = "Đang thực hiện quá trình submit dữ liệu...";
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
            string message = "Phần mềm Auto Fill Data";
            message += "\n\nDate: \t\t\t\t29.09.2017 01:30 AM";
            message += "\nDescription:\t\t...";
            message += "\nDesign by:\t\t HoangLC";
            message += "\nEmail:\t\t\t\t lchoang1995@gmail.com";
            message += "\nVersion:\t\t\t 1.0.0";
            XtraMessageBox.Show(message, "Thông tin");
        }

        private void btnAcctive_Click(object sender, EventArgs e)
        {
            frmActive frmActive = new frmActive();
            frmActive.ShowDialog();
        }
    }
}
