using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

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
    }
}
