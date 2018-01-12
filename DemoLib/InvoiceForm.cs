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
        private BMS_DAL.DS.BMSDS _ds = new BMS_DAL.DS.BMSDS();
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

            this.AttachEvent();
        }
        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);

            this._ds.Merge( _daservice.GetFixtureWithRelation());
            this._ds.Merge(_daservice.GetVessel());
            this.BindData1();
            this.BindData2();
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

            this.gridView1.FocusedRowChanged += gridView1_FocusedRowChanged;
            this.gridView2.DoubleClick += gridView2_DoubleClick;

            this.barLargeButtonItem_Search.ItemClick += barLargeButtonItem_Search_ItemClick;
        }

        void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView gv = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            var datarowitem = (BMS_DAL.DS.BMSDS.TFixturesRow)gv.GetFocusedDataRow();
            if (this.bindingSource1.Current != null)
            {
                this.bindingSource2.Filter = string.Format("FIX_ID='{0}'", datarowitem.ID);
            }
        }


        void barLargeButtonItem_Search_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }


        void gridView2_DoubleClick(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView gv = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            Point pt = gv.GridControl.PointToClient(MousePosition);
            DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo vi = gv.CalcHitInfo(pt);
            if (vi.InRowCell || vi.InRow)
            {
                var selecteddatarow = (BMS_DAL.DS.BMSDS.TFixturesRow)((DataRowView)this.bindingSource1.Current).Row;
                var datarowitem = (BMS_DAL.DS.BMSDS.TInvoicesRow)gv.GetDataRow(vi.RowHandle);
                datarowitem.OPER = BMS_Component.UserInfo.UserName;
                datarowitem.OP_DT = DateTime.Now;
                InvoiceItem item = new InvoiceItem();
                item.Text = "Update Invoice";
                item.FixDataRow = selecteddatarow;
                item.DataRowItem = datarowitem;
                item.InvoiceDetailDV = _ds.TInvoiceDetails.DefaultView;
                item.InvoiceDetailDV.RowFilter = string.Format("INVOICE_ID='{0}'", datarowitem.ID);
                switch (item.ShowDialog())
                {
                    case DialogResult.OK:
                        MessageBox.Show(string.Format("Update {0} rows", this._daservice.UpdateFixtureWithRelation(_ds)));
                        this._ds.TFixtures.Clear();
                        this._ds.TInvoices.Clear();
                        this._ds.TInvoiceDetails.Clear();
                        this._ds.Merge(_daservice.GetFixtureWithRelation());
                        this.BindData1();
                        this.BindData2();
                        break;
                    case DialogResult.Cancel:
                        this._ds.RejectChanges();
                        break;
                }
            }
        }

        void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (this.bindingSource2.Current == null)
            {
                MessageBox.Show("Please select a row!");
                return;
            }
            var datarowitem = (DataRowView)(this.bindingSource2.Current);
            string nString = string.Format("Confirm to delete {0}", datarowitem["REFNO"]);
            if (MessageBox.Show(nString, "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk).Equals(DialogResult.OK))
            {
                datarowitem.Delete();
                MessageBox.Show(string.Format("Delete {0} rows", this._daservice.DeleteFixtureWithRelation(this._ds)));
                this._ds.TFixtures.Clear();
                this._ds.TInvoices.Clear();
                this._ds.TInvoiceDetails.Clear();
                this._ds.Merge(_daservice.GetFixtureWithRelation());
                this.BindData1();
                this.BindData2();
            }
            else
            {
                this._ds.TInvoices.RejectChanges();
            }
        }

        void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (this.bindingSource1.Current == null)
            {
                MessageBox.Show("Please select a fix!");
                return;
            }
            var selecteddatarow = (BMS_DAL.DS.BMSDS.TFixturesRow)((DataRowView)this.bindingSource1.Current).Row;
            var datarowitem = this._ds.TInvoices.NewTInvoicesRow();
            datarowitem.VSL_ID = selecteddatarow.VSL_ID;
            datarowitem.CP_DATE = selecteddatarow.CP_DATE;
            datarowitem.CP_TYPE = selecteddatarow.CP_TYPE;
            datarowitem.CP_DESC = selecteddatarow.CP_DESC;
            datarowitem.MESSES = selecteddatarow.PAYER;
            datarowitem.HRORFRT = selecteddatarow.HRORFRT;
            datarowitem.DAYSORMT = selecteddatarow.DAYSORMT;
            datarowitem.BRKRATE_OWR = selecteddatarow.BRKRATE_OWR;
            datarowitem.BRKAMOUNT_OWR = selecteddatarow.BRKAMOUNT_OWR;
            datarowitem.BRKRATE_CHR = selecteddatarow.BRKRATE_CHR;
            datarowitem.BRKAMOUNT_CHR = selecteddatarow.BRKAMOUNT_CHR;
            datarowitem.OWR = selecteddatarow.OWR;
            datarowitem.CHR = selecteddatarow.CHR;
            datarowitem.FIXNO = selecteddatarow.FIXNO;
            datarowitem.STATUS = "PROGRESS";
            datarowitem.REMARK = string.Empty;
            datarowitem.REFNO = string.Format("CW{0}", DateTime.Now.ToString("yyMMdd"));
            datarowitem.OPER = BMS_Component.UserInfo.UserName;
            datarowitem.INVOICE_DATE = DateTime.Now;
            datarowitem.CWNO = string.Empty;
            datarowitem.ATIN = string.Empty;
            datarowitem.RECEIVABLEAMOUNT = 0;
            datarowitem.RECEIVABLEDATE = DateTime.Now;
            datarowitem.PERIODS = "1";
            datarowitem.BANKACCOUNT = "bromar";
            datarowitem.FIX_ID = selecteddatarow.ID;
            datarowitem.REMARK = string.Empty;
            datarowitem.OP_DT = DateTime.Now;
            InvoiceItem item = new InvoiceItem();
            item.Text = "Add Invoice";
            item.FixDataRow = selecteddatarow;
            item.DataRowItem = datarowitem;
            item.InvoiceDetailDV = _ds.TInvoiceDetails.DefaultView;
            item.InvoiceDetailDV.RowFilter = string.Format("INVOICE_ID='{0}'", datarowitem.ID);
            this._ds.TInvoices.AddTInvoicesRow(datarowitem);
            switch (item.ShowDialog())
            {
                case DialogResult.OK:
                    MessageBox.Show(string.Format("Add {0} rows", this._daservice.UpdateFixtureWithRelation(this._ds)));
                    this._ds.TFixtures.Clear();
                    this._ds.TInvoices.Clear();
                    this._ds.TInvoiceDetails.Clear();
                    this._ds.Merge(_daservice.GetFixtureWithRelation());
                    this.BindData1();
                    this.BindData2();
                    break;
                case DialogResult.Cancel:
                    datarowitem = null;
                    this._ds.RejectChanges();
                    break;
            }
        }

        private void BindData1()
        {
            this.bindingSource1.DataSource = _ds.TFixtures;
            this.gridControl1.DataSource = this.bindingSource1;
        }
        private void BindData2()
        {
            this.bindingSource2.DataSource = _ds.TInvoices;
            this.bindingNavigator1.BindingSource = this.bindingSource2;
            this.gridControl2.DataSource = this.bindingSource2;
        }
    }
}
