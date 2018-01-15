using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace BMS_Win
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            BMS_Component.UserInfo.UserName = "ADMIN";
            
            this.AttchEvent();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
        }

        private void AttchEvent()
        {
            this.navBarItem_Fixture.LinkClicked += navBarItem_LinkClicked;

            this.navBarItem_Vessel.LinkClicked += navBarItem_LinkClicked;
        }

        void navBarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            DevExpress.XtraNavBar.NavBarItem item = sender as DevExpress.XtraNavBar.NavBarItem;


            string assemblyType = item.Tag.ToString();
            string fileName=assemblyType.Split('.')[0];
            System.Reflection.Assembly fAssembly = (Assembly)Assembly.LoadFrom(string.Format(@".\{0}.dll", fileName));
            Type fType = fAssembly.GetType(assemblyType);
            BindingFlags bindingFlags = BindingFlags.Public | BindingFlags.Static;
            MethodInfo instanceMethod = fType.GetMethod("GetInstance", bindingFlags);
            object[] args = new object[1];
            Form f = (Form)instanceMethod.Invoke(null, args);

            f.MdiParent = this;
            f.Show();
        }
    }
}
