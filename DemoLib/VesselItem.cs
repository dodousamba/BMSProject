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
    public partial class VesselItem : Form
    {
        public BMS_DAL.DS.BMSDS.TVesselsRow DataRowItem { get; set; }
        public VesselItem()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            foreach(var item in BMS_Component.StaticMethods.GetEnumDict(typeof(BMS_Component.VSLSIZE)).ToList())
            {
                this.comboBoxEdit1.Properties.Items.Add(item.Value);
            }

            this.textEdit1.DataBindings.Add(new Binding("EditValue", DataRowItem, "NAME", false, DataSourceUpdateMode.OnPropertyChanged));
            this.comboBoxEdit1.DataBindings.Add(new Binding("EditValue", DataRowItem, "SIZE", false, DataSourceUpdateMode.OnPropertyChanged));
            this.memoEdit1.DataBindings.Add(new Binding("EditValue", DataRowItem, "DESC", false, DataSourceUpdateMode.OnPropertyChanged));

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
