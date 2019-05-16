using BuyLocal.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuyLocal.DataAccess.Interfaces
{
    public interface IUser
    {
        User Login(string password, string username);
        void CreateUser(User user);
        User GetUserByUsername(string username);
    }
}
