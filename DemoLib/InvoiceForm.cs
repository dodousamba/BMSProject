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

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
 
            _instance = null;
        }
    }
}
