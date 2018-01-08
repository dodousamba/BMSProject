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

            this.gridView1.DoubleClick += gridView1_DoubleClick;

            this.barLargeButtonItem_Search.ItemClick += barLargeButtonItem_Search_ItemClick;
        }

        void barLargeButtonItem_Search_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string filterString = string.Format("NAME LIKE '%{0}%'", this.barEditItem_Search.EditValue);
            gridView1.ActiveFilterString = filterString;

        }

        void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView gv = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            Point pt = gv.GridControl.PointToClient(MousePosition);
            DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo vi = gv.CalcHitInfo(pt);
            if (vi.InRowCell || vi.InRow)
            {
                var datarowitem = (BMS_DAL.DS.BMSDS.TVesselsRow)gv.GetDataRow(vi.RowHandle);
                datarowitem.OPER = BMS_Component.UserInfo.UserName;
                datarowitem.OP_DT = DateTime.Now;
                VesselItem item = new VesselItem();
                item.Text = "Update Vessel";
                item.DataRowItem = datarowitem;
                switch (item.ShowDialog())
                {
                    case DialogResult.OK:
                        MessageBox.Show(string.Format("Update {0} rows", this._daservice.UpdateVessel(this._dt)));
                        this._dt = _daservice.GetVessel();
                        this.BindData();
                        break;
                    case DialogResult.Cancel:
                        this._dt.RejectChanges();
                        break;
                }
            }
        }

        void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (this.bindingSource1.Current == null)
            {
                MessageBox.Show("Please select a row!");
                return;
            }
            var datarowitem = (DataRowView)(this.bindingSource1.Current);
            string nString = string.Format("Confirm to delete {0}", datarowitem["NAME"]);
            if (MessageBox.Show(nString, "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk).Equals(DialogResult.OK))
            {
                datarowitem.Delete();
                MessageBox.Show(string.Format("Delete {0} rows", this._daservice.UpdateVessel(this._dt)));
                this._dt = _daservice.GetVessel();
                this.BindData();
            }
            else
            {
                this._dt.RejectChanges();
            }
        }

        void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            var datarowitem = this._dt.NewTVesselsRow();
            datarowitem.NAME = "New Vessel";
            datarowitem.SIZE = "PMX";
            datarowitem.DESC = string.Empty;
            datarowitem.OPER = BMS_Component.UserInfo.UserName;
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
                    this._dt.RejectChanges();
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
