using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BMS_BaseInfo
{
    public partial class VesselForm : Form
    {
        private BMS_DAL.DS.BMSDS.TVesselsDataTable _tvesselDT = new BMS_DAL.DS.BMSDS.TVesselsDataTable();
        private BMS_Service.DAService _daService = new BMS_Service.DAService();

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

            this._tvesselDT.Clear();
            this._tvesselDT.Merge( _daService.GetVessel());
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

            this.gridView.DoubleClick += gridView_DoubleClick;
        }

        void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            var datarowitem = this._tvesselDT.NewTVesselsRow();
            datarowitem.NAME = "New Vessel";
            datarowitem.SIZE = "PMX";
            datarowitem.DESC = string.Empty;
            datarowitem.OPER = BMS_Component.UserInfo.UserName;
            datarowitem.OP_DT = DateTimeOffset.Now;
            VesselItem item = new VesselItem();
            item.Text = "Add Vessel";
            item.DataRowItem = datarowitem;
            this._tvesselDT.AddTVesselsRow(datarowitem);
            switch (item.ShowDialog())
            {
                case DialogResult.OK:
                    MessageBox.Show(string.Format("Add {0} rows", this._daService.UpdateVessel(this._tvesselDT)));
                    this.RefreshData();
                    this.BindData();
                    break;
                case DialogResult.Cancel:
                    datarowitem = null;
                    this._tvesselDT.RejectChanges();
                    break;
            }
        }

        void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (this.bindingSource.Current == null)
            {
                MessageBox.Show("Please select a row!");
                return;
            }
            var datarowitem = (DataRowView)(this.bindingSource.Current);
            string nString = string.Format("Confirm to delete {0}", datarowitem["NAME"]);
            if (MessageBox.Show(nString, "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk).Equals(DialogResult.OK))
            {
                datarowitem.Delete();
                MessageBox.Show(string.Format("Delete {0} rows", this._daService.UpdateVessel(this._tvesselDT)));
                this.RefreshData();
                this.BindData();
            }
            else
            {
                this._tvesselDT.RejectChanges();
            }
        }

        void gridView_DoubleClick(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView gv = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            Point pt = gv.GridControl.PointToClient(MousePosition);
            DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo vi = gv.CalcHitInfo(pt);
            if (vi.InRowCell || vi.InRow)
            {
                var datarowitem = (BMS_DAL.DS.BMSDS.TVesselsRow)gv.GetDataRow(vi.RowHandle);
                datarowitem.OPER = BMS_Component.UserInfo.UserName;
                datarowitem.OP_DT = DateTimeOffset.Now;
                VesselItem item = new VesselItem();
                item.Text = "Update Vessel";
                item.DataRowItem = datarowitem;
                switch (item.ShowDialog())
                {
                    case DialogResult.OK:
                        MessageBox.Show(string.Format("Update {0} rows", this._daService.UpdateVessel(this._tvesselDT)));
                        this.RefreshData();
                        this.BindData();
                        break;
                    case DialogResult.Cancel:
                        this._tvesselDT.RejectChanges();
                        break;
                }
            }
        }

        private void RefreshData()
        {
            this._tvesselDT.Clear();
            this._tvesselDT.Merge(_daService.GetVessel());
        }
        private void BindData()
        {
            this.bindingSource.DataSource = this._tvesselDT;
            this.bindingNavigator.BindingSource = this.bindingSource;
            this.gridControl.DataSource = this.bindingSource;
        }
    }
}
