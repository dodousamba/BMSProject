using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS_DAL.DS.BMSDSTableAdapters
{
    public partial class TSys_UsersTableAdapter
    {
        public int UpdateWithTrans(BMS_DAL.DS.BMSDS.TSys_UsersDataTable dt)
        {
            int r = 0;
            using (System.Transactions.TransactionScope ts = new System.Transactions.TransactionScope())
            {
                try
                {
                    r = this.Adapter.Update(dt);
                    ts.Complete();
                }
                catch (Exception ex) { throw ex; }
            }
            return r;
        }
    }
    public partial class TFixturesTableAdapter
    {
        public int UpdateWithTrans(BMS_DAL.DS.BMSDS.TFixturesDataTable dt)
        {
            int r = 0;
            using (System.Transactions.TransactionScope ts = new System.Transactions.TransactionScope())
            {
                try
                {
                    r = this.Adapter.Update(dt);
                    ts.Complete();
                }
                catch (Exception ex) { throw ex; }
            }
            return r;
        }
    }
    public partial class TVesselsTableAdapter
    {
        public int UpdateWithTrans(BMS_DAL.DS.BMSDS.TVesselsDataTable dt)
        {
            int r = 0;
            using (System.Transactions.TransactionScope ts = new System.Transactions.TransactionScope())
            {
                try
                {
                    r = this.Adapter.Update(dt);
                    ts.Complete();
                }
                catch (Exception ex) { throw ex; }
            }
            return r;
        }
    }
    public partial class TInvoicesTableAdapter
    {
        public int UpdateWithTrans(BMS_DAL.DS.BMSDS.TInvoicesDataTable dt)
        {
            int r = 0;
            using (System.Transactions.TransactionScope ts = new System.Transactions.TransactionScope())
            {
                try
                {
                    r = this.Adapter.Update(dt);
                    ts.Complete();
                }
                catch (Exception ex) { throw ex; }
            }
            return r;
        }
    }
}
