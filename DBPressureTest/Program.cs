using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DBPressureTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int threadcount = 10;
            for (int i = 0; i < threadcount; i++)
            {
                Thread t = new Thread(new ParameterizedThreadStart(GetData));
                t.Start(i);
            }
            System.Console.Read();
        }

        static void GetData(object arg)
        {
            using (BMS_DAL.DS.BMSDSTableAdapters.TVesselsTableAdapter ta = new BMS_DAL.DS.BMSDSTableAdapters.TVesselsTableAdapter())
            {
                System.Diagnostics.Stopwatch stopWatch = new System.Diagnostics.Stopwatch();
                stopWatch.Start();
                string r = string.Empty;
                try
                {
                    var dt = ta.GetData();
                    r = string.Format("rows{0}", dt.Count);
                }
                catch (Exception ex) { r = ex.Message; }
                stopWatch.Stop();
                System.Console.WriteLine(string.Format("T:{0} {1} {2}", arg, r, stopWatch.ElapsedMilliseconds));
            }
        }
    }
}
