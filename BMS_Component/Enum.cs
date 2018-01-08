using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS_Component
{
    public enum CPTYPE { VC = 1, TCT = 2, COA = 3 }

    public enum PAYER { OWR = 1, CHR = 2 }

    public enum PERIODS { A = 1, B = 2, C = 3, D = 4, E = 5, F = 6, G = 7, H = 8, I = 9, J = 10, FINAL = 11 }

    public enum FIXTURESTATUS { PROGRESS = 1, RECEIVABLE = 2, COMPLETE = 3 }

    public enum INVOICESTATUS { PROGRESS = 1, RECEIVABLE = 2, COMPLETE = 3 }

    public enum VSLSIZE { PMX = 1, SMX = 2, CAPE = 3 }
}
