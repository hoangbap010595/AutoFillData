using System;
using System.Windows;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Net;
using DevExpress.XtraTab;

namespace DXAutoFillData.UControls
{
    public partial class UC_WebBrowser : XtraUserControl
    {
        WebBrowser webBrowserMain;
        bool isSubmit = false;
        bool isClick = false;
        int count = 0;
        public UC_WebBrowser()
        {
            InitializeComponent();
            //autoIT.ControlFocus()
        }

        private void UC_WebBrowser_Load(object sender, EventArgs e)
        {
            CreateWebBrowser();

        }

        public delegate void sendCountSubmit(int count);
        public sendCountSubmit sendCount;

        private void CreateWebBrowser()
        {
            xtraTabPageOne.Controls.Add(webBrowserMain);

            webBrowserMain = new WebBrowser();
            webBrowserMain.Parent = xtraTabPageOne;
            webBrowserMain.Dock = System.Windows.Forms.DockStyle.Fill;
            webBrowserMain.Location = new System.Drawing.Point(0, 0);
            webBrowserMain.MinimumSize = new System.Drawing.Size(20, 20);
            webBrowserMain.Name = "webBrowserMain";
            webBrowserMain.Size = new System.Drawing.Size(709, 321);
            webBrowserMain.TabIndex = 0;
            webBrowserMain.Url = new System.Uri("", System.UriKind.Relative);
            webBrowserMain.Visible = true;
            webBrowserMain.ScriptErrorsSuppressed = true;
            webBrowserMain.Document.Window.Navigate(UserConfig.getUTargetUrl());
            //webBrowserMain.Url = new System.Uri(UserConfig.getUTargetUrl(), System.UriKind.Relative);
            webBrowserMain.DocumentCompleted += WebBrowserMain_DocumentCompleted;

            if (UserConfig.getSAutoClearCache())
            {
                bool b = WebBrowserHelper.InternetSetOption(IntPtr.Zero, 42, IntPtr.Zero, 0);
                string[] theCookies = System.IO.Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Cookies));
                foreach (string currentFile in theCookies)
                {
                    try
                    {
                        System.IO.File.Delete(currentFile);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("[ClearCache]: " + ex.Message);
                    }
                }
            }
            //xtraTabPageOne.Controls.Add(webBrowserMain);
        }

        private void WebBrowserMain_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            try
            {
                xtraTabControlMain.SelectedTabPage.Text = webBrowserMain.DocumentTitle;

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
                                link.InvokeMember("Click");
                            }
                        }
                    }
                }
                webBrowserMain.Document.Window.ScrollTo(0, 500);

                fillData();
                if (isSubmit)
                {
                    isSubmit = false;
                    isClick = false;
                    sendCount(count);
                    webBrowserMain.Document.Window.Navigate(UserConfig.getUTargetUrl());
                }
                Console.WriteLine("WebBrowserReadyState.Interactive");

                webBrowserMain.Document.Body.MouseDown += Body_MouseDown;
            }
            catch (Exception ex)
            {
                Console.WriteLine("[WebBrowserMain_DocumentCompleted]: " + ex.Message);
                //XtraMessageBox.Show(ex.Message + "\nVui lòng liên hệ IT hỗ trợ.", "Xảy ra lỗi");
            }

        }

        private void Body_MouseDown(object sender, HtmlElementEventArgs e)
        {
            switch (e.MouseButtonsPressed)
            {
                case MouseButtons.Left:
                    HtmlElement element = this.webBrowserMain.Document.GetElementFromPoint(e.ClientMousePosition);
                    if (element != null && "submit".Equals(element.GetAttribute("type"), StringComparison.OrdinalIgnoreCase))
                    {
                        isClick = true;
                        isSubmit = true;
                        count++;
                        break;
                    }
                    break;
            }
        }

        private void fillData()
        {
            HtmlElementCollection elementsInput = webBrowserMain.Document.GetElementsByTagName("input");
            HtmlElementCollection elementsSelect = webBrowserMain.Document.GetElementsByTagName("select");
            HtmlElementCollection elementsButton = webBrowserMain.Document.GetElementsByTagName("button");
            // We have to use this form because of the lambda expression that is used to pass
            // in the element instance to the handler. This is the only way to actually get
            // the element instance, as the instance is not passed in if we just provide the
            // event sink method name.
            #region ===== Tag Input
            if (elementsInput.Count > 0 && elementsInput != null)
            {
                elementsInput[0].Id = "txtFullName";
                elementsInput[1].Id = "txtStreet";
                elementsInput[2].Id = "txtWard";
                elementsInput[3].Id = "txtDistrict";
                elementsInput[4].Id = "txtCurrAddress";
                elementsInput[5].Id = "txtCMND";
                elementsInput[6].Id = "txtIssuedBy";

                elementsInput[9].Id = "txtEmail";
                elementsInput[10].Id = "txtPhone";
                elementsInput[11].Id = "txtNgoaiNgu";

                elementsInput[12].Id = "txtChuaTotNghiep";
                elementsInput[13].Id = "txtDaTotNghiep";

                elementsInput[14].Id = "txtTruongDaiHoc";
                elementsInput[15].Id = "txtSoNam";
                elementsInput[16].Id = "txtMaSoVanBang";
                elementsInput[17].Id = "txtNamTotNghiep";
                elementsInput[18].Id = "txtFullNameRef";
                elementsInput[19].Id = "txtPhoneRef";
                elementsInput[20].Id = "txtAddressRef";


                webBrowserMain.Document.GetElementById("txtFullName").InnerText = "Nguyễn Văn A";
                webBrowserMain.Document.GetElementById("txtStreet").InnerText = "Lý Thông";
                webBrowserMain.Document.GetElementById("txtWard").InnerText = "Binh Thuan";
                webBrowserMain.Document.GetElementById("txtDistrict").InnerText = "Quận 7";
                webBrowserMain.Document.GetElementById("txtCurrAddress").InnerText = "Quảng sơn ninh sơn ninh thuận";
                webBrowserMain.Document.GetElementById("txtCMND").InnerText = "192848596";
                webBrowserMain.Document.GetElementById("txtIssuedBy").InnerText = "Ninh Thuan";
                webBrowserMain.Document.GetElementById("datepicker1").InnerText = "29-09-2017";
                webBrowserMain.Document.GetElementById("datepicker2").SetAttribute("value", "30-09-2017");
                webBrowserMain.Document.GetElementById("txtEmail").SetAttribute("value", "lchoang1995@gmail.com");
                webBrowserMain.Document.GetElementById("txtPhone").SetAttribute("value", "648596585");
                webBrowserMain.Document.GetElementById("txtNgoaiNgu").SetAttribute("value", "Tiếng Việt, Tiếng Anh");
                webBrowserMain.Document.GetElementById("txtTruongDaiHoc").SetAttribute("value", "Sư phạm kỹ thuật");
                webBrowserMain.Document.GetElementById("txtSoNam").SetAttribute("value", "5");
                webBrowserMain.Document.GetElementById("txtMaSoVanBang").SetAttribute("value", "KI8548");
                webBrowserMain.Document.GetElementById("txtNamTotNghiep").SetAttribute("value", "2017");
                webBrowserMain.Document.GetElementById("txtFullNameRef").SetAttribute("value", "Cao Thi A");
                webBrowserMain.Document.GetElementById("txtPhoneRef").SetAttribute("value", "0122684895");
                webBrowserMain.Document.GetElementById("txtAddressRef").SetAttribute("value", "Camboia hoekalsdf");

                webBrowserMain.Document.GetElementById("txtChuaTotNghiep").SetAttribute("checked", "");
                webBrowserMain.Document.GetElementById("txtDaTotNghiep").SetAttribute("checked", "1");
            }
            #endregion

            #region ===== Tag Select
            if (elementsSelect.Count > 0 && elementsSelect != null)
            {
                elementsSelect[0].Id = "txtDay";
                elementsSelect[1].Id = "txtMonth";
                elementsSelect[2].Id = "txtYear";
                elementsSelect[3].Id = "txtGender";
                elementsSelect[4].Id = "txtMarriage";

                elementsSelect[6].Id = "txtFromYear";
                elementsSelect[7].Id = "txtToYear";
                elementsSelect[8].Id = "txtChinhQui";

                webBrowserMain.Document.GetElementById("txtDay").SetAttribute("value", "15");
                webBrowserMain.Document.GetElementById("txtMonth").SetAttribute("value", "10");
                webBrowserMain.Document.GetElementById("txtYear").SetAttribute("value", "2000");
                webBrowserMain.Document.GetElementById("txtGender").SetAttribute("value", "Nam");//Nữ
                webBrowserMain.Document.GetElementById("txtMarriage").SetAttribute("value", "Độc thân");//Đã kết hôn, Đã ly hôn
                                                                                                        //Tỉnh thành
                                                                                                        //webBrowserMain.Document.GetElementById("slPref_cd").SetAttribute("value", "44");
                var xElementCollection = webBrowserMain.Document.GetElementById("slPref_cd").GetElementsByTagName("option");
                foreach (HtmlElement el in xElementCollection)
                {
                    if (el.InnerText.Contains("Ninh Thuận"))
                    {
                        el.SetAttribute("selected", "selected");
                        //el.InvokeMember("click");
                    }
                }
                webBrowserMain.Document.GetElementById("txtFromYear").SetAttribute("value", "2015");
                webBrowserMain.Document.GetElementById("txtToYear").SetAttribute("value", "2017");
                webBrowserMain.Document.GetElementById("txtChinhQui").SetAttribute("value", "Có");//Không
            }
            #endregion

            #region===== Tag Button
            if (UserConfig.getSAutoSubmit())
            {
                if (elementsButton.Count > 0 && elementsButton != null)
                    foreach (HtmlElement item in elementsButton)
                    {
                        if (item.GetAttribute("type") == "submit")
                        {
                            if (!isClick && !isSubmit)
                            {
                                isClick = true;
                                isSubmit = true;
                                item.InvokeMember("Click");
                                count++;
                                break;
                            }
                            //Console.WriteLine(item.InnerText);
                        }
                    }
            }
            #endregion
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
