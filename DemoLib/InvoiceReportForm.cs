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
    public partial class InvoiceReportForm : Form
    {
        private BMS_DAL.DS.BMSDS _bmsDS = new BMS_DAL.DS.BMSDS();
        private BMS_Service.DAService _daService = new BMS_Service.DAService();

        private static InvoiceReportForm _instance = null;
        public static InvoiceReportForm GetInstance(object args)
        {
            if (_instance == null)
            {
                _instance = new InvoiceReportForm();
            }
            _instance.Focus();
            return _instance;
        }
        public InvoiceReportForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.barEditItem_From.EditValue = DateTime.Now.AddMonths(-1);
            this.barEditItem_To.EditValue = DateTime.Now;

            this.AttachEvent();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            _instance = null;
        }

        private void AttachEvent()
        {
            this.barLargeButtonItem_Search.ItemClick += barLargeButtonItem_Search_ItemClick;
            this.barLargeButtonItem_TOEXCEL.ItemClick += barLargeButtonItem_TOEXCEL_ItemClick;
            this.saveFileDialog1.FileOk += saveFileDialog1_FileOk;
        }

        void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

            this.gridView1.ExportToXlsx(this.saveFileDialog1.FileName, new DevExpress.XtraPrinting.XlsxExportOptions(DevExpress.XtraPrinting.TextExportMode.Text));
        }

        void barLargeButtonItem_TOEXCEL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.saveFileDialog1.ShowDialog();
        }

        void barLargeButtonItem_Search_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _bmsDS.VFixture_Invoice.Clear();
            _bmsDS.VFixture_Invoice.Merge(_daService.GetFixture_InvoiceByCPDATE((DateTime)barEditItem_From.EditValue, (DateTime)barEditItem_To.EditValue));
            this.bindingSource1.DataSource = _bmsDS.VFixture_Invoice;
            this.gridControl1.DataSource = this.bindingSource1;
            this.gridView1.Columns["OWR"].GroupIndex = 0;
            this.gridView1.ExpandAllGroups();
        }
    }
}
