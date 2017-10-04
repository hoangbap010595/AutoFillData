using DevExpress.XtraEditors;
using System;

namespace DXAutoFillData
{
    public partial class frmActive : XtraForm
    {
        public frmActive()
        {
            InitializeComponent();
        }
        public delegate void ActiveOK(bool active);
        public ActiveOK isActive;

        private void btnActive_Click(object sender, EventArgs e)
        {
            string key = txtKey.Text;
            if (key == "XmI5L3-G3ig93-102017")
            {
                UserConfig.setIsActive(true);
                XtraMessageBox.Show("Kích hoạt phần mềm thành công!", "Thông báo");
                if (isActive != null)
                {
                    btnActive.Enabled = false;
                    isActive(true);
                    this.Close();
                }
            }else
            {
                XtraMessageBox.Show("Mã kích hoạt không chính xác", "Thông báo");
            }
        }
    }
}
