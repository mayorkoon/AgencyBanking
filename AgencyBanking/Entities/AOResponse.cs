﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgencyBanking.Entities
{
    public class AOResponse
    {
        //public string CUSTOMER_NO { get; set; }
        //public string ACCOUNT_NO { get; set; }
        //public string CUSTOMER_NAME { get; set; }
        //public string BRANCH_CODE { get; set; }
        public string customerNumber { get; set; }
        public string accountNumber { get; set; }
        public string customerName { get; set; }
        public string branchCode { get; set; }
        public string message { get; set; }
    }
}
