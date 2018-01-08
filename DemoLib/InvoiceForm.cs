using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoLib
{
    public partial class InvoiceForm : Form
    {
        private BMS_DAL.DS.BMSDS _bmsDS = new BMS_DAL.DS.BMSDS();
        private BMS_Service.DAService _daservice = new BMS_Service.DAService();
        

        private static InvoiceForm _instance = null;
        public static InvoiceForm GetInstance(object args)
        {
            if (_instance == null)
            {
                _instance = new InvoiceForm();
            }
            _instance.Focus();
            return _instance;
        }

        private InvoiceForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _bmsDS.Merge(_daservice.GetFixture());
            this.bindingSource1.DataSource = _bmsDS.TFixtures;
            this.gridControl1.DataSource = this.bindingSource1;
            _bmsDS.Merge(_daservice.GetInvoice());
            this.bindingSource2.DataSource = _bmsDS.TInvoices;
            if (this.bindingSource1.Current != null)
            {
                this.bindingSource2.Filter = string.Format("FIXNO='{0}'", ((DataRowView)this.bindingSource1.Current)["FIXNO"]);
            }
            this.bindingNavigator1.BindingSource=this.bindingSource2;
            this.gridControl2.DataSource = this.bindingSource2;

            this.AttachEvent();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
 
            _instance = null;
        }

        private void AttachEvent()
        {

        }
    }
}
