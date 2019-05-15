using System;
using System.Collections.Generic;
using System.Text;

namespace BuyLocal.DataAccess.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public bool IsSupplier { get; set; }
        public string UserType { get; set; }
        public bool? ConfirmPassword { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int CreatedUserId { get; set; }
        public int ModifiedUserId { get; set; }
    }
}
