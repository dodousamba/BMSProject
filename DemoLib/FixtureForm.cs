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
    public partial class FixtureForm : Form
    {
        private BMS_DAL.DS.BMSDS.TFixturesDataTable _dt = new BMS_DAL.DS.BMSDS.TFixturesDataTable();

        private static FixtureForm _instance = null;
        public static FixtureForm GetInstance(object args)
        {
            if (_instance == null)
            {
                _instance = new FixtureForm();
            }
            _instance.Focus();
            return _instance;
        }

        private FixtureForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.GetData();
            this.BindData();

            this.AttachEvent();
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
 
            _instance = null;
        }

        private void AttachEvent()
        {
            this.toolStripButton_Save.Click += toolStripButton_Save_Click;
        }

        void toolStripButton_Save_Click(object sender, EventArgs e)
        {
            using (BMS_DAL.DS.BMSDSTableAdapters.TFixturesTableAdapter ta = new BMS_DAL.DS.BMSDSTableAdapters.TFixturesTableAdapter())
            {
                MessageBox.Show(string.Format("Update {0} rows", ta.UpdateWithTrans(this._dt)));
                this._dt = ta.GetData();
            }
            this.BindData();
        }
        private void GetData()
        {
            using (BMS_DAL.DS.BMSDSTableAdapters.TFixturesTableAdapter ta = new BMS_DAL.DS.BMSDSTableAdapters.TFixturesTableAdapter())
            {
                this._dt = ta.GetData();
            }
        }
        private void BindData()
        {
            this.bindingSource1.DataSource = this._dt;
            this.bindingNavigator1.BindingSource = this.bindingSource1;
            this.gridControl1.DataSource = this.bindingSource1;
        }
    }
}
