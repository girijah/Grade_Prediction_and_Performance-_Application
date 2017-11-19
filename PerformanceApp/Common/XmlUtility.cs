using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PerformanceApp.Common
{
    public class XmlUtility
    {
        public static string SerializeToXml(Object serialize)
        {
            XmlSerializer requestObject = new XmlSerializer(serialize.GetType());

            using (StringWriter requestStream = new StringWriter())
            {
                if (serialize != null)
                {
                    requestObject.Serialize(requestStream, serialize);
                }
                return requestStream.ToString();
            }
        }


        public static T DeserializeFromXml<T>(string xml)
        {
            T resultObj = default(T);

            XmlSerializer requestObject = new XmlSerializer(typeof(T));

            using (StringReader reader = new StringReader(xml))
            {
                if (reader != null)
                {
                    resultObj = (T)requestObject.Deserialize(reader);
                }
            }
            return resultObj;
        }
    }
}
