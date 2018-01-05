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
    public partial class FInvoice : Form
    {
        private static FInvoice _instance = null;
        public static FInvoice GetInstance(object args)
        {
            if (_instance == null)
            {
                _instance = new FInvoice();
            }
            _instance.Focus();
            return _instance;
        }

        private FInvoice()
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
