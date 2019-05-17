using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BuyLocal.BusinessLayer.Models
{
    [DataContract]
    public class Order
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int StoreId { get; set; }       
        [DataMember]
        public int OrderNumber { get; set; }
        [DataMember]
        public int TotalQuantity { get; set; }
        [DataMember]
        public string PickUpAddress { get; set; }
        [DataMember]
        public string DropAddress { get; set; }
        [DataMember]
        public string SupplierContactDeatils { get; set; }
        [DataMember]
        public string UserContactDeatils { get; set; }
        [DataMember]
        public string WayBill { get; set; }       
        [DataMember]
        public DateTime CreatedDate { get; set; }
        [DataMember]
        public DateTime ModifiedDate { get; set; }
        [DataMember]
        public int CreatedUserId { get; set; }
        [DataMember]
        public int ModifiedUserId { get; set; }
        [DataMember]
        public Store Store { get; set; }
        [DataMember]
        public List<Product> Products { get; set; }
        [DataMember]
        public User User { get; set; }
        [DataMember]
        public Courier Courier { get; set; }
        [DataMember]
        public Audit Audit { get; set; }
        [DataMember]
        public Transaction Transaction { get; set; }
    }
}
