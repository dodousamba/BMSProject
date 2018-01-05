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
    public partial class FOnProgress : Form
    {
        private static FOnProgress _instance = null;
        public static FOnProgress GetInstance(object args)
        {
            if (_instance == null)
            {
                _instance = new FOnProgress();
            }
            _instance.Focus();
            return _instance;
        }
        private FOnProgress()
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
