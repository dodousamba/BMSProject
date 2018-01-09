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
    public partial class InvoiceItem : Form
    {
        public BMS_DAL.DS.BMSDS.TFixturesRow FixDataRow { get; set; }
        public BMS_DAL.DS.BMSDS.TInvoicesRow DataRowItem { get; set; }
        public DataView InvoiceDetailDV { get; set; }
        private BMS_Service.DAService _service = new BMS_Service.DAService();
        private const int setPeriods = 20;
        public InvoiceItem()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);


            BMS_DAL.DS.BMSDS.TVesselsDataTable vesselDT = _service.GetVessel();
            this.searchLookUpEdit_VSL.Properties.DataSource = vesselDT;
            this.searchLookUpEdit_VSL.Properties.DisplayMember = "NAME";
            this.searchLookUpEdit_VSL.Properties.ValueMember = "ID";

            foreach (var item in BMS_Component.StaticMethods.GetEnumDict(typeof(BMS_Component.CPTYPE)).ToList())
            {
                this.comboBoxEdit_CPTYPE.Properties.Items.Add(item.Value);
            }
            foreach (var item in BMS_Component.StaticMethods.GetEnumDict(typeof(BMS_Component.PAYER)).ToList())
            {
                this.comboBoxEdit_PAYER.Properties.Items.Add(item.Value);
            }
            for (int i = 1; i <= setPeriods;i++)
            {
                this.comboBoxEdit_PERIODS.Properties.Items.Add(i.ToString());
            }
            this.comboBoxEdit_PERIODS.Properties.Items.Add("FINAL");

            this.searchLookUpEdit_VSL.DataBindings.Add(new Binding("EditValue", FixDataRow, "VSL_ID", false, DataSourceUpdateMode.OnPropertyChanged));
            this.dateEdit_CPDATE.DataBindings.Add(new Binding("EditValue", FixDataRow, "CP_DATE", false, DataSourceUpdateMode.OnPropertyChanged));
            this.comboBoxEdit_CPTYPE.DataBindings.Add(new Binding("EditValue", FixDataRow, "CP_TYPE", false, DataSourceUpdateMode.OnPropertyChanged));
            this.comboBoxEdit_PAYER.DataBindings.Add(new Binding("EditValue", FixDataRow, "PAYER", false, DataSourceUpdateMode.OnPropertyChanged));
            this.textEdit_FIXNO.DataBindings.Add(new Binding("EditValue", FixDataRow, "FIXNO", false, DataSourceUpdateMode.OnPropertyChanged));
            this.memoEdit_CPDESC.DataBindings.Add(new Binding("EditValue", FixDataRow, "CP_DESC", false, DataSourceUpdateMode.OnPropertyChanged));
            this.textEdit_HRORFRT.DataBindings.Add(new Binding("EditValue", FixDataRow, "HRORFRT", false, DataSourceUpdateMode.OnPropertyChanged));
            this.textEdit_DAYSORMT.DataBindings.Add(new Binding("EditValue", FixDataRow, "DAYSORMT", false, DataSourceUpdateMode.OnPropertyChanged));
            this.textEdit_ESTBRK.DataBindings.Add(new Binding("EditValue", FixDataRow, "ESTBRK", false, DataSourceUpdateMode.OnPropertyChanged));
            this.searchLookUpEdit_OWR.DataBindings.Add(new Binding("EditValue", FixDataRow, "OWR", false, DataSourceUpdateMode.OnPropertyChanged));
            this.textEdit_OWRRATE.DataBindings.Add(new Binding("EditValue", FixDataRow, "BRKRATE_OWR", false, DataSourceUpdateMode.OnPropertyChanged));
            this.textEdit_OWRAMOUNT.DataBindings.Add(new Binding("EditValue", FixDataRow, "BRKAMOUNT_OWR", false, DataSourceUpdateMode.OnPropertyChanged));
            this.searchLookUpEdit_CHR.DataBindings.Add(new Binding("EditValue", FixDataRow, "CHR", false, DataSourceUpdateMode.OnPropertyChanged));
            this.textEdit_CHRRATE.DataBindings.Add(new Binding("EditValue", FixDataRow, "BRKRATE_CHR", false, DataSourceUpdateMode.OnPropertyChanged));
            this.textEdit_CHRAMOUNT.DataBindings.Add(new Binding("EditValue", FixDataRow, "BRKAMOUNT_CHR", false, DataSourceUpdateMode.OnPropertyChanged));
            this.searchLookUpEdit_BROKER1.DataBindings.Add(new Binding("EditValue", FixDataRow, "BROKER1", false, DataSourceUpdateMode.OnPropertyChanged));
            this.searchLookUpEdit_BROKER2.DataBindings.Add(new Binding("EditValue", FixDataRow, "BROKER2", false, DataSourceUpdateMode.OnPropertyChanged));
            this.searchLookUpEdit_SIGNOP.DataBindings.Add(new Binding("EditValue", FixDataRow, "SIGNOPER", false, DataSourceUpdateMode.OnPropertyChanged));
            this.textEdit_TFCB.DataBindings.Add(new Binding("EditValue", FixDataRow, "TFCB", false, DataSourceUpdateMode.OnPropertyChanged));
            this.memoEdit_FIXTUREREMARK.DataBindings.Add(new Binding("EditValue", FixDataRow, "REMARK", false, DataSourceUpdateMode.OnPropertyChanged));
            this.textEdit_CAPRATE.DataBindings.Add(new Binding("EditValue", FixDataRow, "CAP_RATE", false, DataSourceUpdateMode.OnPropertyChanged));
            this.textEdit_CAPAMOUNT.DataBindings.Add(new Binding("EditValue", FixDataRow, "CAP_AMOUNT", false, DataSourceUpdateMode.OnPropertyChanged));

            this.textEdit_REFNO.DataBindings.Add(new Binding("EditValue", DataRowItem, "REFNO", false, DataSourceUpdateMode.OnPropertyChanged));
            this.dateEdit_INVOICEDATE.DataBindings.Add(new Binding("EditValue", DataRowItem, "INVOICE_DATE", false, DataSourceUpdateMode.OnPropertyChanged));
            this.textEdit_MESSES.DataBindings.Add(new Binding("EditValue", DataRowItem, "MESSES", false, DataSourceUpdateMode.OnPropertyChanged));
            this.textEdit_CWNO.DataBindings.Add(new Binding("EditValue", DataRowItem, "CWNO", false, DataSourceUpdateMode.OnPropertyChanged));
            this.textEdit_ATIN.DataBindings.Add(new Binding("EditValue", DataRowItem, "ATIN", false, DataSourceUpdateMode.OnPropertyChanged));
            this.textEdit_BANKACCOUNT.DataBindings.Add(new Binding("EditValue", DataRowItem, "BANKACCOUNT", false, DataSourceUpdateMode.OnPropertyChanged));
            this.textEdit_RECEIVABLE.DataBindings.Add(new Binding("EditValue", DataRowItem, "RECEIVABLEAMOUNT", false, DataSourceUpdateMode.OnPropertyChanged));
            this.comboBoxEdit_PERIODS.DataBindings.Add(new Binding("EditValue", DataRowItem, "PERIODS", false, DataSourceUpdateMode.OnPropertyChanged));
            this.dateEdit_RECEIVABLEDATE.DataBindings.Add(new Binding("EditValue", DataRowItem, "RECEIVABLEDATE", false, DataSourceUpdateMode.OnPropertyChanged));
            this.memoEdit_INVOICEREMARK.DataBindings.Add(new Binding("EditValue", DataRowItem, "REMARK", false, DataSourceUpdateMode.OnPropertyChanged));

            this.BindInvoiceDetail();

            this.AttachEvent();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
        }

        private void AttachEvent()
        {
            this.AcceptButton.DialogResult = DialogResult.OK;
            this.CancelButton.DialogResult = DialogResult.Cancel;

            this.bindingNavigatorAddNewItem.Click += bindingNavigatorAddNewItem_Click;
            this.bindingNavigatorDeleteItem.Click += bindingNavigatorDeleteItem_Click;
        }

        void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            var datarowitem = InvoiceDetailDV.AddNew();
            datarowitem["INVOICE_ID"] = DataRowItem.ID;
            datarowitem["C1"] = DateTime.Now.ToString("yyyyMMdd HH:mm");
            datarowitem["C2"] = DateTime.Now.ToString("yyyyMMdd HH:mm");
            datarowitem["C3"] = string.Empty;
            datarowitem["C4"] = string.Empty;
            datarowitem["C5"] = string.Empty;
            datarowitem["OPER"] = BMS_Component.UserInfo.UserName;
            datarowitem["OP_DT"] = DateTimeOffset.Now;
        }

        void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            InvoiceDetailDV.Delete(gridView1.GetFocusedDataSourceRowIndex());
        }

        private void BindInvoiceDetail()
        {
            this.bindingSource1.DataSource = InvoiceDetailDV;
            this.bindingNavigator1.BindingSource = this.bindingSource1;
            this.gridControl1.DataSource = this.bindingSource1;
        }
    }
}
