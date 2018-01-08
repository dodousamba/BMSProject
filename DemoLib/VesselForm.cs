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
    public partial class VesselForm : Form
    {
        private BMS_DAL.DS.BMSDS.TVesselsDataTable _dt = new BMS_DAL.DS.BMSDS.TVesselsDataTable();
        private BMS_Service.DAService _daservice = new BMS_Service.DAService();

        private static VesselForm _instance = null;
        public static VesselForm GetInstance(object args)
        {
            if (_instance == null)
            {
                _instance = new VesselForm();
            }
            _instance.Focus();
            return _instance;
        }
        private VesselForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this._dt = _daservice.GetVessel();
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
            this.bindingNavigatorAddNewItem.Click += bindingNavigatorAddNewItem_Click;
            this.bindingNavigatorDeleteItem.Click += bindingNavigatorDeleteItem_Click;
        }

        void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Delete {0} rows", this._daservice.UpdateVessel(this._dt)));
            this._dt = _daservice.GetVessel();
            this.BindData();
        }

        void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            var datarowitem = this._dt.NewTVesselsRow();
            datarowitem.NAME = "New Vessel";
            datarowitem.SIZE = "PMX";
            datarowitem.DESC = string.Empty;
            datarowitem.OPER = string.Empty;
            datarowitem.OP_DT = DateTime.Now;
            VesselItem item = new VesselItem();
            item.Text = "Add Vessel";
            item.DataRowItem = datarowitem;
            switch (item.ShowDialog())
            {
                case DialogResult.OK:
                    this._dt.AddTVesselsRow(datarowitem);
                    MessageBox.Show(string.Format("Add {0} rows", this._daservice.UpdateVessel(this._dt)));
                    this._dt = _daservice.GetVessel();
                    this.BindData();
                    break;
                case DialogResult.Cancel:
                    datarowitem = null;
                    break;
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
