using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace DemoLib
{
    public partial class DemoContainer : Form
    {
        public DemoContainer()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            BMS_Component.UserInfo.UserName = "ADMIN";
            BMS_Component.StaticMethods.GetServerDate("http://hyw2583870001.my3w.com");

            this.AttachEvent();
        }

        private void AttachEvent()
        {
            this.navBarItem_OnProgress.LinkClicked += navBarItem_LinkClicked;
            this.navBarItem_Fixture.LinkClicked += navBarItem_LinkClicked;
            this.navBarItem_Invoice.LinkClicked += navBarItem_LinkClicked;
            this.navBarItem_Vessel.LinkClicked += navBarItem_LinkClicked;
            this.navBarItem_InvoiceReport.LinkClicked += navBarItem_LinkClicked;

            this.barButtonItem_Exit.ItemClick += barButtonItem_Exit_ItemClick;

        }

        void barButtonItem_Exit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        void navBarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            DevExpress.XtraNavBar.NavBarItem nbi = sender as DevExpress.XtraNavBar.NavBarItem;

            string assemblyType = nbi.Tag.ToString();
            System.Reflection.Assembly fAssembly = (Assembly)Assembly.GetExecutingAssembly();
            Type fType = fAssembly.GetType(assemblyType);
            BindingFlags bindingFlags =  BindingFlags.Public | BindingFlags.Static;
            MethodInfo instanceMethod = fType.GetMethod("GetInstance", bindingFlags);
            object[] args = new object[1];
            Form f = (Form)instanceMethod.Invoke(null, args);

            f.MdiParent = this;
            f.Show();
        }


    }
}
