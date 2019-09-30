﻿namespace SwedbankPay.Client.Resources
{
    using SwedbankPay.Client.Exceptions;
    using SwedbankPay.Client.Models;
    using SwedbankPay.Client.Models.Request;
    using SwedbankPay.Client.Models.Request.Transaction;
    using SwedbankPay.Client.Models.Response;
    using SwedbankPay.Client.Models.Vipps.TransactionAPI.Response;

    using System.Threading.Tasks;

    public interface IPaymentOrdersResource
    {
        /// <summary>
        /// Creates a payment order
        /// </summary>
        /// <param name="paymentOrderRequest"></param>
        /// <exception cref="CouldNotPlacePaymentOrderException"></exception>
        /// <returns></returns>
        Task<PaymentOrderResponseContainer> CreatePaymentOrder(PaymentOrderRequestContainer paymentOrderRequest, PaymentOrderExpand paymentOrderExpand = PaymentOrderExpand.None);

        /// <summary>
        /// Gets an existing payment order.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="paymentOrderExpand"></param>
        /// <exception cref="CouldNotFindPaymentException"></exception>
        /// <returns></returns>
        Task<PaymentOrderResponseContainer> GetPaymentOrder(string id, PaymentOrderExpand paymentOrderExpand = PaymentOrderExpand.None);

        /// <summary>
        /// Updates an existing payment.
        /// </summary>
        /// <param name="paymentOrderRequest"></param>
        /// <param name="id"></param>
        /// <exception cref="PaymentNotYetAuthorizedException"></exception>
        /// <exception cref="NoOperationsLeftException"></exception>
        /// <exception cref="CouldNotUpdatePaymentOrderException"></exception>
        /// <returns></returns>
        Task<PaymentOrderResponseContainer> UpdatePaymentOrder(string id, PaymentOrderRequestContainer paymentOrderRequest, PaymentOrderExpand paymentOrderExpand = PaymentOrderExpand.None);

        /// <summary>
        /// Aborts a payment
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<PaymentOrderResponseContainer> AbortPaymentOrder(string id);

        /// <summary>
        /// Captures a payment
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="requestObject"></param>
        /// <returns></returns>
        Task<TransactionResponse> Capture(string id, TransactionRequestContainer requestObject);

        /// <summary>
        /// Reverses a payment
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestObject"></param>
        /// <returns></returns>
        Task<TransactionResponse> Reversal(string id, TransactionRequestContainer requestObject);

        /// <summary>
        /// Cancels a payment
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestObject"></param>
        /// <returns></returns>
        Task<TransactionResponse> CancelPaymentOrder(string id, TransactionRequestContainer requestObject);
    }
}