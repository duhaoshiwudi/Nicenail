﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XiuWaiHuiZhong.UI.Models
{
    public class GetUserInfoListIn
    {
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public int RoleType { get; set; }
        public string KeyWords { get; set; }
    }
}
