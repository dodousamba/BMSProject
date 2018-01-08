using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS_Component
{
    public enum CPTYPE { VC = 1, TCT = 2, COA = 3 }

    public enum PAYER { OWR = 1, CHR = 2 }

    public enum FIXTURESTATUS { PROGRESS = 1, RECEIVABLE = 2, COMPLETE = 3 }

    public enum INVOICESTATUS { PROGRESS = 1, RECEIVABLE = 2, COMPLETE = 3 }

    public enum VSLSIZE { PMX = 1, SMX = 2, CAPE = 3 }
}
