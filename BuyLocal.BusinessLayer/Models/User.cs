using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BuyLocal.BusinessLayer.Models
{
    [DataContract]
    public class User
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Surname { get; set; }
        [DataMember]
        public string Username { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string Salt { get; set; }
        [DataMember]
        public bool IsSupplier { get; set; }
        [DataMember]
        public string UserType { get; set; }
        [DataMember]
        public bool? ConfirmPassword { get; set; }
        [DataMember]
        public DateTime CreatedDate { get; set; }
        [DataMember]
        public DateTime ModifiedDate { get; set; }
        [DataMember]
        public int CreatedUserId { get; set; }
        [DataMember]
        public int ModifiedUserId { get; set; }

        public DataAccess.Entities.User ConvertUserTodbUser(User user) {
            return new DataAccess.Entities.User()
            {
                Id = user.Id,
                Name = user.Name,
                Surname = user.Surname,
                Username = user.Username,
                IsSupplier = user.IsSupplier,
                UserType = user.UserType,
                ConfirmPassword = user.ConfirmPassword,
                CreatedDate = user.CreatedDate,
                ModifiedDate = user.ModifiedDate,
                CreatedUserId = user.CreatedUserId,
                ModifiedUserId = user.ModifiedUserId,
                Password = user.Password,
                Salt = user.Salt,
            };
        }

        public User ConvertdbUserToUser(DataAccess.Entities.User user)
        {
            return new User()
            {
                Id = user.Id,
                Name = user.Name,
                Surname = user.Surname,
                Username = user.Username,
                IsSupplier = user.IsSupplier,
                UserType = user.UserType,
                ConfirmPassword = user.ConfirmPassword,
                CreatedDate = user.CreatedDate,
                ModifiedDate = user.ModifiedDate,
                CreatedUserId = user.CreatedUserId,
                ModifiedUserId = user.ModifiedUserId,
            };
        }
    }
}
