namespace BMS_Win
{
    partial class HomeForm
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
            this.barManager_Home = new DevExpress.XtraBars.BarManager();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barMdiChildrenListItem_Windows = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.barSubItem_Help = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem_Document = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_About = new DevExpress.XtraBars.BarButtonItem();
            this.bar_Status = new DevExpress.XtraBars.Bar();
            this.barStaticItem_Status1 = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Exit = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            this.groupControl_Menu = new DevExpress.XtraEditors.GroupControl();
            this.navBarControl_LeftSide = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup_Flow = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem_FlowCenter = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem_FlowNotice = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup_Broker = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem_Fixture = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup_Operator = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem_Invoice = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup_Account = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroup_Report = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroup_BaseInfo = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem_Client = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem_User = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem_Vessel = new DevExpress.XtraNavBar.NavBarItem();
            this.splitter1 = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.barManager_Home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_Menu)).BeginInit();
            this.groupControl_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl_LeftSide)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager_Home
            // 
            this.barManager_Home.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar_Status});
            this.barManager_Home.DockControls.Add(this.barDockControlTop);
            this.barManager_Home.DockControls.Add(this.barDockControlBottom);
            this.barManager_Home.DockControls.Add(this.barDockControlLeft);
            this.barManager_Home.DockControls.Add(this.barDockControlRight);
            this.barManager_Home.Form = this;
            this.barManager_Home.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barStaticItem_Status1,
            this.barSubItem1,
            this.barSubItem2,
            this.barSubItem_Help,
            this.barMdiChildrenListItem_Windows,
            this.barSubItem3,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem_Exit,
            this.barButtonItem_Document,
            this.barButtonItem_About});
            this.barManager_Home.MainMenu = this.bar2;
            this.barManager_Home.MaxItemId = 24;
            this.barManager_Home.StatusBar = this.bar_Status;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barMdiChildrenListItem_Windows),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem_Help)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barMdiChildrenListItem_Windows
            // 
            this.barMdiChildrenListItem_Windows.Caption = "Windows(&W)";
            this.barMdiChildrenListItem_Windows.Id = 10;
            this.barMdiChildrenListItem_Windows.Name = "barMdiChildrenListItem_Windows";
            // 
            // barSubItem_Help
            // 
            this.barSubItem_Help.Caption = "Help(&H)";
            this.barSubItem_Help.Id = 8;
            this.barSubItem_Help.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_Document),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_About, true)});
            this.barSubItem_Help.Name = "barSubItem_Help";
            // 
            // barButtonItem_Document
            // 
            this.barButtonItem_Document.Caption = "Document(&D)...";
            this.barButtonItem_Document.Id = 22;
            this.barButtonItem_Document.Name = "barButtonItem_Document";
            // 
            // barButtonItem_About
            // 
            this.barButtonItem_About.Caption = "About(&A)";
            this.barButtonItem_About.Id = 23;
            this.barButtonItem_About.Name = "barButtonItem_About";
            // 
            // bar_Status
            // 
            this.bar_Status.BarName = "Status bar";
            this.bar_Status.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar_Status.DockCol = 0;
            this.bar_Status.DockRow = 0;
            this.bar_Status.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar_Status.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem_Status1)});
            this.bar_Status.OptionsBar.AllowQuickCustomization = false;
            this.bar_Status.OptionsBar.DrawDragBorder = false;
            this.bar_Status.OptionsBar.UseWholeRow = true;
            this.bar_Status.Text = "Status bar";
            // 
            // barStaticItem_Status1
            // 
            this.barStaticItem_Status1.Caption = "Hello Bromar";
            this.barStaticItem_Status1.Id = 4;
            this.barStaticItem_Status1.Name = "barStaticItem_Status1";
            this.barStaticItem_Status1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1303, 27);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 528);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1303, 30);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 27);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 501);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1303, 27);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 501);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "File(&F)";
            this.barSubItem1.Id = 5;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_Exit, true)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "New(&N)...";
            this.barButtonItem1.Id = 19;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Open(&O)...";
            this.barButtonItem2.Id = 20;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem_Exit
            // 
            this.barButtonItem_Exit.Caption = "Exit(&X)";
            this.barButtonItem_Exit.Id = 21;
            this.barButtonItem_Exit.Name = "barButtonItem_Exit";
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "Edit(&E)";
            this.barSubItem2.Id = 6;
            this.barSubItem2.Name = "barSubItem2";
            // 
            // barSubItem3
            // 
            this.barSubItem3.Caption = "-";
            this.barSubItem3.Id = 12;
            this.barSubItem3.Name = "barSubItem3";
            // 
            // groupControl_Menu
            // 
            this.groupControl_Menu.Controls.Add(this.navBarControl_LeftSide);
            this.groupControl_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl_Menu.Location = new System.Drawing.Point(0, 27);
            this.groupControl_Menu.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl_Menu.Name = "groupControl_Menu";
            this.groupControl_Menu.Size = new System.Drawing.Size(267, 501);
            this.groupControl_Menu.TabIndex = 8;
            this.groupControl_Menu.Text = "MENU";
            // 
            // navBarControl_LeftSide
            // 
            this.navBarControl_LeftSide.ActiveGroup = this.navBarGroup_Flow;
            this.navBarControl_LeftSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl_LeftSide.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup_Flow,
            this.navBarGroup_Broker,
            this.navBarGroup_Operator,
            this.navBarGroup_Account,
            this.navBarGroup_Report,
            this.navBarGroup_BaseInfo});
            this.navBarControl_LeftSide.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItem_FlowCenter,
            this.navBarItem_Fixture,
            this.navBarItem_Invoice,
            this.navBarItem_Vessel,
            this.navBarItem_FlowNotice,
            this.navBarItem_Client,
            this.navBarItem_User});
            this.navBarControl_LeftSide.Location = new System.Drawing.Point(2, 26);
            this.navBarControl_LeftSide.Margin = new System.Windows.Forms.Padding(4);
            this.navBarControl_LeftSide.Name = "navBarControl_LeftSide";
            this.navBarControl_LeftSide.OptionsNavPane.ExpandedWidth = 263;
            this.navBarControl_LeftSide.Size = new System.Drawing.Size(263, 473);
            this.navBarControl_LeftSide.TabIndex = 4;
            this.navBarControl_LeftSide.Text = "navBarControl";
            // 
            // navBarGroup_Flow
            // 
            this.navBarGroup_Flow.Caption = "Flow";
            this.navBarGroup_Flow.Expanded = true;
            this.navBarGroup_Flow.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_FlowCenter),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_FlowNotice)});
            this.navBarGroup_Flow.Name = "navBarGroup_Flow";
            this.navBarGroup_Flow.Tag = "FLOW";
            // 
            // navBarItem_FlowCenter
            // 
            this.navBarItem_FlowCenter.Caption = "Center";
            this.navBarItem_FlowCenter.Name = "navBarItem_FlowCenter";
            this.navBarItem_FlowCenter.Tag = "FLOWCENTER";
            // 
            // navBarItem_FlowNotice
            // 
            this.navBarItem_FlowNotice.Caption = "Notice";
            this.navBarItem_FlowNotice.Name = "navBarItem_FlowNotice";
            this.navBarItem_FlowNotice.Tag = "FLOWNOTICE";
            // 
            // navBarGroup_Broker
            // 
            this.navBarGroup_Broker.Caption = "Broker";
            this.navBarGroup_Broker.Expanded = true;
            this.navBarGroup_Broker.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_Fixture)});
            this.navBarGroup_Broker.Name = "navBarGroup_Broker";
            this.navBarGroup_Broker.Tag = "BROKER";
            // 
            // navBarItem_Fixture
            // 
            this.navBarItem_Fixture.Caption = "Fixture";
            this.navBarItem_Fixture.Name = "navBarItem_Fixture";
            this.navBarItem_Fixture.Tag = "BMS_Core.FixtureForm";
            // 
            // navBarGroup_Operator
            // 
            this.navBarGroup_Operator.Caption = "Operator";
            this.navBarGroup_Operator.Expanded = true;
            this.navBarGroup_Operator.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_Invoice)});
            this.navBarGroup_Operator.Name = "navBarGroup_Operator";
            this.navBarGroup_Operator.Tag = "OPERATOR";
            // 
            // navBarItem_Invoice
            // 
            this.navBarItem_Invoice.Caption = "Invoice";
            this.navBarItem_Invoice.Name = "navBarItem_Invoice";
            this.navBarItem_Invoice.Tag = "INVOICE";
            // 
            // navBarGroup_Account
            // 
            this.navBarGroup_Account.Caption = "Account";
            this.navBarGroup_Account.Expanded = true;
            this.navBarGroup_Account.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_Invoice)});
            this.navBarGroup_Account.Name = "navBarGroup_Account";
            // 
            // navBarGroup_Report
            // 
            this.navBarGroup_Report.Caption = "Report";
            this.navBarGroup_Report.Expanded = true;
            this.navBarGroup_Report.Name = "navBarGroup_Report";
            // 
            // navBarGroup_BaseInfo
            // 
            this.navBarGroup_BaseInfo.Caption = "BaseInfo";
            this.navBarGroup_BaseInfo.Expanded = true;
            this.navBarGroup_BaseInfo.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_Client),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_User),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_Vessel)});
            this.navBarGroup_BaseInfo.Name = "navBarGroup_BaseInfo";
            // 
            // navBarItem_Client
            // 
            this.navBarItem_Client.Caption = "Client";
            this.navBarItem_Client.Name = "navBarItem_Client";
            this.navBarItem_Client.Tag = "CLIENT";
            // 
            // navBarItem_User
            // 
            this.navBarItem_User.Caption = "User";
            this.navBarItem_User.Name = "navBarItem_User";
            this.navBarItem_User.Tag = "USER";
            // 
            // navBarItem_Vessel
            // 
            this.navBarItem_Vessel.Caption = "Vessel";
            this.navBarItem_Vessel.Name = "navBarItem_Vessel";
            this.navBarItem_Vessel.Tag = "BMS_BaseInfo.VesselForm";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(267, 27);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 501);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 558);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.groupControl_Menu);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IsMdiContainer = true;
            this.Name = "HomeForm";
            this.Text = "Bromar Manager System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.barManager_Home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_Menu)).EndInit();
            this.groupControl_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl_LeftSide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager_Home;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarMdiChildrenListItem barMdiChildrenListItem_Windows;
        private DevExpress.XtraBars.BarSubItem barSubItem_Help;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Document;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_About;
        private DevExpress.XtraBars.Bar bar_Status;
        private DevExpress.XtraBars.BarStaticItem barStaticItem_Status1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Exit;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
        private DevExpress.XtraEditors.GroupControl groupControl_Menu;
        private DevExpress.XtraNavBar.NavBarControl navBarControl_LeftSide;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup_Report;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup_Flow;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_FlowCenter;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup_Broker;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_Fixture;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup_Account;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_Invoice;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup_BaseInfo;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_Vessel;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_FlowNotice;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup_Operator;
        private System.Windows.Forms.Splitter splitter1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_Client;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_User;

    }
}