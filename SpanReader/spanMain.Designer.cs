namespace SpanReader
{
    partial class spanMain
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
            this.components = new System.ComponentModel.Container();
            this.MainContainer = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.elmFileLoad = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.elmType1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.elmType2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.elmType5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.elmType8 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.elmTypeB = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.elmTypeC = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.elmTypeE = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.elmTypeP = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.elmTypeR = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.elmTypeS = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.elmTypeZ = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement7 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.elmCCM = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.elmMrktInfo = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.elmSeriesToSeries = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.xtraOpenFileDialog1 = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            this.elmType3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainContainer
            // 
            this.MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContainer.Location = new System.Drawing.Point(260, 39);
            this.MainContainer.Name = "MainContainer";
            this.MainContainer.Size = new System.Drawing.Size(1050, 900);
            this.MainContainer.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1,
            this.accordionControlElement4,
            this.accordionControlElement2,
            this.accordionControlElement5});
            this.accordionControl1.Location = new System.Drawing.Point(0, 39);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(260, 900);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "FTP";
            // 
            // accordionControlElement4
            // 
            this.accordionControlElement4.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.elmFileLoad});
            this.accordionControlElement4.Expanded = true;
            this.accordionControlElement4.Name = "accordionControlElement4";
            this.accordionControlElement4.Text = "파일관리";
            // 
            // elmFileLoad
            // 
            this.elmFileLoad.Name = "elmFileLoad";
            this.elmFileLoad.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.elmFileLoad.Text = "Span File Load";
            this.elmFileLoad.Click += new System.EventHandler(this.elmFileLoad_Click);
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.elmType1,
            this.elmType3,
            this.elmType2,
            this.elmType5,
            this.elmType8,
            this.elmTypeB,
            this.elmTypeC,
            this.elmTypeE,
            this.elmTypeP,
            this.elmTypeR,
            this.elmTypeS,
            this.elmTypeZ});
            this.accordionControlElement2.Expanded = true;
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Text = "SPAN FILE";
            // 
            // elmType1
            // 
            this.elmType1.Name = "elmType1";
            this.elmType1.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.elmType1.Text = "file type1";
            this.elmType1.Click += new System.EventHandler(this.accordionControlElement3_Click);
            // 
            // elmType2
            // 
            this.elmType2.Name = "elmType2";
            this.elmType2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.elmType2.Text = "file type2";
            this.elmType2.Click += new System.EventHandler(this.elmType2_Click);
            // 
            // elmType5
            // 
            this.elmType5.Name = "elmType5";
            this.elmType5.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.elmType5.Text = "file type5";
            this.elmType5.Click += new System.EventHandler(this.elmType5_Click);
            // 
            // elmType8
            // 
            this.elmType8.Name = "elmType8";
            this.elmType8.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.elmType8.Text = "file type8";
            this.elmType8.Click += new System.EventHandler(this.elmType8_Click);
            // 
            // elmTypeB
            // 
            this.elmTypeB.Name = "elmTypeB";
            this.elmTypeB.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.elmTypeB.Text = "file TypeB";
            this.elmTypeB.Click += new System.EventHandler(this.elmTypeB_Click);
            // 
            // elmTypeC
            // 
            this.elmTypeC.Name = "elmTypeC";
            this.elmTypeC.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.elmTypeC.Text = "file typeC";
            this.elmTypeC.Click += new System.EventHandler(this.elmTypeC_Click);
            // 
            // elmTypeE
            // 
            this.elmTypeE.Name = "elmTypeE";
            this.elmTypeE.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.elmTypeE.Text = "file typeE";
            this.elmTypeE.Click += new System.EventHandler(this.elmTypeE_Click);
            // 
            // elmTypeP
            // 
            this.elmTypeP.Name = "elmTypeP";
            this.elmTypeP.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.elmTypeP.Text = "file typeP";
            this.elmTypeP.Click += new System.EventHandler(this.elmTypeP_Click);
            // 
            // elmTypeR
            // 
            this.elmTypeR.Name = "elmTypeR";
            this.elmTypeR.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.elmTypeR.Text = "file typeR";
            this.elmTypeR.Click += new System.EventHandler(this.elmTypeR_Click);
            // 
            // elmTypeS
            // 
            this.elmTypeS.Name = "elmTypeS";
            this.elmTypeS.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.elmTypeS.Text = "file TypeS";
            this.elmTypeS.Click += new System.EventHandler(this.elmTypeS_Click);
            // 
            // elmTypeZ
            // 
            this.elmTypeZ.Name = "elmTypeZ";
            this.elmTypeZ.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.elmTypeZ.Text = "file TypeZ";
            this.elmTypeZ.Click += new System.EventHandler(this.elmTypeZ_Click);
            // 
            // accordionControlElement5
            // 
            this.accordionControlElement5.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement7,
            this.elmCCM,
            this.elmMrktInfo,
            this.elmSeriesToSeries});
            this.accordionControlElement5.Expanded = true;
            this.accordionControlElement5.Name = "accordionControlElement5";
            this.accordionControlElement5.Text = "가공파일";
            // 
            // accordionControlElement7
            // 
            this.accordionControlElement7.Name = "accordionControlElement7";
            this.accordionControlElement7.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement7.Text = "거래소코드";
            // 
            // elmCCM
            // 
            this.elmCCM.Name = "elmCCM";
            this.elmCCM.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.elmCCM.Text = "Combined Commodity Definition";
            this.elmCCM.Click += new System.EventHandler(this.elmCCM_Click);
            // 
            // elmMrktInfo
            // 
            this.elmMrktInfo.Name = "elmMrktInfo";
            this.elmMrktInfo.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.elmMrktInfo.Text = "당사 Market 정보 기준";
            this.elmMrktInfo.Click += new System.EventHandler(this.elmMrktInfo_Click);
            // 
            // elmSeriesToSeries
            // 
            this.elmSeriesToSeries.Name = "elmSeriesToSeries";
            this.elmSeriesToSeries.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.elmSeriesToSeries.Text = "SeriesToSeries";
            this.elmSeriesToSeries.Click += new System.EventHandler(this.elmSeriesToSeries_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1310, 39);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // xtraOpenFileDialog1
            // 
            this.xtraOpenFileDialog1.FileName = "xtraOpenFileDialog1";
            // 
            // elmType3
            // 
            this.elmType3.Name = "elmType3";
            this.elmType3.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.elmType3.Text = "file Type3";
            this.elmType3.Click += new System.EventHandler(this.elmType3_Click);
            // 
            // spanMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 939);
            this.ControlContainer = this.MainContainer;
            this.Controls.Add(this.MainContainer);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "spanMain";
            this.NavigationControl = this.accordionControl1;
            this.Text = "spanMain";
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer MainContainer;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement elmType1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement elmType2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement elmType5;
        private DevExpress.XtraBars.Navigation.AccordionControlElement elmType8;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
        private DevExpress.XtraBars.Navigation.AccordionControlElement elmFileLoad;
        private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement5;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement7;
        private DevExpress.XtraBars.Navigation.AccordionControlElement elmCCM;
        private DevExpress.XtraBars.Navigation.AccordionControlElement elmTypeR;
        private DevExpress.XtraBars.Navigation.AccordionControlElement elmTypeP;
        private DevExpress.XtraBars.Navigation.AccordionControlElement elmMrktInfo;
        private DevExpress.XtraBars.Navigation.AccordionControlElement elmTypeE;
        private DevExpress.XtraBars.Navigation.AccordionControlElement elmSeriesToSeries;
        private DevExpress.XtraBars.Navigation.AccordionControlElement elmTypeC;
        private DevExpress.XtraBars.Navigation.AccordionControlElement elmTypeS;
        private DevExpress.XtraBars.Navigation.AccordionControlElement elmTypeZ;
        private DevExpress.XtraBars.Navigation.AccordionControlElement elmTypeB;
        private DevExpress.XtraBars.Navigation.AccordionControlElement elmType3;
    }
}