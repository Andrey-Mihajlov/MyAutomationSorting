﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationSorting.Model
{
    public class SLPDataModel
    {
        public string SLP { get; set; }
        public long CompanyProductID { get; set; }
        public string UPC { get; set; }
        public bool CheckedIn { get; set; }
    }
}
