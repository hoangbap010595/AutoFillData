using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
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
        public UC_WebBrowser(List<List<Dictionary<string, object>>> ls)
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
            CreateWebBrowser(xtraTabPageOne, webBrowserOne);
            CreateWebBrowserTwo();
            CreateWebBrowserThree();
            CreateWebBrowserFour();
            CreateWebBrowserFive();
            CreateWebBrowserSix();
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
        [STAThread]
        private void CreateWebBrowserTwo()
        {
            xtraTabPageTwo.Invoke((MethodInvoker)delegate
            {
                xtraTabPageTwo.Controls.Add(webBrowserTwo);
            });
            webBrowserTwo.Invoke((MethodInvoker)delegate
            {
                webBrowserTwo.Parent = xtraTabPageTwo;
                webBrowserTwo.Dock = System.Windows.Forms.DockStyle.Fill;
                webBrowserTwo.Location = new System.Drawing.Point(0, 0);
                webBrowserTwo.MinimumSize = new System.Drawing.Size(20, 20);
                webBrowserTwo.Name = "webBrowserMain";
                webBrowserTwo.Size = new System.Drawing.Size(709, 321);
                webBrowserTwo.TabIndex = 0;
                webBrowserTwo.Url = new System.Uri("", System.UriKind.Relative);
                webBrowserTwo.Visible = true;
                webBrowserTwo.ScriptErrorsSuppressed = true;
                webBrowserTwo.Navigate(UserConfig.getUTargetUrl());
                //webBrowserMain.Url = new System.Uri(UserConfig.getUTargetUrl(), System.UriKind.Relative);
                webBrowserTwo.DocumentCompleted += (sender, e) => WebBrowserTwo_DocumentCompleted(sender, e);

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
        [STAThread]
        private void CreateWebBrowserThree()
        {
            xtraTabPageThree.Invoke((MethodInvoker)delegate
            {
                xtraTabPageThree.Controls.Add(webBrowserThree);
            });
            webBrowserThree.Invoke((MethodInvoker)delegate
            {
                webBrowserThree.Parent = xtraTabPageThree;
                webBrowserThree.Dock = System.Windows.Forms.DockStyle.Fill;
                webBrowserThree.Location = new System.Drawing.Point(0, 0);
                webBrowserThree.MinimumSize = new System.Drawing.Size(20, 20);
                webBrowserThree.Name = "webBrowserMain";
                webBrowserThree.Size = new System.Drawing.Size(709, 321);
                webBrowserThree.TabIndex = 0;
                webBrowserThree.Url = new System.Uri("", System.UriKind.Relative);
                webBrowserThree.Visible = true;
                webBrowserThree.ScriptErrorsSuppressed = true;
                webBrowserThree.Navigate(UserConfig.getUTargetUrl());
                //webBrowserMain.Url = new System.Uri(UserConfig.getUTargetUrl(), System.UriKind.Relative);
                webBrowserThree.DocumentCompleted += (sender, e) => WebBrowserThree_DocumentCompleted(sender, e);

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
        [STAThread]
        private void CreateWebBrowserFour()
        {
            xtraTabPageFour.Invoke((MethodInvoker)delegate
            {
                xtraTabPageFour.Controls.Add(webBrowserFour);
            });
            webBrowserThree.Invoke((MethodInvoker)delegate
            {
                webBrowserFour.Parent = xtraTabPageFour;
                webBrowserFour.Dock = System.Windows.Forms.DockStyle.Fill;
                webBrowserFour.Location = new System.Drawing.Point(0, 0);
                webBrowserFour.MinimumSize = new System.Drawing.Size(20, 20);
                webBrowserFour.Name = "webBrowserMain";
                webBrowserFour.Size = new System.Drawing.Size(709, 321);
                webBrowserFour.TabIndex = 0;
                webBrowserFour.Url = new System.Uri("", System.UriKind.Relative);
                webBrowserFour.Visible = true;
                webBrowserFour.ScriptErrorsSuppressed = true;
                webBrowserFour.Navigate(UserConfig.getUTargetUrl());
                //webBrowserMain.Url = new System.Uri(UserConfig.getUTargetUrl(), System.UriKind.Relative);
                webBrowserFour.DocumentCompleted += (sender, e) => WebBrowserFour_DocumentCompleted(sender, e);

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
        [STAThread]
        private void CreateWebBrowserFive()
        {
            xtraTabPageFive.Invoke((MethodInvoker)delegate
            {
                xtraTabPageFive.Controls.Add(webBrowserFive);
            });
            webBrowserFive.Invoke((MethodInvoker)delegate
            {
                webBrowserFive.Parent = xtraTabPageFive;
                webBrowserFive.Dock = System.Windows.Forms.DockStyle.Fill;
                webBrowserFive.Location = new System.Drawing.Point(0, 0);
                webBrowserFive.MinimumSize = new System.Drawing.Size(20, 20);
                webBrowserFive.Name = "webBrowserMain";
                webBrowserFive.Size = new System.Drawing.Size(709, 321);
                webBrowserFive.TabIndex = 0;
                webBrowserFive.Url = new System.Uri("", System.UriKind.Relative);
                webBrowserFive.Visible = true;
                webBrowserFive.ScriptErrorsSuppressed = true;
                webBrowserFive.Navigate(UserConfig.getUTargetUrl());
                //webBrowserMain.Url = new System.Uri(UserConfig.getUTargetUrl(), System.UriKind.Relative);
                webBrowserFive.DocumentCompleted += (sender, e) => WebBrowserFive_DocumentCompleted(sender, e);

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
        [STAThread]
        private void CreateWebBrowserSix()
        {
            xtraTabPageSix.Invoke((MethodInvoker)delegate
            {
                xtraTabPageSix.Controls.Add(webBrowserSix);
            });
            webBrowserSix.Invoke((MethodInvoker)delegate
            {
                webBrowserSix.Parent = xtraTabPageSix;
                webBrowserSix.Dock = System.Windows.Forms.DockStyle.Fill;
                webBrowserSix.Location = new System.Drawing.Point(0, 0);
                webBrowserSix.MinimumSize = new System.Drawing.Size(20, 20);
                webBrowserSix.Name = "webBrowserMain";
                webBrowserSix.Size = new System.Drawing.Size(709, 321);
                webBrowserSix.TabIndex = 0;
                webBrowserSix.Url = new System.Uri("", System.UriKind.Relative);
                webBrowserSix.Visible = true;
                webBrowserSix.ScriptErrorsSuppressed = true;
                webBrowserSix.Navigate(UserConfig.getUTargetUrl());
                //webBrowserMain.Url = new System.Uri(UserConfig.getUTargetUrl(), System.UriKind.Relative);
                webBrowserSix.DocumentCompleted += (sender, e) => WebBrowserSix_DocumentCompleted(sender, e);

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
                    //webBrowser.Document.Window.ScrollTo(0, 500);

                    //Tự đông nhập dữ liệu
                    if (UserConfig.getSAutoEnterData())
                    {
                        if (webBrowser.ReadyState == WebBrowserReadyState.Interactive)
                        {
                            if (indexOne < _lsDataOne.Count)
                                fillData(webBrowser, xtraTabPageOne, _lsDataOne[indexOne]);
                            else
                                return;
                            if (isSubmit)
                            {
                                indexOne++;
                                isSubmit = false;
                                isClick = false;
                                sendCount(count);
                                webBrowser.Navigate(UserConfig.getUTargetUrl());
                                Console.WriteLine("[One]ID: " + _lsDataOne[indexOne]["No"].ToString());
                            }
                            Console.WriteLine("[One]indexOne: " + indexOne);
                            Console.WriteLine("[One]WebBrowserOne.Interactive");
                        }
                        webBrowser.Document.Body.MouseDown += (sender2, e2) => Body_MouseDown(webBrowser, sender2, e2);
                    }
                }
                else
                    webBrowser.Navigate(UserConfig.getUTargetUrl());
            }
            catch (Exception ex)
            {
                Console.WriteLine("[WebBrowserOne_DocumentCompleted]: " + ex.Message);
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

        //Tab2
        private void WebBrowserTwo_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            try
            {
                xtraTabPageTwo.Text = webBrowserTwo.DocumentTitle;
                //Tự động đăng nhập
                if (UserConfig.getUAutoLogin())
                {
                    if (webBrowserTwo.Document.GetElementById("pwbox-697") != null)
                    {
                        webBrowserTwo.Document.GetElementById("pwbox-697").InnerText = UserConfig.getUPassword();
                        HtmlElementCollection links = webBrowserTwo.Document.GetElementsByTagName("input");

                        foreach (HtmlElement link in links)
                        {
                            if (link != null && link.Name == "Submit")
                            {
                                link.InvokeMember("Click");
                            }
                        }
                    }
                }
                if (webBrowserTwo.Url.AbsoluteUri.Equals(UserConfig.getUTargetUrl()))
                {
                    //webBrowser.Document.Window.ScrollTo(0, 500);

                    //Tự đông nhập dữ liệu
                    if (UserConfig.getSAutoEnterData())
                    {
                        
                        if (webBrowserTwo.ReadyState == WebBrowserReadyState.Interactive)
                        {
                            if (indexTwo < _lsDataTwo.Count)
                                fillDataAll(webBrowserTwo, _lsDataTwo[indexTwo]);
                            else
                                return;
                            if (isSubmit)
                            {
                                indexTwo++;
                                isSubmit = false;
                                isClick = false;
                                sendCount(count);
                                webBrowserTwo.Navigate(UserConfig.getUTargetUrl());
                                Console.WriteLine("[Two]ID: " + _lsDataTwo[indexTwo]["No"].ToString());   
                            }
                            Console.WriteLine("[Two]IndexTwo: " + indexTwo);
                            Console.WriteLine("[Two]WebBrowserReadyState.Interactive");
                        }
                        webBrowserTwo.Document.Body.MouseDown += (sender2, e2) => BodyTwo_MouseDown(sender2, e2);
                    }
                }
                else
                    webBrowserTwo.Navigate(UserConfig.getUTargetUrl());
            }
            catch (Exception ex)
            {
                Console.WriteLine("[WebBrowserTwo_DocumentCompleted]: " + ex.Message);
                //XtraMessageBox.Show(ex.Message + "\nVui lòng liên hệ IT hỗ trợ.", "Xảy ra lỗi");
            }

        }
        private void BodyTwo_MouseDown(object sender, HtmlElementEventArgs e)
        {
            switch (e.MouseButtonsPressed)
            {
                case MouseButtons.Left:
                    HtmlElement element = webBrowserTwo.Document.GetElementFromPoint(e.ClientMousePosition);
                    if (element != null && "submit".Equals(element.GetAttribute("type"), StringComparison.OrdinalIgnoreCase))
                    {
                        isClick = true;
                        isSubmit = true;
                        count++;
                        indexTwo++;
                        break;
                    }
                    break;
            }

        }

        //Tab3
        private void WebBrowserThree_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            try
            {
                xtraTabPageThree.Text = webBrowserThree.DocumentTitle;
                //Tự động đăng nhập
                if (UserConfig.getUAutoLogin())
                {
                    if (webBrowserThree.Document.GetElementById("pwbox-697") != null)
                    {
                        webBrowserThree.Document.GetElementById("pwbox-697").InnerText = UserConfig.getUPassword();
                        HtmlElementCollection links = webBrowserThree.Document.GetElementsByTagName("input");

                        foreach (HtmlElement link in links)
                        {
                            if (link != null && link.Name == "Submit")
                            {
                                link.InvokeMember("Click");
                            }
                        }
                    }
                }
                if (webBrowserThree.Url.AbsoluteUri.Equals(UserConfig.getUTargetUrl()))
                {
                    //webBrowser.Document.Window.ScrollTo(0, 500);

                    //Tự đông nhập dữ liệu
                    if (UserConfig.getSAutoEnterData())
                    {
                       
                        if (webBrowserThree.ReadyState == WebBrowserReadyState.Interactive)
                        {
                            if (indexThree < _lsDataThree.Count)
                                fillDataAll(webBrowserThree, _lsDataThree[indexThree]);
                            else
                                return;
                            if (isSubmit)
                            {
                                indexThree++;
                                isSubmit = false;
                                isClick = false;
                                sendCount(count);
                                webBrowserThree.Navigate(UserConfig.getUTargetUrl());
                                Console.WriteLine("[Three]ID: " + _lsDataThree[indexThree]["No"].ToString());
                            }
                            Console.WriteLine("[Three]indexThree: " + indexThree);
                            Console.WriteLine("[Three]WebBrowserReadyState.Interactive");
                        }
                        webBrowserThree.Document.Body.MouseDown += (sender2, e2) => BodyThree_MouseDown(sender2, e2);
                    }
                }
                else
                    webBrowserThree.Navigate(UserConfig.getUTargetUrl());
            }
            catch (Exception ex)
            {
                Console.WriteLine("[WebBrowserThree_DocumentCompleted]: " + ex.Message);
                //XtraMessageBox.Show(ex.Message + "\nVui lòng liên hệ IT hỗ trợ.", "Xảy ra lỗi");
            }

        }
        private void BodyThree_MouseDown(object sender, HtmlElementEventArgs e)
        {
            switch (e.MouseButtonsPressed)
            {
                case MouseButtons.Left:
                    HtmlElement element = webBrowserThree.Document.GetElementFromPoint(e.ClientMousePosition);
                    if (element != null && "submit".Equals(element.GetAttribute("type"), StringComparison.OrdinalIgnoreCase))
                    {
                        isClick = true;
                        isSubmit = true;
                        count++;
                        indexThree++;
                        break;
                    }
                    break;
            }

        }

        //Tab4
        private void WebBrowserFour_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            try
            {
                xtraTabPageFour.Text = webBrowserFour.DocumentTitle;
                //Tự động đăng nhập
                if (UserConfig.getUAutoLogin())
                {
                    if (webBrowserFour.Document.GetElementById("pwbox-697") != null)
                    {
                        webBrowserFour.Document.GetElementById("pwbox-697").InnerText = UserConfig.getUPassword();
                        HtmlElementCollection links = webBrowserFour.Document.GetElementsByTagName("input");

                        foreach (HtmlElement link in links)
                        {
                            if (link != null && link.Name == "Submit")
                            {
                                link.InvokeMember("Click");
                            }
                        }
                    }
                }
                if (webBrowserFour.Url.AbsoluteUri.Equals(UserConfig.getUTargetUrl()))
                {
                    //webBrowser.Document.Window.ScrollTo(0, 500);

                    //Tự đông nhập dữ liệu
                    if (UserConfig.getSAutoEnterData())
                    {
                        
                        if (webBrowserFour.ReadyState == WebBrowserReadyState.Interactive)
                        {
                            if (indexFour < _lsDataFour.Count)
                                fillDataAll(webBrowserFour, _lsDataFour[indexFour]);
                            else
                                return;
                            if (isSubmit)
                            {
                                indexFour++;
                                isSubmit = false;
                                isClick = false;
                                sendCount(count);
                                webBrowserFour.Navigate(UserConfig.getUTargetUrl());
                                Console.WriteLine("[Four]ID: " + _lsDataFour[indexFour]["No"].ToString());
                            }
                            Console.WriteLine("[Four]indexFour: " + indexFour);
                            Console.WriteLine("[Four]WebBrowserReadyState.Interactive");
                        }
                        webBrowserFour.Document.Body.MouseDown += (sender2, e2) => BodyFour_MouseDown(sender2, e2);
                    }
                }
                else
                    webBrowserFour.Navigate(UserConfig.getUTargetUrl());
            }
            catch (Exception ex)
            {
                Console.WriteLine("[WebBrowserFour_DocumentCompleted]: " + ex.Message);
                //XtraMessageBox.Show(ex.Message + "\nVui lòng liên hệ IT hỗ trợ.", "Xảy ra lỗi");
            }

        }
        private void BodyFour_MouseDown(object sender, HtmlElementEventArgs e)
        {
            switch (e.MouseButtonsPressed)
            {
                case MouseButtons.Left:
                    HtmlElement element = webBrowserFour.Document.GetElementFromPoint(e.ClientMousePosition);
                    if (element != null && "submit".Equals(element.GetAttribute("type"), StringComparison.OrdinalIgnoreCase))
                    {
                        isClick = true;
                        isSubmit = true;
                        count++;
                        indexFour++;
                        break;
                    }
                    break;
            }

        }
        //Tab5
        private void WebBrowserFive_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            try
            {
                xtraTabPageFive.Text = webBrowserFive.DocumentTitle;
                //Tự động đăng nhập
                if (UserConfig.getUAutoLogin())
                {
                    if (webBrowserFive.Document.GetElementById("pwbox-697") != null)
                    {
                        webBrowserFive.Document.GetElementById("pwbox-697").InnerText = UserConfig.getUPassword();
                        HtmlElementCollection links = webBrowserFive.Document.GetElementsByTagName("input");

                        foreach (HtmlElement link in links)
                        {
                            if (link != null && link.Name == "Submit")
                            {
                                link.InvokeMember("Click");
                            }
                        }
                    }
                }
                if (webBrowserFive.Url.AbsoluteUri.Equals(UserConfig.getUTargetUrl()))
                {
                    //webBrowser.Document.Window.ScrollTo(0, 500);

                    //Tự đông nhập dữ liệu
                    if (UserConfig.getSAutoEnterData())
                    {
                       
                        if (webBrowserFive.ReadyState == WebBrowserReadyState.Interactive)
                        {
                            if (indexFive < _lsDataFive.Count)
                                fillDataAll(webBrowserFive, _lsDataFive[indexFive]);
                            else
                                return;
                            if (isSubmit)
                            {
                                indexFive++;
                                isSubmit = false;
                                isClick = false;
                                sendCount(count);
                                webBrowserFive.Navigate(UserConfig.getUTargetUrl());
                                Console.WriteLine("[Five]ID: " + _lsDataFive[indexFive]["No"].ToString());
                            }
                            Console.WriteLine("[Five]indexFive: " + indexFive);
                            Console.WriteLine("[Five]WebBrowserReadyState.Interactive");
                        }
                        webBrowserFive.Document.Body.MouseDown += (sender2, e2) => BodyFive_MouseDown(sender2, e2);
                    }
                }
                else
                    webBrowserFive.Navigate(UserConfig.getUTargetUrl());
            }
            catch (Exception ex)
            {
                Console.WriteLine("[WebBrowserFive_DocumentCompleted]: " + ex.Message);
                //XtraMessageBox.Show(ex.Message + "\nVui lòng liên hệ IT hỗ trợ.", "Xảy ra lỗi");
            }

        }
        private void BodyFive_MouseDown(object sender, HtmlElementEventArgs e)
        {
            switch (e.MouseButtonsPressed)
            {
                case MouseButtons.Left:
                    HtmlElement element = webBrowserFive.Document.GetElementFromPoint(e.ClientMousePosition);
                    if (element != null && "submit".Equals(element.GetAttribute("type"), StringComparison.OrdinalIgnoreCase))
                    {
                        isClick = true;
                        isSubmit = true;
                        count++;
                        indexFive++;
                        break;
                    }
                    break;
            }

        }

        //Tab6
        private void WebBrowserSix_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            try
            {
                xtraTabPageSix.Text = webBrowserSix.DocumentTitle;
                //Tự động đăng nhập
                if (UserConfig.getUAutoLogin())
                {
                    if (webBrowserSix.Document.GetElementById("pwbox-697") != null)
                    {
                        webBrowserSix.Document.GetElementById("pwbox-697").InnerText = UserConfig.getUPassword();
                        HtmlElementCollection links = webBrowserSix.Document.GetElementsByTagName("input");

                        foreach (HtmlElement link in links)
                        {
                            if (link != null && link.Name == "Submit")
                            {
                                link.InvokeMember("Click");
                            }
                        }
                    }
                }
                if (webBrowserSix.Url.AbsoluteUri.Equals(UserConfig.getUTargetUrl()))
                {
                    //webBrowser.Document.Window.ScrollTo(0, 500);

                    //Tự đông nhập dữ liệu
                    if (UserConfig.getSAutoEnterData())
                    {
                       
                        if (webBrowserSix.ReadyState == WebBrowserReadyState.Interactive)
                        {
                            if (indexSix < _lsDataSix.Count)
                                fillDataAll(webBrowserSix, _lsDataSix[indexSix]);
                            else
                                return;
                            if (isSubmit)
                            {
                                indexSix++;
                                isSubmit = false;
                                isClick = false;
                                sendCount(count);
                                webBrowserSix.Navigate(UserConfig.getUTargetUrl());
                                Console.WriteLine("[Six]ID: " + _lsDataSix[indexSix]["No"].ToString());
                            }
                            Console.WriteLine("[Six]indexSix: " + indexSix);
                            Console.WriteLine("[Six]WebBrowserReadyState.Interactive");
                        }
                        webBrowserSix.Document.Body.MouseDown += (sender2, e2) => BodySix_MouseDown(sender2, e2);
                    }
                }
                else
                    webBrowserSix.Navigate(UserConfig.getUTargetUrl());
            }
            catch (Exception ex)
            {
                Console.WriteLine("[WebBrowserSix_DocumentCompleted]: " + ex.Message);
                //XtraMessageBox.Show(ex.Message + "\nVui lòng liên hệ IT hỗ trợ.", "Xảy ra lỗi");
            }

        }
        private void BodySix_MouseDown(object sender, HtmlElementEventArgs e)
        {
            switch (e.MouseButtonsPressed)
            {
                case MouseButtons.Left:
                    HtmlElement element = webBrowserSix.Document.GetElementFromPoint(e.ClientMousePosition);
                    if (element != null && "submit".Equals(element.GetAttribute("type"), StringComparison.OrdinalIgnoreCase))
                    {
                        isClick = true;
                        isSubmit = true;
                        count++;
                        indexFour++;
                        break;
                    }
                    break;
            }

        }
        #endregion

        #region ===Fill Data====
        private void fillData(WebBrowser webBrowser, XtraTabPage tabPage, Dictionary<string, object> data)
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

                bool check = data["Status"].ToString().Trim() == "CTN" ? true : false;
                if (check)
                    webBrowser.Document.GetElementById("txtChuaTotNghiep").SetAttribute("checked", "1");
                else
                    webBrowser.Document.GetElementById("txtDaTotNghiep").SetAttribute("checked", "1");
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
                        var x1 = el.InnerText.Remove(1, el.InnerText.Length - 1).Equals("C");
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

        private void fillDataAll(WebBrowser webBrowser, Dictionary<string, object> data)
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

                bool check = data["Status"].ToString().Trim() == "CTN" ? true : false;
                if (check)
                    webBrowser.Document.GetElementById("txtChuaTotNghiep").SetAttribute("checked", "1");
                else
                    webBrowser.Document.GetElementById("txtDaTotNghiep").SetAttribute("checked", "1");
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
                        var x1 = el.InnerText.Remove(1, el.InnerText.Length - 1).Equals("C");
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
                                count++;
                                Console.WriteLine("[Submit] Clicked NAME : " + webBrowser.Document.GetElementById("txtFullName").InnerText);
                                Console.WriteLine("[Submit] Clicked : " + count);
                                item.InvokeMember("Click");
                                break;
                            }   
                        }
                    }
            }
            #endregion
        }

        private void fillDataTwo(WebBrowser webBrowser,  Dictionary<string, object> data)
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

                bool check = data["Status"].ToString().Trim() == "CTN" ? true : false;
                if (check)
                    webBrowser.Document.GetElementById("txtChuaTotNghiep").SetAttribute("checked", "1");
                else
                    webBrowser.Document.GetElementById("txtDaTotNghiep").SetAttribute("checked", "1");
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
                        var x1 = el.InnerText.Remove(1, el.InnerText.Length - 1).Equals("C");
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
                                count++;
                              
                                item.InvokeMember("Click");  
                                break;
                            }
                            //Console.WriteLine(item.InnerText);
                        }
                    }
            }
            #endregion
        }
        private void fillDataThree(WebBrowser webBrowser,Dictionary<string, object> data)
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

                bool check = data["Status"].ToString().Trim() == "CTN" ? true : false;
                if (check)
                    webBrowser.Document.GetElementById("txtChuaTotNghiep").SetAttribute("checked", "1");
                else
                    webBrowser.Document.GetElementById("txtDaTotNghiep").SetAttribute("checked", "1");
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
                        var x1 = el.InnerText.Remove(1, el.InnerText.Length - 1).Equals("C");
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
                                count++;
                                item.InvokeMember("Click");
                                break;
                            }
                            //Console.WriteLine(item.InnerText);
                        }
                    }
            }
            #endregion
        }
        private void fillDataFour(WebBrowser webBrowser,Dictionary<string, object> data)
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

                bool check = data["Status"].ToString().Trim() == "CTN" ? true : false;
                if (check)
                    webBrowser.Document.GetElementById("txtChuaTotNghiep").SetAttribute("checked", "1");
                else
                    webBrowser.Document.GetElementById("txtDaTotNghiep").SetAttribute("checked", "1");
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
                        var x1 = el.InnerText.Remove(1, el.InnerText.Length - 1).Equals("C");
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
                                count++;      
                                item.InvokeMember("Click");  
                                break;
                            }
                            //Console.WriteLine(item.InnerText);
                        }
                    }
            }
            #endregion
        }
        private void fillDataFive(WebBrowser webBrowser, Dictionary<string, object> data)
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

                bool check = data["Status"].ToString().Trim() == "CTN" ? true : false;
                if (check)
                    webBrowser.Document.GetElementById("txtChuaTotNghiep").SetAttribute("checked", "1");
                else
                    webBrowser.Document.GetElementById("txtDaTotNghiep").SetAttribute("checked", "1");
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
                        var x1 = el.InnerText.Remove(1, el.InnerText.Length - 1).Equals("C");
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
                                count++;
                                item.InvokeMember("Click");      
                                break;
                            }
                            //Console.WriteLine(item.InnerText);
                        }
                    }
            }
            #endregion
        }
        private void fillDataSix(WebBrowser webBrowser, Dictionary<string, object> data)
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

                bool check = data["Status"].ToString().Trim() == "CTN" ? true : false;
                if (check)
                    webBrowser.Document.GetElementById("txtChuaTotNghiep").SetAttribute("checked", "1");
                else
                    webBrowser.Document.GetElementById("txtDaTotNghiep").SetAttribute("checked", "1");
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
                        var x1 = el.InnerText.Remove(1, el.InnerText.Length - 1).Equals("C");
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
                                count++;
                                item.InvokeMember("Click"); 
                                break;
                            }
                            //Console.WriteLine(item.InnerText);
                        }
                    }
            }
            #endregion
        }
        #endregion

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
