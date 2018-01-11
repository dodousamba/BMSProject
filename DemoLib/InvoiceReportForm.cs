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
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            _instance = null;
        }
    }
}
