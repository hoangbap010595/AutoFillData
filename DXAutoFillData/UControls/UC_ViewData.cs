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

namespace DXAutoFillData.UControls
{
    public partial class UC_ViewData : XtraUserControl
    {
        private DataTable _data;
        public UC_ViewData()
        {
            InitializeComponent();
        }
        public UC_ViewData(DataTable dt)
        {
            InitializeComponent();
            _data = dt;
            gridControlData.DataSource = _data;
        }

        private void UC_ViewData_Load(object sender, EventArgs e)
        {

        }
    }
}
