using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BuyLocal.BusinessLayer.Models
{
    [DataContract]
    public class Product
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int StoreId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public bool StockIsAvailable { get; set; }
        [DataMember]
        public string Category { get; set; }
        [DataMember]
        public string RejectReason { get; set; }
        [DataMember]
        public bool IsActive { get; set; }
        [DataMember]
        public decimal Price { get; set; }
        [DataMember]
        public decimal Discount { get; set; }
        [DataMember]
        public bool IsOnSpecial { get; set; }
        [DataMember]
        public string ImageNameUrl { get; set; }
        [DataMember]
        public string ImageNameUrl1 { get; set; }
        [DataMember]
        public string ImageNameUrl2 { get; set; }
        [DataMember]
        public string ImageNameUrl3 { get; set; }
        [DataMember]
        public string Colors { get; set; }
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
