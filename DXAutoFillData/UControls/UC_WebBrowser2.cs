using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using System.Collections.Generic;

namespace DXAutoFillData.UControls
{

    public partial class UC_WebBrowser2 : XtraUserControl
    {
        private WebBrowser webBrowserOne = new WebBrowser();
        private WebBrowser webBrowserTwo = new WebBrowser();
        private WebBrowser webBrowserThree = new WebBrowser();
        private WebBrowser webBrowserFour = new WebBrowser();
        private WebBrowser webBrowserFive = new WebBrowser();
        private WebBrowser webBrowserSix = new WebBrowser();

        private bool isSubmit = false;
        private bool isClick = false;
        private int count = 0;
        private List<Dictionary<string, object>> _lsDataOne;
        private List<Dictionary<string, object>> _lsDataTwo;
        private List<Dictionary<string, object>> _lsDataThree;
        private List<Dictionary<string, object>> _lsDataFour;
        private List<Dictionary<string, object>> _lsDataFive;
        private List<Dictionary<string, object>> _lsDataSix;
        private int indexOne = 0;
        private int indexTwo = 0;
        private int indexThree = 0;
        private int indexFour = 0;
        private int indexFive = 0;
        private int indexSix = 0;

        public UC_WebBrowser2()
        {
            InitializeComponent();
        }
        public UC_WebBrowser2(List<List<Dictionary<string, object>>> ls)
        {
            InitializeComponent();
            _lsDataOne = ls[0];
            _lsDataTwo = ls[1];
            _lsDataThree = ls[2];
            _lsDataFour = ls[3];
            _lsDataFive = ls[4];
            _lsDataSix = ls[5];
        }

        private void UC_WebBrowser_Load(object sender, EventArgs e)
        {

        }

        public delegate void sendCountSubmit(int count);
        public sendCountSubmit sendCount;


    }
}
