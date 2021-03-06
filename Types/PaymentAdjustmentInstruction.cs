﻿using System;
using System.Runtime.Serialization;

namespace MemberSuite.SDK.Types
{
    [Serializable]
    [DataContract]
    public class PaymentAdjustmentInstruction
    {
        [DataMember]
        public string PaymentLineItemID { get; set; }

        [DataMember]
        public string PaymentID { get; set; }

        [DataMember]
        public InvoiceAdjustmentPaymentAction PaymentAction { get; set; }

        [DataMember]
        public decimal Amount { get; set; }
    }
}