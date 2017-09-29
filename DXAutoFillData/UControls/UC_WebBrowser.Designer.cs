namespace DXAutoFillData.UControls
{
    partial class UC_WebBrowser
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_WebBrowser));
            this.xtraTabControlMain = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageOne = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMain)).BeginInit();
            this.xtraTabControlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraTabControlMain
            // 
            this.xtraTabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControlMain.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControlMain.Name = "xtraTabControlMain";
            this.xtraTabControlMain.PaintStyleName = "Skin";
            this.xtraTabControlMain.SelectedTabPage = this.xtraTabPageOne;
            this.xtraTabControlMain.Size = new System.Drawing.Size(715, 353);
            this.xtraTabControlMain.TabIndex = 1;
            this.xtraTabControlMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageOne});
            // 
            // xtraTabPageOne
            // 
            this.xtraTabPageOne.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPageOne.Image")));
            this.xtraTabPageOne.Name = "xtraTabPageOne";
            this.xtraTabPageOne.Size = new System.Drawing.Size(707, 322);
            this.xtraTabPageOne.Text = "Đang chuyển hướng...";
            // 
            // UC_WebBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraTabControlMain);
            this.Name = "UC_WebBrowser";
            this.Size = new System.Drawing.Size(715, 353);
            this.Load += new System.EventHandler(this.UC_WebBrowser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMain)).EndInit();
            this.xtraTabControlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTab.XtraTabControl xtraTabControlMain;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageOne;
    }
}
