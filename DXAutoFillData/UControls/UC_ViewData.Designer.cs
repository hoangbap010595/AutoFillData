namespace DXAutoFillData.UControls
{
    partial class UC_ViewData
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
            this.gridControlData = new DevExpress.XtraGrid.GridControl();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDateOfBirth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnGender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnMarriage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnStreet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnWard = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDistrict = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnProvince = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCurrentAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPassport = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnIssuedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDateRange = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDateExpired = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnLanguges = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUniversity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnFromYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnToYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnFormal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnNumOfDip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnGradYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnFullNameRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPhoneRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnAddressRef = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlData
            // 
            this.gridControlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlData.Location = new System.Drawing.Point(0, 0);
            this.gridControlData.MainView = this.gridViewData;
            this.gridControlData.Name = "gridControlData";
            this.gridControlData.Size = new System.Drawing.Size(831, 408);
            this.gridControlData.TabIndex = 0;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // gridViewData
            // 
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnNo,
            this.gridColumnFullName,
            this.gridColumnDateOfBirth,
            this.gridColumnGender,
            this.gridColumnMarriage,
            this.gridColumnStreet,
            this.gridColumnWard,
            this.gridColumnDistrict,
            this.gridColumnProvince,
            this.gridColumnCurrentAddress,
            this.gridColumnPassport,
            this.gridColumnIssuedBy,
            this.gridColumnDateRange,
            this.gridColumnDateExpired,
            this.gridColumnEmail,
            this.gridColumnPhone,
            this.gridColumnLanguges,
            this.gridColumnStatus,
            this.gridColumnUniversity,
            this.gridColumnFromYear,
            this.gridColumnToYear,
            this.gridColumnFormal,
            this.gridColumnNumOfDip,
            this.gridColumnGradYear,
            this.gridColumnFullNameRef,
            this.gridColumnPhoneRef,
            this.gridColumnAddressRef});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            this.gridViewData.OptionsView.ColumnAutoWidth = false;
            this.gridViewData.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnNo
            // 
            this.gridColumnNo.Caption = "STT";
            this.gridColumnNo.FieldName = "No";
            this.gridColumnNo.MaxWidth = 40;
            this.gridColumnNo.MinWidth = 40;
            this.gridColumnNo.Name = "gridColumnNo";
            this.gridColumnNo.Visible = true;
            this.gridColumnNo.VisibleIndex = 0;
            this.gridColumnNo.Width = 40;
            // 
            // gridColumnFullName
            // 
            this.gridColumnFullName.Caption = "Họ và tên";
            this.gridColumnFullName.FieldName = "FullName";
            this.gridColumnFullName.MinWidth = 90;
            this.gridColumnFullName.Name = "gridColumnFullName";
            this.gridColumnFullName.Visible = true;
            this.gridColumnFullName.VisibleIndex = 1;
            this.gridColumnFullName.Width = 90;
            // 
            // gridColumnDateOfBirth
            // 
            this.gridColumnDateOfBirth.Caption = "Ngày sinh";
            this.gridColumnDateOfBirth.FieldName = "DateOfBirth";
            this.gridColumnDateOfBirth.Name = "gridColumnDateOfBirth";
            this.gridColumnDateOfBirth.Visible = true;
            this.gridColumnDateOfBirth.VisibleIndex = 2;
            // 
            // gridColumnGender
            // 
            this.gridColumnGender.Caption = "Giới tính";
            this.gridColumnGender.FieldName = "Gender";
            this.gridColumnGender.MaxWidth = 50;
            this.gridColumnGender.MinWidth = 50;
            this.gridColumnGender.Name = "gridColumnGender";
            this.gridColumnGender.Visible = true;
            this.gridColumnGender.VisibleIndex = 3;
            this.gridColumnGender.Width = 50;
            // 
            // gridColumnMarriage
            // 
            this.gridColumnMarriage.Caption = "Hôn nhân";
            this.gridColumnMarriage.FieldName = "Marriage";
            this.gridColumnMarriage.MinWidth = 80;
            this.gridColumnMarriage.Name = "gridColumnMarriage";
            this.gridColumnMarriage.Visible = true;
            this.gridColumnMarriage.VisibleIndex = 4;
            this.gridColumnMarriage.Width = 80;
            // 
            // gridColumnStreet
            // 
            this.gridColumnStreet.Caption = "Số nhà/Đường";
            this.gridColumnStreet.FieldName = "Street";
            this.gridColumnStreet.MinWidth = 100;
            this.gridColumnStreet.Name = "gridColumnStreet";
            this.gridColumnStreet.Visible = true;
            this.gridColumnStreet.VisibleIndex = 5;
            this.gridColumnStreet.Width = 100;
            // 
            // gridColumnWard
            // 
            this.gridColumnWard.Caption = "Xã/Phường";
            this.gridColumnWard.FieldName = "Ward";
            this.gridColumnWard.MinWidth = 60;
            this.gridColumnWard.Name = "gridColumnWard";
            this.gridColumnWard.Visible = true;
            this.gridColumnWard.VisibleIndex = 6;
            // 
            // gridColumnDistrict
            // 
            this.gridColumnDistrict.Caption = "Quận";
            this.gridColumnDistrict.FieldName = "District";
            this.gridColumnDistrict.Name = "gridColumnDistrict";
            this.gridColumnDistrict.Visible = true;
            this.gridColumnDistrict.VisibleIndex = 7;
            // 
            // gridColumnProvince
            // 
            this.gridColumnProvince.Caption = "Tỉnh";
            this.gridColumnProvince.FieldName = "Province";
            this.gridColumnProvince.Name = "gridColumnProvince";
            this.gridColumnProvince.Visible = true;
            this.gridColumnProvince.VisibleIndex = 8;
            // 
            // gridColumnCurrentAddress
            // 
            this.gridColumnCurrentAddress.Caption = "Địa chỉ hiện tại";
            this.gridColumnCurrentAddress.FieldName = "CurrentAddress";
            this.gridColumnCurrentAddress.MinWidth = 110;
            this.gridColumnCurrentAddress.Name = "gridColumnCurrentAddress";
            this.gridColumnCurrentAddress.Visible = true;
            this.gridColumnCurrentAddress.VisibleIndex = 9;
            this.gridColumnCurrentAddress.Width = 110;
            // 
            // gridColumnPassport
            // 
            this.gridColumnPassport.Caption = "Hộ chiếu/CMND";
            this.gridColumnPassport.FieldName = "Passport";
            this.gridColumnPassport.MinWidth = 100;
            this.gridColumnPassport.Name = "gridColumnPassport";
            this.gridColumnPassport.Visible = true;
            this.gridColumnPassport.VisibleIndex = 10;
            this.gridColumnPassport.Width = 100;
            // 
            // gridColumnIssuedBy
            // 
            this.gridColumnIssuedBy.Caption = "Nơi cấp";
            this.gridColumnIssuedBy.FieldName = "IssuedBy";
            this.gridColumnIssuedBy.MinWidth = 100;
            this.gridColumnIssuedBy.Name = "gridColumnIssuedBy";
            this.gridColumnIssuedBy.Visible = true;
            this.gridColumnIssuedBy.VisibleIndex = 11;
            this.gridColumnIssuedBy.Width = 100;
            // 
            // gridColumnDateRange
            // 
            this.gridColumnDateRange.Caption = "Ngày cấp";
            this.gridColumnDateRange.FieldName = "DateRange";
            this.gridColumnDateRange.Name = "gridColumnDateRange";
            this.gridColumnDateRange.Visible = true;
            this.gridColumnDateRange.VisibleIndex = 12;
            // 
            // gridColumnDateExpired
            // 
            this.gridColumnDateExpired.Caption = "Hết hạn";
            this.gridColumnDateExpired.FieldName = "DateExpired";
            this.gridColumnDateExpired.MinWidth = 100;
            this.gridColumnDateExpired.Name = "gridColumnDateExpired";
            this.gridColumnDateExpired.Visible = true;
            this.gridColumnDateExpired.VisibleIndex = 13;
            this.gridColumnDateExpired.Width = 100;
            // 
            // gridColumnEmail
            // 
            this.gridColumnEmail.Caption = "Email";
            this.gridColumnEmail.FieldName = "Email";
            this.gridColumnEmail.MinWidth = 100;
            this.gridColumnEmail.Name = "gridColumnEmail";
            this.gridColumnEmail.Visible = true;
            this.gridColumnEmail.VisibleIndex = 14;
            this.gridColumnEmail.Width = 100;
            // 
            // gridColumnPhone
            // 
            this.gridColumnPhone.Caption = "Điện thoại";
            this.gridColumnPhone.FieldName = "Phone";
            this.gridColumnPhone.MinWidth = 100;
            this.gridColumnPhone.Name = "gridColumnPhone";
            this.gridColumnPhone.Visible = true;
            this.gridColumnPhone.VisibleIndex = 15;
            this.gridColumnPhone.Width = 100;
            // 
            // gridColumnLanguges
            // 
            this.gridColumnLanguges.Caption = "Ngoại ngữ";
            this.gridColumnLanguges.FieldName = "Languges";
            this.gridColumnLanguges.MinWidth = 100;
            this.gridColumnLanguges.Name = "gridColumnLanguges";
            this.gridColumnLanguges.Visible = true;
            this.gridColumnLanguges.VisibleIndex = 16;
            this.gridColumnLanguges.Width = 100;
            // 
            // gridColumnStatus
            // 
            this.gridColumnStatus.Caption = "Tình trạng tốt nghiệp";
            this.gridColumnStatus.FieldName = "Status";
            this.gridColumnStatus.MinWidth = 120;
            this.gridColumnStatus.Name = "gridColumnStatus";
            this.gridColumnStatus.Visible = true;
            this.gridColumnStatus.VisibleIndex = 17;
            this.gridColumnStatus.Width = 120;
            // 
            // gridColumnUniversity
            // 
            this.gridColumnUniversity.Caption = "Trường đại học";
            this.gridColumnUniversity.FieldName = "University";
            this.gridColumnUniversity.MinWidth = 100;
            this.gridColumnUniversity.Name = "gridColumnUniversity";
            this.gridColumnUniversity.Visible = true;
            this.gridColumnUniversity.VisibleIndex = 18;
            this.gridColumnUniversity.Width = 100;
            // 
            // gridColumnFromYear
            // 
            this.gridColumnFromYear.Caption = "Từ năm";
            this.gridColumnFromYear.FieldName = "FromYear";
            this.gridColumnFromYear.MinWidth = 60;
            this.gridColumnFromYear.Name = "gridColumnFromYear";
            this.gridColumnFromYear.Visible = true;
            this.gridColumnFromYear.VisibleIndex = 19;
            // 
            // gridColumnToYear
            // 
            this.gridColumnToYear.Caption = "Đến năm";
            this.gridColumnToYear.FieldName = "ToYear";
            this.gridColumnToYear.MinWidth = 60;
            this.gridColumnToYear.Name = "gridColumnToYear";
            this.gridColumnToYear.Visible = true;
            this.gridColumnToYear.VisibleIndex = 20;
            this.gridColumnToYear.Width = 60;
            // 
            // gridColumnFormal
            // 
            this.gridColumnFormal.Caption = "Chính qui";
            this.gridColumnFormal.FieldName = "Formal";
            this.gridColumnFormal.MinWidth = 80;
            this.gridColumnFormal.Name = "gridColumnFormal";
            this.gridColumnFormal.Visible = true;
            this.gridColumnFormal.VisibleIndex = 21;
            this.gridColumnFormal.Width = 80;
            // 
            // gridColumnNumOfDip
            // 
            this.gridColumnNumOfDip.Caption = "Số văn bằng";
            this.gridColumnNumOfDip.FieldName = "NumOfDip";
            this.gridColumnNumOfDip.MinWidth = 100;
            this.gridColumnNumOfDip.Name = "gridColumnNumOfDip";
            this.gridColumnNumOfDip.Visible = true;
            this.gridColumnNumOfDip.VisibleIndex = 22;
            this.gridColumnNumOfDip.Width = 100;
            // 
            // gridColumnGradYear
            // 
            this.gridColumnGradYear.Caption = "Năm tốt nghiệp";
            this.gridColumnGradYear.FieldName = "GradYear";
            this.gridColumnGradYear.MinWidth = 80;
            this.gridColumnGradYear.Name = "gridColumnGradYear";
            this.gridColumnGradYear.Visible = true;
            this.gridColumnGradYear.VisibleIndex = 23;
            this.gridColumnGradYear.Width = 100;
            // 
            // gridColumnFullNameRef
            // 
            this.gridColumnFullNameRef.Caption = "Họ tên người liên hệ";
            this.gridColumnFullNameRef.FieldName = "FullNameRef";
            this.gridColumnFullNameRef.MinWidth = 120;
            this.gridColumnFullNameRef.Name = "gridColumnFullNameRef";
            this.gridColumnFullNameRef.Visible = true;
            this.gridColumnFullNameRef.VisibleIndex = 24;
            this.gridColumnFullNameRef.Width = 120;
            // 
            // gridColumnPhoneRef
            // 
            this.gridColumnPhoneRef.Caption = "Số điện thoại";
            this.gridColumnPhoneRef.FieldName = "PhoneRef";
            this.gridColumnPhoneRef.MinWidth = 100;
            this.gridColumnPhoneRef.Name = "gridColumnPhoneRef";
            this.gridColumnPhoneRef.Visible = true;
            this.gridColumnPhoneRef.VisibleIndex = 25;
            this.gridColumnPhoneRef.Width = 100;
            // 
            // gridColumnAddressRef
            // 
            this.gridColumnAddressRef.Caption = "Địa chỉ";
            this.gridColumnAddressRef.FieldName = "AddressRef";
            this.gridColumnAddressRef.MinWidth = 120;
            this.gridColumnAddressRef.Name = "gridColumnAddressRef";
            this.gridColumnAddressRef.Visible = true;
            this.gridColumnAddressRef.VisibleIndex = 26;
            this.gridColumnAddressRef.Width = 120;
            // 
            // UC_ViewData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlData);
            this.Name = "UC_ViewData";
            this.Size = new System.Drawing.Size(831, 408);
            this.Load += new System.EventHandler(this.UC_ViewData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnFullName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDateOfBirth;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnGender;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnMarriage;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnStreet;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnWard;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDistrict;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnProvince;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCurrentAddress;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPassport;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnIssuedBy;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDateRange;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDateExpired;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnEmail;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPhone;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnLanguges;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnStatus;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUniversity;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnFromYear;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnToYear;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnFormal;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNumOfDip;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnGradYear;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnFullNameRef;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPhoneRef;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnAddressRef;
    }
}
