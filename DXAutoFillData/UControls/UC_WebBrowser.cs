using System;
using System.Windows;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Net;

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
            if (UserConfig.getSAutoClearCache())
            {
                bool b =  WebBrowserHelper.InternetSetOption(IntPtr.Zero, 42, IntPtr.Zero, 0);
                webBrowserMain.Document.ExecCommand("ClearAuthenticationCache", true, null);
                string[] theCookies = System.IO.Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Cookies));
                foreach (string currentFile in theCookies)
                {
                    try
                    {
                        System.IO.File.Delete(currentFile);
                    }
                    catch
                    {
                    }
                }

            }
            webBrowserMain.Visible = true;
            webBrowserMain.ScriptErrorsSuppressed = true;             
            webBrowserMain.Document.Window.Navigate(UserConfig.getUTargetUrl());
            //webBrowserMain.Url = new System.Uri(UserConfig.getUTargetUrl(), System.UriKind.Relative);
            webBrowserMain.DocumentCompleted += WebBrowserMain_DocumentCompleted;
        }

        private void WebBrowserMain_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            try
            {
                xtraTabControlMain.TabPages[0].Text = webBrowserMain.DocumentTitle;

                //Tự động đăng nhập
                if (UserConfig.getUAutoLogin())
                {
                    if (webBrowserMain.Document.GetElementById("pwbox-697") != null)
                    {
                        webBrowserMain.Document.GetElementById("pwbox-697").InnerText = UserConfig.getUPassword();
                        HtmlElementCollection links = webBrowserMain.Document.GetElementsByTagName("input");

                        foreach (HtmlElement link in links)
                        {
                            if (link != null && link.Name == "Submit")
                            {
                                //link.InnerText.Equals("Enter");
                                link.InvokeMember("Click");
                            }
                        }
                    }
                }
            }catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message + "\nVui lòng liên hệ IT hỗ trợ.", "Xảy ra lỗi");
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
