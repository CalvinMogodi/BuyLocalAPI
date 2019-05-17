using BuyLocal.DataAccess.Entities;
using BuyLocal.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuyLocal.DataAccess.Repositories
{
    public class UserRepository : IUser
    {
        #region Properties
        /// <summary>
        /// database Context
        /// </summary>
        private readonly DatabaseContext _dbContext;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instanace of the <see cref="DataAccessRepository"/> class
        /// </summary>
        /// <param name="dbContext"></param>
        public UserRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        #endregion

        #region Methods

        public User Login(string password, string username) {
            return _dbContext.User.FirstOrDefault(u => u.Password == password && u.Username == username);           
        }

        public void CreateUser(User user)
        {
            _dbContext.User.Add(user);
            _dbContext.SaveChanges();
        }

        public User GetUserByUsername(string username)
        {
            return _dbContext.User.FirstOrDefault(u => u.Username.ToLower().Trim() == username.ToLower().Trim());
        }
        #endregion
    }
}
