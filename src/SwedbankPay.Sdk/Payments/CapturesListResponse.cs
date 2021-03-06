﻿using System;
using System.Collections.Generic;

namespace SwedbankPay.Sdk.Payments
{
    public class CapturesListResponse : IdLink
    {
        public CapturesListResponse(Uri id, List<TransactionResponse> captureList)
        {
            Id = id;
            CaptureList = captureList;
        }


        public List<TransactionResponse> CaptureList { get; }
    }
}