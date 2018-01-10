using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace DemoLib.RPT
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport1(BMS_DAL.DS.BMSDS ds, int invoiceid)
        {
            InitializeComponent();

            this.bmsds1.Merge(ds);

            INVOICE_ID.Visible = false;
            INVOICE_ID.Value = invoiceid;

            List<DevExpress.XtraReports.Parameters.ParameterInfo> parainfoL = new List<DevExpress.XtraReports.Parameters.ParameterInfo>();
            parainfoL.Add(new DevExpress.XtraReports.Parameters.ParameterInfo(INVOICE_ID, new System.Windows.Forms.Control()));
            this.RaiseParametersRequestSubmit(parainfoL, true);
        }

        private void XtraReport1_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
        }


    }
}
