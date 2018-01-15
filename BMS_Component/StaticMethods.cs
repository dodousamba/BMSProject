using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace BMS_Component
{
    public class StaticMethods
    {
        public static Dictionary<int, object> GetEnumDict(Type enumType)
        {
            var dic = new Dictionary<int, object>();
            try
            {
                var fd = enumType.GetFields();
                for (var index = 1; index < fd.Length; ++index)
                {
                    var info = fd[index];
                    var fieldValue = System.Enum.Parse(enumType, fd[index].Name);
                    var key = (int)fieldValue;
                    dic.Add(key, fieldValue);
                }
                return dic;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static DateTimeOffset GetServerDate(string urlstring)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(urlstring);
            request.MediaType = "GET";
            using (WebResponse respones = request.GetResponse())
            {
                DateTimeOffset r = DateTimeOffset.Parse(respones.Headers["DATE"]);
                return r;
            }
        }
    }
}
