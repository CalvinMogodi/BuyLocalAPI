using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BuyLocal.BusinessLayer.Models
{
    [DataContract]
    public class Courier
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string ContactDetails { get; set; }
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
