﻿using System;
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
        private BMS_DAL.DS.BMSDS _ds = new BMS_DAL.DS.BMSDS();
        private BMS_Service.DAService _daservice = new BMS_Service.DAService();

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

            this.AttachEvent();
        }
        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);

            this._ds.Merge(_daservice.GetFixtureWithRelation());
            this._ds.Merge(_daservice.GetVessel());
            this.BindData();
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
            string filterString = string.Format("FIXNO LIKE '%{0}%'", this.barEditItem_Search.EditValue);
            gridView1.ActiveFilterString = filterString;
        }

        void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView gv = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            Point pt = gv.GridControl.PointToClient(MousePosition);
            DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo vi = gv.CalcHitInfo(pt);
            if (vi.InRowCell || vi.InRow)
            {
                var datarowitem = (BMS_DAL.DS.BMSDS.TFixturesRow)gv.GetDataRow(vi.RowHandle);
                datarowitem.OPER = BMS_Component.UserInfo.UserName;
                datarowitem.OP_DT = DateTime.Now;
                FixtureItem item = new FixtureItem();
                item.Text = "Update Fixture";
                item.DataRowItem = datarowitem;
                switch (item.ShowDialog())
                {
                    case DialogResult.OK:
                        MessageBox.Show(string.Format("Update {0} rows", this._daservice.UpdateFixtureWithRelation(this._ds)));
                        this._ds.TFixtures.Clear();
                        this._ds.TInvoices.Clear();
                        this._ds.TInvoiceDetails.Clear();
                        this._ds.Merge(_daservice.GetFixtureWithRelation());
                        this.BindData();
                        break;
                    case DialogResult.Cancel:
                        this._ds.RejectChanges();
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
            string nString = string.Format("Confirm to delete {0}", datarowitem["FIXNO"]);
            if (MessageBox.Show(nString, "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk).Equals(DialogResult.OK))
            {
                datarowitem.Delete();
                MessageBox.Show(string.Format("Delete {0} rows", this._daservice.DeleteFixtureWithRelation(this._ds)));
                this._ds.TFixtures.Clear();
                this._ds.TInvoices.Clear();
                this._ds.TInvoiceDetails.Clear();
                this._ds.Merge(_daservice.GetFixtureWithRelation());
                this.BindData();
            }
            else
            {
                this._ds.RejectChanges();
            }
        }

        void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            var datarowitem = this._ds.TFixtures.NewTFixturesRow();
            datarowitem.VSL_ID = 1;
            datarowitem.CP_DATE = DateTime.Now;
            datarowitem.CP_TYPE = "VC";
            datarowitem.CP_DESC = string.Empty;
            datarowitem.PAYER = "OWR";
            datarowitem.HRORFRT = 0;
            datarowitem.DAYSORMT = 0;
            datarowitem.BRKRATE_OWR = 1.25M;
            datarowitem.BRKAMOUNT_OWR = 0;
            datarowitem.BRKRATE_CHR = 1.25M;
            datarowitem.BRKAMOUNT_CHR = 0;
            datarowitem.OWR = "OWR";
            datarowitem.CHR = "CHR";
            datarowitem.ESTBRK = 0;
            datarowitem.BROKER1 = "BROKER1";
            datarowitem.BROKER2 = "BROKER2";
            datarowitem.SIGNOPER = "OP";
            datarowitem.CAP_RATE = 0.5M;
            datarowitem.CAP_AMOUNT = 0;
            datarowitem.TFCB = 1;
            datarowitem.FIXNO = string.Format("P{0}", DateTime.Now.ToString("yyMMdd"));
            datarowitem.STATUS = "PROGRESS";
            datarowitem.REMARK = string.Empty;
            datarowitem.OPER = BMS_Component.UserInfo.UserName;
            datarowitem.OP_DT = DateTime.Now;
            FixtureItem item = new FixtureItem();
            item.Text = "Add Fixture";
            item.DataRowItem = datarowitem;
            this._ds.TFixtures.AddTFixturesRow(datarowitem);
            switch (item.ShowDialog())
            {
                case DialogResult.OK:
                    MessageBox.Show(string.Format("Add {0} rows", this._daservice.UpdateFixtureWithRelation(this._ds)));
                    this._ds.TFixtures.Clear();
                    this._ds.TInvoices.Clear();
                    this._ds.TInvoiceDetails.Clear();
                    this._ds.Merge(_daservice.GetFixtureWithRelation());
                    this.BindData();
                    break;
                case DialogResult.Cancel:
                    datarowitem = null;
                    this._ds.RejectChanges();
                    break;
            }
        }

        private void BindData()
        {
            this.bindingSource1.DataSource = this._ds.TFixtures;
            this.bindingNavigator1.BindingSource = this.bindingSource1;
            this.gridControl1.DataSource = this.bindingSource1;
        }
    }
}
