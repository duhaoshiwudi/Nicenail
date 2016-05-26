using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace XiuWaiHuiZhong.Utility
{
    public class Config
    {
        public static string AppID
        {
            get { return ConfigurationManager.AppSettings["AppID"]; }
        }

        public static string AppID111
        {
            get { return ConfigurationManager.AppSettings["AppID"]; }
        }
    }
}
