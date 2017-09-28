namespace DXAutoFillData
{
    partial class frmActive
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnActive = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtKey = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtKey.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActive
            // 
            this.btnActive.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnActive.Appearance.Options.UseFont = true;
            this.btnActive.Location = new System.Drawing.Point(92, 88);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(157, 43);
            this.btnActive.TabIndex = 0;
            this.btnActive.Text = "Kích hoạt";
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(16, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(133, 19);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Nhập mã kích hoạt";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(16, 42);
            this.txtKey.Name = "txtKey";
            this.txtKey.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtKey.Properties.Appearance.Options.UseFont = true;
            this.txtKey.Size = new System.Drawing.Size(308, 26);
            this.txtKey.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.DarkRed;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(12, 146);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(317, 42);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Phần mềm đang bị khóa do chưa được kích hoạt \r\nbản quyền";
            // 
            // frmActive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 191);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnActive);
            this.MaximumSize = new System.Drawing.Size(357, 230);
            this.MinimumSize = new System.Drawing.Size(357, 230);
            this.Name = "frmActive";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kích hoạt phần mềm";
            ((System.ComponentModel.ISupportInitialize)(this.txtKey.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnActive;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtKey;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}