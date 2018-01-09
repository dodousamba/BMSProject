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
    public partial class OnProgressForm : Form
    {
        private BMS_DAL.DS.BMSDS _ds = new BMS_DAL.DS.BMSDS();
        private BMS_Service.DAService _daservice = new BMS_Service.DAService();
        private static OnProgressForm _instance = null;
        public static OnProgressForm GetInstance(object args)
        {
            if (_instance == null)
            {
                _instance = new OnProgressForm();
            }
            _instance.Focus();
            return _instance;
        }
        private OnProgressForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.repositoryItemComboBox1.Items.Add("BROKER");
            this.repositoryItemComboBox1.Items.Add("ACCOUNT");
            this.barEditItem1.EditValue = "BROKER";
          

            this.AttachEvent();
        }
        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);

            this._ds = _daservice.GetFixtureWithRelation();
            barEditItem1_EditValueChanged(barEditItem1, new EventArgs());
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            _instance = null;
        }

        private void AttachEvent()
        {
            this.barEditItem1.EditValueChanged += barEditItem1_EditValueChanged;

        }

        void barEditItem1_EditValueChanged(object sender, EventArgs e)
        {
            switch (barEditItem1.EditValue.ToString())
            {
                case "BROKER":
                    this.bindingSource1.DataSource = _ds.TFixtures;
                    break;
                case "ACCOUNT":
                    this.bindingSource1.DataSource = _ds.TInvoices;
                    break;
            }
            this.gridView2.Columns.Clear();
            this.gridControl2.DataSource = null;
            this.gridControl2.DataSource = this.bindingSource1;
        }


    }
}
