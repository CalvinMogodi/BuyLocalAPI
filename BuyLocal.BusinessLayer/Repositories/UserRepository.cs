using BuyLocal.BusinessLayer.Interfaces;
using BuyLocal.BusinessLayer.Models;
using BuyLocal.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuyLocal.BusinessLayer.Repositories
{
    public class UserRepository : IUser
    {
        #region Properties
        /// <summary>
        /// database Context
        /// </summary>
        private readonly DatabaseContext _context;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instanace of the <see cref="CommonRepository"/> class
        /// </summary>
        /// <param name="context"></param>
        /// <param name="_dataAccessRepository"></param>
        public UserRepository(DatabaseContext context) => _context = context;
        #endregion

        #region Methods
        public User Login(string password, string username)
        {
            DataAccess.Repositories.UserRepository dbUserRepository = new DataAccess.Repositories.UserRepository(_context);
            var dbUser = dbUserRepository.Login(password, username);
            User user = new User();
            if (user != null)
            {
                user.Id = dbUser.Id;
                user.Name = dbUser.Name;
                user.Surname = dbUser.Surname;
                user.Username = dbUser.Username;
                user.Password = dbUser.Password;
                user.Salt = dbUser.Salt;
                user.IsSupplier = dbUser.IsSupplier;
                user.UserType = dbUser.UserType;
                user.ConfirmPassword = dbUser.ConfirmPassword;
                user.CreatedDate = dbUser.CreatedDate;
                user.ModifiedDate = dbUser.ModifiedDate;
                user.CreatedUserId = dbUser.CreatedUserId;
                user.ModifiedUserId = dbUser.ModifiedUserId;
            }
            return user;
        }

        #endregion
    }
}
