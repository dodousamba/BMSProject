using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BMS_Service
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IDAService”。
    [ServiceContract]
    public interface IDAService
    {
        [OperationContract]
        BMS_DAL.DS.BMSDS.TVesselsDataTable GetVessel();

        [OperationContract]
        int UpdateVessel(BMS_DAL.DS.BMSDS.TVesselsDataTable dt);

        [OperationContract]
        BMS_DAL.DS.BMSDS.TFixturesDataTable GetFixture();

        [OperationContract]
        int UpdateFixture(BMS_DAL.DS.BMSDS.TFixturesDataTable dt);

        [OperationContract]
        BMS_DAL.DS.BMSDS GetFixtureWithRelation();

        [OperationContract]
        int UpdateFixtureWithRelation(BMS_DAL.DS.BMSDS ds);

        [OperationContract]
        int DeleteFixtureWithRelation(BMS_DAL.DS.BMSDS ds);

        [OperationContract]
        BMS_DAL.DS.BMSDS.TInvoicesDataTable GetInvoice();

        [OperationContract]
        int UpdateInvoice(BMS_DAL.DS.BMSDS.TInvoicesDataTable dt);

        [OperationContract]
        BMS_DAL.DS.BMSDS.TInvoiceDetailsDataTable GetInvoiceDetail();

        [OperationContract]
        int UpdateInvoiceDetail(BMS_DAL.DS.BMSDS.TInvoiceDetailsDataTable dt);

        [OperationContract]
        int UpdateDS(BMS_DAL.DS.BMSDS ds);
    }
}
