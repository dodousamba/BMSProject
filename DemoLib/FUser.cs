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
    public partial class FUser : Form
    {
        private static FUser _instance = null;
        public static FUser GetInstance(object args)
        {
            if (_instance == null)
            {
                _instance = new FUser();
            }
            _instance.Focus();
            return _instance;
        }
        private FUser()
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
