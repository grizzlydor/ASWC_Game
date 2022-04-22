using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ASWC_Game
{
    public class ReadConfiguration
    {
        public static int MinWorldSize { get; private set; }
        public static int MaxWorldSize { get; private set; }

        static string ConfigFilePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName + "/ASWC_Game/Config.xml";
        public static void ReadConfig()
        {
            XmlDocument configDoc = new XmlDocument();
            configDoc.Load(ConfigFilePath);

            XmlNode minWorldSize = configDoc.DocumentElement.SelectSingleNode("MinWorldSize");
            if(minWorldSize != null)
            {
                string str = minWorldSize.InnerText.Trim();
                MinWorldSize = Convert.ToInt32(str);
            }

            XmlNode maxWorldSize = configDoc.DocumentElement.SelectSingleNode("MaxWorldSize");
            if(maxWorldSize != null)
            {
                string str = maxWorldSize.InnerText.Trim();
                MaxWorldSize = Convert.ToInt32(str);
            }
        }
    }
}
