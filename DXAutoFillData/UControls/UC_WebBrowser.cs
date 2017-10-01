using System;
using System.Windows;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Net;
using DevExpress.XtraTab;
using System.Threading;
using System.Collections.Generic;

namespace DXAutoFillData.UControls
{

    public partial class UC_WebBrowser : XtraUserControl
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
        private List<Dictionary<string, object>> _lsData;
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

        public UC_WebBrowser()
        {
            InitializeComponent();
        }
        public UC_WebBrowser(List<Dictionary<string, object>> ls)
        {
            InitializeComponent();
            _lsData = ls;
        }

        private void UC_WebBrowser_Load(object sender, EventArgs e)
        {
            CreateWebBrowser(xtraTabPageOne, webBrowserOne);
            //CreateWebBrowser(xtraTabPageTwo, webBrowserTwo);
            //CreateWebBrowser(xtraTabPageThree, webBrowserThree);
            //CreateWebBrowser(xtraTabPageFour, webBrowserFour);
            //CreateWebBrowser(xtraTabPageFive, webBrowserFive);
            //CreateWebBrowser(xtraTabPageSix, webBrowserSix);
        }

        public delegate void sendCountSubmit(int count);
        public sendCountSubmit sendCount;

        [STAThread]
        private void CreateWebBrowser(XtraTabPage tabPage, WebBrowser webBrowser)
        {
            tabPage.Invoke((MethodInvoker)delegate
            {
                tabPage.Controls.Add(webBrowser);
            });
            webBrowser.Invoke((MethodInvoker)delegate
            {
                webBrowser.Parent = tabPage;
                webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
                webBrowser.Location = new System.Drawing.Point(0, 0);
                webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
                webBrowser.Name = "webBrowserMain";
                webBrowser.Size = new System.Drawing.Size(709, 321);
                webBrowser.TabIndex = 0;
                webBrowser.Url = new System.Uri("", System.UriKind.Relative);
                webBrowser.Visible = true;
                webBrowser.ScriptErrorsSuppressed = true;
                webBrowser.Navigate(UserConfig.getUTargetUrl());
                //webBrowserMain.Url = new System.Uri(UserConfig.getUTargetUrl(), System.UriKind.Relative);
                webBrowser.DocumentCompleted += (sender, e) => WebBrowserOne_DocumentCompleted(tabPage, webBrowser, sender, e);

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
            });

        }

        #region ===Event Browser====
        private void WebBrowserOne_DocumentCompleted(XtraTabPage tabPage, WebBrowser webBrowser, object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            try
            {
                tabPage.Text = webBrowser.DocumentTitle;
                //Tự động đăng nhập
                if (UserConfig.getUAutoLogin())
                {
                    if (webBrowser.Document.GetElementById("pwbox-697") != null)
                    {
                        webBrowser.Document.GetElementById("pwbox-697").InnerText = UserConfig.getUPassword();
                        HtmlElementCollection links = webBrowser.Document.GetElementsByTagName("input");

                        foreach (HtmlElement link in links)
                        {
                            if (link != null && link.Name == "Submit")
                            {
                                link.InvokeMember("Click");
                            }
                        }
                    }
                }
                if (webBrowser.Url.AbsoluteUri.Equals(UserConfig.getUTargetUrl()))
                {
                    webBrowser.Document.Window.ScrollTo(0, 500);

                    //Tự đông nhập dữ liệu
                    if (UserConfig.getSAutoEnterData())
                    {
                        switch (tabPage.Name)
                        {
                            case "xtraTabPageOne":
                                fillData(webBrowser, _lsData[indexOne]);
                                break;
                            case "xtraTabPageTwo":
                                fillData(webBrowser, _lsData[indexTwo]);
                                break;
                            case "xtraTabPageThree":
                                fillData(webBrowser, _lsData[indexThree]);
                                break;
                            case "xtraTabPageFour":
                                fillData(webBrowser, _lsData[indexFour]);
                                break;
                            case "xtraTabPageFive":
                                fillData(webBrowser, _lsData[indexFive]);
                                break;
                            case "xtraTabPageSix":
                                fillData(webBrowser, _lsData[indexSix]);
                                break;
                        }
                       
                        if (webBrowser.ReadyState == WebBrowserReadyState.Interactive)
                        {
                            if (isSubmit)
                            {
                                isSubmit = false;
                                isClick = false;
                                switch (tabPage.Name)
                                {
                                    case "xtraTabPageOne":
                                        indexOne++;
                                        break;
                                    case "xtraTabPageTwo":
                                        indexTwo++;
                                        break;
                                    case "xtraTabPageThree":
                                        indexThree++;
                                        break;
                                    case "xtraTabPageFour":
                                        indexFour++;
                                        break;
                                    case "xtraTabPageFive":
                                        indexFive++;
                                        break;
                                    case "xtraTabPageSix":
                                        indexSix++;
                                        break;
                                }
                                sendCount(count);
                                webBrowser.Navigate(UserConfig.getUTargetUrl());
                            }
                            webBrowser.Document.Body.MouseDown += (sender2, e2) => Body_MouseDown(webBrowser, sender2, e2);
                            Console.WriteLine("WebBrowserReadyState.Interactive");
                        }

                    }
                }
                else
                    webBrowser.Navigate(UserConfig.getUTargetUrl());
            }
            catch (Exception ex)
            {
                Console.WriteLine("[WebBrowserMain_DocumentCompleted]: " + ex.Message);
                //XtraMessageBox.Show(ex.Message + "\nVui lòng liên hệ IT hỗ trợ.", "Xảy ra lỗi");
            }

        }
        private void Body_MouseDown(WebBrowser webBrowser, object sender, HtmlElementEventArgs e)
        {
            switch (e.MouseButtonsPressed)
            {
                case MouseButtons.Left:
                    HtmlElement element = webBrowser.Document.GetElementFromPoint(e.ClientMousePosition);
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
        #endregion

        private void fillData(WebBrowser webBrowser, Dictionary<string, object> data)
        {
            HtmlElementCollection elementsInput = webBrowser.Document.GetElementsByTagName("input");
            HtmlElementCollection elementsSelect = webBrowser.Document.GetElementsByTagName("select");
            HtmlElementCollection elementsButton = webBrowser.Document.GetElementsByTagName("button");
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


                webBrowser.Document.GetElementById("txtFullName").InnerText = data["FullName"].ToString().Trim();
                webBrowser.Document.GetElementById("txtStreet").InnerText = data["Street"].ToString().Trim();
                webBrowser.Document.GetElementById("txtWard").InnerText = data["Ward"].ToString().Trim();
                webBrowser.Document.GetElementById("txtDistrict").InnerText = data["District"].ToString().Trim();
                webBrowser.Document.GetElementById("txtCurrAddress").InnerText = data["CurrentAddress"].ToString().Trim();
                webBrowser.Document.GetElementById("txtCMND").InnerText = data["Passport"].ToString().Trim();
                webBrowser.Document.GetElementById("txtIssuedBy").InnerText = data["IssuedBy"].ToString().Trim();

                webBrowser.Document.GetElementById("datepicker1").InnerText = data["DateRange"].ToString().Trim();
                webBrowser.Document.GetElementById("datepicker2").SetAttribute("value", data["DateExpired"].ToString().Trim());

                webBrowser.Document.GetElementById("txtEmail").SetAttribute("value", data["Email"].ToString().Trim());
                webBrowser.Document.GetElementById("txtPhone").SetAttribute("value", data["Phone"].ToString().Trim());
                webBrowser.Document.GetElementById("txtNgoaiNgu").SetAttribute("value", data["Languges"].ToString().Trim());
                webBrowser.Document.GetElementById("txtTruongDaiHoc").SetAttribute("value", data["University"].ToString().Trim());
                webBrowser.Document.GetElementById("txtSoNam").SetAttribute("value", data["NYear"].ToString().Trim());
                webBrowser.Document.GetElementById("txtMaSoVanBang").SetAttribute("value", data["NumOfDip"].ToString().Trim());
                webBrowser.Document.GetElementById("txtNamTotNghiep").SetAttribute("value", data["GradYear"].ToString().Trim());
                webBrowser.Document.GetElementById("txtFullNameRef").SetAttribute("value", data["FullNameRef"].ToString().Trim());
                webBrowser.Document.GetElementById("txtPhoneRef").SetAttribute("value", data["PhoneRef"].ToString().Trim());
                webBrowser.Document.GetElementById("txtAddressRef").SetAttribute("value", data["AddressRef"].ToString().Trim());

                string check = data["Status"].ToString().Trim() == "CTN" ? "1" : "0";
                webBrowser.Document.GetElementById("txtChuaTotNghiep").SetAttribute("checked", check);
                webBrowser.Document.GetElementById("txtDaTotNghiep").SetAttribute("checked", check);
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

                var DateB = data["DateOfBirth"].ToString().Trim().Split('-');
                var day = int.Parse(DateB[0]) < 10 ? DateB[0].Replace("0", "") : DateB[0];

                webBrowser.Document.GetElementById("txtDay").SetAttribute("value", day);
                webBrowser.Document.GetElementById("txtMonth").SetAttribute("value", DateB[1].ToString());
                webBrowser.Document.GetElementById("txtYear").SetAttribute("value", DateB[2].ToString());

                var xGender = webBrowser.Document.GetElementById("txtGender").GetElementsByTagName("option");
                foreach (HtmlElement el in xGender)
                {
                    if (!el.InnerText.StartsWith("-"))
                    {
                        var x1 = el.InnerText.Equals("Nam");
                        var x2 = data["Gender"].ToString().Trim().Equals("Nam");
                        if (x1 == x2)
                        {
                            el.SetAttribute("selected", "selected");
                            break;
                        }
                    }
                }
                var xMarriage = webBrowser.Document.GetElementById("txtMarriage").GetElementsByTagName("option");
                foreach (HtmlElement el in xMarriage)
                {
                    if (!el.InnerText.StartsWith("-"))
                    {
                        var x1 = el.InnerText.Trim().ToLower().Split(' ');
                        var x2 = data["Marriage"].ToString().Trim().ToLower().Split(' ');
                        if (x1[1].Equals(x2[1]))
                        {
                            el.SetAttribute("selected", "selected");
                            break;
                        }
                        else if (x1[1].StartsWith("k") && x2[1].StartsWith("k"))
                        {
                            el.SetAttribute("selected", "selected");
                            break;
                        }
                    }
                }
                
                var xElementCollection = webBrowser.Document.GetElementById("slPref_cd").GetElementsByTagName("option");
                foreach (HtmlElement el in xElementCollection)
                {
                    var x1 = el.InnerText.Trim().ToUpper();
                    var x2 = data["Province"].ToString().Trim().ToUpper();
                    if (x1.Contains(x2))
                    {
                        el.SetAttribute("selected", "selected");
                        break;
                    }
                }
                
                webBrowser.Document.GetElementById("txtFromYear").SetAttribute("value", data["FromYear"].ToString().Trim());

                var xToYear = webBrowser.Document.GetElementById("txtToYear").GetElementsByTagName("option");
                foreach (HtmlElement el in xToYear)
                {
                    if (el.InnerText != null)
                    {
                        var x1 = int.Parse(el.InnerText.Trim());
                        var x2 = int.Parse(data["ToYear"].ToString().Trim());
                        if (x1 == x2)
                        {
                            el.SetAttribute("selected", "selected");
                            break;
                        }
                    }
                }
                var xChinhQui = webBrowser.Document.GetElementById("txtChinhQui").GetElementsByTagName("option");
                foreach (HtmlElement el in xChinhQui)
                {
                    if (el.InnerText != null)
                    {
                        var x1 = el.InnerText.Remove(1, el.InnerText.Length-1).Equals("C");
                        var x2 = data["Formal"].ToString().Trim().Equals("Có");
                        if (x1 == x2)
                        {
                            el.SetAttribute("selected", "selected");
                            break;
                        }
                    }
                }
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

        private void SubmitForm(WebBrowser webBrowser, String formName)
        {
            HtmlElementCollection elems = null;
            HtmlElement elem = null;

            if (webBrowser.Document != null)
            {
                HtmlDocument doc = webBrowser.Document;
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
