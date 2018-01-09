using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace BMS_Service
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“DAService”。
    public class DAService : IDAService
    {
        public BMS_DAL.DS.BMSDS.TVesselsDataTable GetVessel()
        {
            using (BMS_DAL.DS.BMSDSTableAdapters.TVesselsTableAdapter ta = new BMS_DAL.DS.BMSDSTableAdapters.TVesselsTableAdapter())
            {
                try
                {
                    return ta.GetData();
                }
                catch (Exception ex) { throw ex; }
            }
        }

        public int UpdateVessel(BMS_DAL.DS.BMSDS.TVesselsDataTable dt)
        {
            int r = 0;
            if (dt.GetChanges() != null)
            {
                using (BMS_DAL.DS.BMSDSTableAdapters.TVesselsTableAdapter ta = new BMS_DAL.DS.BMSDSTableAdapters.TVesselsTableAdapter())
                {
                    r = ta.UpdateWithTrans(dt);
                }
            }
            return r;
        }


        public BMS_DAL.DS.BMSDS.TFixturesDataTable GetFixture()
        {
            using (BMS_DAL.DS.BMSDSTableAdapters.TFixturesTableAdapter ta = new BMS_DAL.DS.BMSDSTableAdapters.TFixturesTableAdapter())
            {
                try
                {
                    return ta.GetData();
                }
                catch (Exception ex) { throw ex; }
            }
        }

        public int UpdateFixture(BMS_DAL.DS.BMSDS.TFixturesDataTable dt)
        {
            int r = 0;
            if (dt.GetChanges() != null)
            {
                using (BMS_DAL.DS.BMSDSTableAdapters.TFixturesTableAdapter ta = new BMS_DAL.DS.BMSDSTableAdapters.TFixturesTableAdapter())
                {
                    r = ta.UpdateWithTrans(dt);
                }
            }
            return r;
        }

        public BMS_DAL.DS.BMSDS GetFixtureWithRelation()
        {
            BMS_DAL.DS.BMSDS ds = new BMS_DAL.DS.BMSDS();
            using (BMS_DAL.DS.BMSDSTableAdapters.TFixturesTableAdapter ta = new BMS_DAL.DS.BMSDSTableAdapters.TFixturesTableAdapter())
            {
                try
                {
                    ds.TFixtures.Merge(ta.GetData());
                }
                catch (Exception ex) { throw ex; }
            }
            using (BMS_DAL.DS.BMSDSTableAdapters.TInvoicesTableAdapter ta = new BMS_DAL.DS.BMSDSTableAdapters.TInvoicesTableAdapter())
            {
                try
                {
                    ds.TInvoices.Merge(ta.GetData());
                }
                catch (Exception ex) { throw ex; }
            }
            using (BMS_DAL.DS.BMSDSTableAdapters.TInvoiceDetailsTableAdapter ta = new BMS_DAL.DS.BMSDSTableAdapters.TInvoiceDetailsTableAdapter())
            {
                try
                {
                    ds.TInvoiceDetails.Merge(ta.GetData());
                }
                catch (Exception ex) { throw ex; }
            }
            return ds;
        }

        public int UpdateFixtureWithRelation(BMS_DAL.DS.BMSDS ds)
        {
            int r = 0;

            var dschanges = ds.GetChanges();
            using (BMS_DAL.DS.BMSDSTableAdapters.TFixturesTableAdapter ta = new BMS_DAL.DS.BMSDSTableAdapters.TFixturesTableAdapter())
            {
                r += ta.UpdateWithTrans((BMS_DAL.DS.BMSDS.TFixturesDataTable)dschanges.Tables["TFixtures"]);
            }
            using (BMS_DAL.DS.BMSDSTableAdapters.TInvoicesTableAdapter ta = new BMS_DAL.DS.BMSDSTableAdapters.TInvoicesTableAdapter())
            {
                r += ta.UpdateWithTrans((BMS_DAL.DS.BMSDS.TInvoicesDataTable)dschanges.Tables["TInvoices"]);
            }
            foreach (DataRow idrow in dschanges.Tables["TInvoiceDetails"].Rows)
            {
                if (idrow.RowState.Equals(DataRowState.Deleted))
                {
                    continue;
                }
                if ((int)idrow["ID"] < 0)
                {
                    idrow.SetAdded();
                }
                else
                {
                    idrow.SetModified();
                }
            }
            using (BMS_DAL.DS.BMSDSTableAdapters.TInvoiceDetailsTableAdapter ta = new BMS_DAL.DS.BMSDSTableAdapters.TInvoiceDetailsTableAdapter())
            {
                r += ta.UpdateWithTrans((BMS_DAL.DS.BMSDS.TInvoiceDetailsDataTable)dschanges.Tables["TInvoiceDetails"]);
            }

            return r;
        }
        public int DeleteFixtureWithRelation(BMS_DAL.DS.BMSDS ds)
        {
            int r = 0;

            if (ds.TInvoiceDetails.GetChanges() != null)
            {
                using (BMS_DAL.DS.BMSDSTableAdapters.TInvoiceDetailsTableAdapter ta = new BMS_DAL.DS.BMSDSTableAdapters.TInvoiceDetailsTableAdapter())
                {
                    r += ta.UpdateWithTrans(ds.TInvoiceDetails);
                }
            }
            if (ds.TInvoices.GetChanges() != null)
            {
                using (BMS_DAL.DS.BMSDSTableAdapters.TInvoicesTableAdapter ta = new BMS_DAL.DS.BMSDSTableAdapters.TInvoicesTableAdapter())
                {
                    r += ta.UpdateWithTrans(ds.TInvoices);
                }
            }
            if (ds.TFixtures.GetChanges() != null)
            {
                using (BMS_DAL.DS.BMSDSTableAdapters.TFixturesTableAdapter ta = new BMS_DAL.DS.BMSDSTableAdapters.TFixturesTableAdapter())
                {
                    r += ta.UpdateWithTrans(ds.TFixtures);
                }
            }
    
            return r;
        }


        public BMS_DAL.DS.BMSDS.TInvoicesDataTable GetInvoice()
        {
            using (BMS_DAL.DS.BMSDSTableAdapters.TInvoicesTableAdapter ta = new BMS_DAL.DS.BMSDSTableAdapters.TInvoicesTableAdapter())
            {
                try
                {
                    return ta.GetData();
                }
                catch (Exception ex) { throw ex; }
            }
        }

        public int UpdateInvoice(BMS_DAL.DS.BMSDS.TInvoicesDataTable dt)
        {
            int r = 0;
            if (dt.GetChanges() != null)
            {
                using (BMS_DAL.DS.BMSDSTableAdapters.TInvoicesTableAdapter ta = new BMS_DAL.DS.BMSDSTableAdapters.TInvoicesTableAdapter())
                {
                    r = ta.UpdateWithTrans(dt);
                }
            }
            return r;
        }


        public BMS_DAL.DS.BMSDS.TInvoiceDetailsDataTable GetInvoiceDetail()
        {
            using (BMS_DAL.DS.BMSDSTableAdapters.TInvoiceDetailsTableAdapter ta = new BMS_DAL.DS.BMSDSTableAdapters.TInvoiceDetailsTableAdapter())
            {
                try
                {
                    return ta.GetData();
                }
                catch (Exception ex) { throw ex; }
            }
        }

        public int UpdateInvoiceDetail(BMS_DAL.DS.BMSDS.TInvoiceDetailsDataTable dt)
        {
            int r = 0;
            if (dt.GetChanges() != null)
            {
                using (BMS_DAL.DS.BMSDSTableAdapters.TInvoiceDetailsTableAdapter ta = new BMS_DAL.DS.BMSDSTableAdapters.TInvoiceDetailsTableAdapter())
                {
                    r = ta.UpdateWithTrans(dt);
                }
            }
            return r;
        }
    }
}
