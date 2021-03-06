﻿using CashWithdrawal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashWithdrawal.Entities
{
    public interface ICashWithdrawalRepository
    {
        Task<FundsTransferResponse> CashWithdrawal(CashWithdrawalRequest request);
        CashWithdrawalRequest GetCashWithdrawalRequest(Request r);
        bool isDuplicateID(string idString);
        string EncData(string value);
        Models.Response GetFTResponse(FundsTransferResponse r);
    }
}
