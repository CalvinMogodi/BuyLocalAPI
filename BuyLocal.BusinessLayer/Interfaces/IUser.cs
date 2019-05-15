using BuyLocal.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuyLocal.BusinessLayer.Interfaces
{
    public interface IUser
    {
        User Login(string password, string username);

    }
}
