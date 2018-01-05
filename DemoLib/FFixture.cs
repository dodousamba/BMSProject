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
    public partial class FFixture : Form
    {
        private static FFixture _instance = null;
        public static FFixture GetInstance(object args)
        {
            if (_instance == null)
            {
                _instance = new FFixture();
            }
            _instance.Focus();
            return _instance;
        }

        private FFixture()
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
