using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BuyLocal.BusinessLayer.Models
{
    [DataContract]
    public class OrderTracking
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public bool PenddingPayment { get; set; }
        [DataMember]
        public DateTime PenddingPaymentDate { get; set; }
        [DataMember]
        public bool PaymentComplete { get; set; }
        [DataMember]
        public DateTime PaymentCompleteDate { get; set; }
        [DataMember]
        public bool SupplierIsPreparing { get; set; }
        [DataMember]
        public DateTime SupplierIsPreparingDate { get; set; }
        [DataMember]
        public bool SupplierComplete { get; set; }
        [DataMember]
        public DateTime SupplierCompleteDate { get; set; }
        [DataMember]
        public bool WaitingForCourier { get; set; }
        [DataMember]
        public DateTime WaitingForCourierDate { get; set; }
        [DataMember]
        public bool WithCourier { get; set; }
        [DataMember]
        public DateTime WithCourierDate { get; set; }
        [DataMember]
        public bool Complete { get; set; }
        [DataMember]
        public DateTime CompleteDate { get; set; }
        [DataMember]
        public DateTime CreatedDate { get; set; }
        [DataMember]
        public DateTime ModifiedDate { get; set; }
        [DataMember]
        public int CreatedUserId { get; set; }
        [DataMember]
        public int ModifiedUserId { get; set; }
    }
}
