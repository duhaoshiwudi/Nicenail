using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XiuWaiHuiZhong.UI.Models
{
    public class GetConsumerInfoListIn
    {
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public string KeyWords { get; set; }
    }
}