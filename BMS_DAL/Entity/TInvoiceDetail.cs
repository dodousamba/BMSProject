//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace BMS_DAL.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TInvoiceDetail
    {
        public int ID { get; set; }
        public string C1 { get; set; }
        public string C2 { get; set; }
        public string C3 { get; set; }
        public string C4 { get; set; }
        public string C5 { get; set; }
        public string OPER { get; set; }
        public System.DateTimeOffset OP_DT { get; set; }
        public int INVOICE_ID { get; set; }
        public decimal DEBIT { get; set; }
        public decimal CREDIT { get; set; }
    }
}
