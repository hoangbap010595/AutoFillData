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
    public partial class UC_WebBrowser : XtraUserControl
    {
        public UC_WebBrowser()
        {
            InitializeComponent();
        }

        private void UC_WebBrowser_Load(object sender, EventArgs e)
        {
            loadWebBrowser();
        }
        private void loadWebBrowser()
        {
            webBrowserMain.Visible = true;
            webBrowserMain.ScriptErrorsSuppressed = true;
            webBrowserMain.Navigate("https://laodongkynghi.info/mau-dang-ky-thu-gioi-thieu/");
            webBrowserMain.DocumentCompleted += WebBrowserMain_DocumentCompleted;
        }

        private void WebBrowserMain_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            xtraTabControlMain.TabPages[0].Text = webBrowserMain.DocumentTitle;
            //XtraMessageBox.Show("Load OK");
            webBrowserMain.Document.GetElementById("pwbox-697").InnerText = "CMXNrczjIJelgcv*)2%zZjGs";
            
            //webBrowserMain.Document.Forms[0].InvokeMember("submit");

            HtmlElementCollection links = webBrowserMain.Document.GetElementsByTagName("input");

            foreach (HtmlElement link in links)
            {
                if (link.InnerText.Equals("Enter"))
                    link.InvokeMember("Click");
            }

        }

        private void SubmitForm(String formName)
        {
            HtmlElementCollection elems = null;
            HtmlElement elem = null;

            if (webBrowserMain.Document != null)
            {
                HtmlDocument doc = webBrowserMain.Document;
                elems = doc.All.GetElementsByName(formName);
                if (elems != null && elems.Count > 0)
                {
                    elem = elems[0];
                    if (elem.TagName.Equals("FORM"))
                    {
                        elem.InvokeMember("Submit");
                    }
                }
            }
        }
    }
}
