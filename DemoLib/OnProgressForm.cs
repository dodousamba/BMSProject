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
    public partial class OnProgressForm : Form
    {
        private static OnProgressForm _instance = null;
        public static OnProgressForm GetInstance(object args)
        {
            if (_instance == null)
            {
                _instance = new OnProgressForm();
            }
            _instance.Focus();
            return _instance;
        }
        private OnProgressForm()
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
