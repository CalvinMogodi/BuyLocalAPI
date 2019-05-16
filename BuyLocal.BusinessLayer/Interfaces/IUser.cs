using BuyLocal.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuyLocal.BusinessLayer.Interfaces
{
    public interface IUser
    {
        BuyLocalRespond Login(string password, string username);
        BuyLocalRespond CreateUser(User user);
        User GetUserByUsername(string username);

    }
}
