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
        public BMS_DAL.DS.BMSDS.TFixturesRow DataRowItem { get; set; }
        private BMS_Service.DAService _service = new BMS_Service.DAService();
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

            this.searchLookUpEdit_VSL.DataBindings.Add(new Binding("EditValue", DataRowItem, "VSL_ID", false, DataSourceUpdateMode.OnPropertyChanged));
            this.dateEdit_CPDATE.DataBindings.Add(new Binding("EditValue", DataRowItem, "CP_DATE", false, DataSourceUpdateMode.OnPropertyChanged));
            this.comboBoxEdit_CPTYPE.DataBindings.Add(new Binding("EditValue", DataRowItem, "CP_TYPE", false, DataSourceUpdateMode.OnPropertyChanged));
            this.comboBoxEdit_PAYER.DataBindings.Add(new Binding("EditValue", DataRowItem, "PAYER", false, DataSourceUpdateMode.OnPropertyChanged));
            this.textEdit_FIXNO.DataBindings.Add(new Binding("EditValue", DataRowItem, "FIXNO", false, DataSourceUpdateMode.OnPropertyChanged));
            this.memoEdit_CPDESC.DataBindings.Add(new Binding("EditValue", DataRowItem, "CP_DESC", false, DataSourceUpdateMode.OnPropertyChanged));
            this.textEdit_HRORFRT.DataBindings.Add(new Binding("EditValue", DataRowItem, "HRORFRT", false, DataSourceUpdateMode.OnPropertyChanged));
            this.textEdit_DAYSORMT.DataBindings.Add(new Binding("EditValue", DataRowItem, "DAYSORMT", false, DataSourceUpdateMode.OnPropertyChanged));
            this.textEdit_ESTBRK.DataBindings.Add(new Binding("EditValue", DataRowItem, "ESTBRK", false, DataSourceUpdateMode.OnPropertyChanged));
            this.searchLookUpEdit_OWR.DataBindings.Add(new Binding("EditValue", DataRowItem, "OWR", false, DataSourceUpdateMode.OnPropertyChanged));
            this.textEdit_OWRRATE.DataBindings.Add(new Binding("EditValue", DataRowItem, "BRKRATE_OWR", false, DataSourceUpdateMode.OnPropertyChanged));
            this.textEdit_OWRAMOUNT.DataBindings.Add(new Binding("EditValue", DataRowItem, "BRKAMOUNT_OWR", false, DataSourceUpdateMode.OnPropertyChanged));
            this.searchLookUpEdit_CHR.DataBindings.Add(new Binding("EditValue", DataRowItem, "CHR", false, DataSourceUpdateMode.OnPropertyChanged));
            this.textEdit_CHRRATE.DataBindings.Add(new Binding("EditValue", DataRowItem, "BRKRATE_CHR", false, DataSourceUpdateMode.OnPropertyChanged));
            this.textEdit_CHRAMOUNT.DataBindings.Add(new Binding("EditValue", DataRowItem, "BRKAMOUNT_CHR", false, DataSourceUpdateMode.OnPropertyChanged));
            this.searchLookUpEdit_BROKER1.DataBindings.Add(new Binding("EditValue", DataRowItem, "BROKER1", false, DataSourceUpdateMode.OnPropertyChanged));
            this.searchLookUpEdit_BROKER2.DataBindings.Add(new Binding("EditValue", DataRowItem, "BROKER2", false, DataSourceUpdateMode.OnPropertyChanged));
            this.searchLookUpEdit_SIGNOP.DataBindings.Add(new Binding("EditValue", DataRowItem, "SIGNOPER", false, DataSourceUpdateMode.OnPropertyChanged));
            this.textEdit_TFCB.DataBindings.Add(new Binding("EditValue", DataRowItem, "TFCB", false, DataSourceUpdateMode.OnPropertyChanged));
            this.memoEdit_FIXTUREREMARK.DataBindings.Add(new Binding("EditValue", DataRowItem, "REMARK", false, DataSourceUpdateMode.OnPropertyChanged));
            this.textEdit_CAPRATE.DataBindings.Add(new Binding("EditValue", DataRowItem, "CAP_RATE", false, DataSourceUpdateMode.OnPropertyChanged));
            this.textEdit_CAPAMOUNT.DataBindings.Add(new Binding("EditValue", DataRowItem, "CAP_AMOUNT", false, DataSourceUpdateMode.OnPropertyChanged));

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
        }         
    }
}
