namespace DemoLib
{
    partial class DemoContainer
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
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Exit = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.barMdiChildrenListItem1 = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.barSubItem4 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup_Sys = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem_User = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup_Flow = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem_OnProgress = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup_Broker = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem_Fixture = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup_Account = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem_Invoice = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.MenuManager = this.barManager1;
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "System.Windows.Forms.Form"});
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockManager = this.dockManager1;
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barStaticItem1,
            this.barSubItem1,
            this.barSubItem2,
            this.barSubItem4,
            this.barMdiChildrenListItem1,
            this.barSubItem3,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem_Exit,
            this.barButtonItem3,
            this.barButtonItem4});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 24;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barMdiChildrenListItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem4)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
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
            // barMdiChildrenListItem1
            // 
            this.barMdiChildrenListItem1.Caption = "Windows(&W)";
            this.barMdiChildrenListItem1.Id = 10;
            this.barMdiChildrenListItem1.Name = "barMdiChildrenListItem1";
            // 
            // barSubItem4
            // 
            this.barSubItem4.Caption = "Help(&H)";
            this.barSubItem4.Id = 8;
            this.barSubItem4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4, true)});
            this.barSubItem4.Name = "barSubItem4";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Document(&D)...";
            this.barButtonItem3.Id = 22;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "About(&A)";
            this.barButtonItem4.Id = 23;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Status";
            this.barStaticItem1.Id = 4;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1064, 22);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 656);
            this.barDockControlBottom.Size = new System.Drawing.Size(1064, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 634);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1064, 22);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 634);
            // 
            // barSubItem3
            // 
            this.barSubItem3.Caption = "-";
            this.barSubItem3.Id = 12;
            this.barSubItem3.Name = "barSubItem3";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "DevExpress Dark Style";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.navBarControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 22);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(200, 634);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "MENU";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup_Sys;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup_Flow,
            this.navBarGroup_Broker,
            this.navBarGroup_Account,
            this.navBarGroup_Sys});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItem_OnProgress,
            this.navBarItem_Fixture,
            this.navBarItem_Invoice,
            this.navBarItem_User});
            this.navBarControl1.Location = new System.Drawing.Point(2, 22);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 196;
            this.navBarControl1.Size = new System.Drawing.Size(196, 610);
            this.navBarControl1.TabIndex = 3;
            this.navBarControl1.Text = "navBarControl";
            // 
            // navBarGroup_Sys
            // 
            this.navBarGroup_Sys.Caption = "Sys";
            this.navBarGroup_Sys.Expanded = true;
            this.navBarGroup_Sys.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_User)});
            this.navBarGroup_Sys.Name = "navBarGroup_Sys";
            // 
            // navBarItem_User
            // 
            this.navBarItem_User.Caption = "User";
            this.navBarItem_User.Name = "navBarItem_User";
            this.navBarItem_User.Tag = "DemoLib.FUser";
            // 
            // navBarGroup_Flow
            // 
            this.navBarGroup_Flow.Caption = "Flow";
            this.navBarGroup_Flow.Expanded = true;
            this.navBarGroup_Flow.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_OnProgress)});
            this.navBarGroup_Flow.Name = "navBarGroup_Flow";
            // 
            // navBarItem_OnProgress
            // 
            this.navBarItem_OnProgress.Caption = "OnProgress";
            this.navBarItem_OnProgress.Name = "navBarItem_OnProgress";
            this.navBarItem_OnProgress.Tag = "DemoLib.FOnProgress";
            // 
            // navBarGroup_Broker
            // 
            this.navBarGroup_Broker.Caption = "Broker";
            this.navBarGroup_Broker.Expanded = true;
            this.navBarGroup_Broker.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_Fixture)});
            this.navBarGroup_Broker.Name = "navBarGroup_Broker";
            // 
            // navBarItem_Fixture
            // 
            this.navBarItem_Fixture.Caption = "Fixture";
            this.navBarItem_Fixture.Name = "navBarItem_Fixture";
            this.navBarItem_Fixture.Tag = "DemoLib.FFixture";
            // 
            // navBarGroup_Account
            // 
            this.navBarGroup_Account.Caption = "Account";
            this.navBarGroup_Account.Expanded = true;
            this.navBarGroup_Account.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_Invoice)});
            this.navBarGroup_Account.Name = "navBarGroup_Account";
            // 
            // navBarItem_Invoice
            // 
            this.navBarItem_Invoice.Caption = "Invoice";
            this.navBarItem_Invoice.Name = "navBarItem_Invoice";
            this.navBarItem_Invoice.Tag = "DemoLib.FInvoice";
            // 
            // DemoContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IsMdiContainer = true;
            this.Name = "DemoContainer";
            this.Text = "DemoContainer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarMdiChildrenListItem barMdiChildrenListItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem4;
        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Exit;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup_Sys;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_User;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup_Flow;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_OnProgress;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup_Broker;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_Fixture;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup_Account;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_Invoice;
    }
}