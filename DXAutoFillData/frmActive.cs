using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (key == "aedve")
            {
                UserConfig.setIsActive(true);
                XtraMessageBox.Show("Kích hoạt phần mềm thành công!", "Thông báo");
                if (isActive != null)
                {
                    isActive(true);
                    Close();
                }
            }else
            {
                XtraMessageBox.Show("Mã kích hoạt không chính xác", "Thông báo");
            }
        }
    }
}
