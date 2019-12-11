﻿namespace SwedbankPay.Sdk.PaymentOrders
{
    public class PayeeInfo : IdLink
    {
        public PayeeInfo(string payeeId, string payeeReference, string payeeName = null, string productCategory = null, string subsite = null, string orderReference = null)
        {
            PayeeId = payeeId;
            PayeeReference = payeeReference;
            PayeeName = payeeName;
            ProductCategory = productCategory;
            Subsite = subsite;
            OrderReference = orderReference;
        }

        /// <summary>
        ///     This is the unique id that identifies this payee (like merchant) set by PayEx.
        /// </summary>
        public string PayeeId { get; }

        /// <summary>
        /// 	A unique reference, max 30 characters, set by the merchant system - this must be unique for each operation!
        ///     NOTE://PayEx may send either the transaction number OR the payeeReference as a reference to the acquirer. 
        ///     This will be used in reconciliation and reporting back to PayEx and you.
        ///     If PayEx sends the transaction number to the acquirer, then the payeeReference parameter may have the format of String(30).
        ///     If PayEx sends the payeeRef to the acquirer, the parameter is limited to the format of String(12) AND all characters must be digits/numbers.
        /// </summary>
        public string PayeeReference { get; }

        /// <summary>
        /// The name of the payee, usually the name of the merchant.
        /// </summary>

        public string PayeeName { get; }

        /// <summary>
        /// A product category or number sent in from the payee/merchant. This is not validated by PayEx, but will be passed through the payment process and may be used in the settlement process.9
        /// </summary>
        public string ProductCategory { get; }


        /// <summary>
        /// The subsite field can be used to perform split settlement on the payment. The subsites must be resolved with PayEx reconciliation before being used.
        /// </summary>
        public string Subsite { get; }

        /// <summary>
        /// The order reference should reflect the order reference found in the merchant's systems.
        /// </summary>
        public string OrderReference { get; }
    }
}