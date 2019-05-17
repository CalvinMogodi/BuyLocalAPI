using BuyLocal.BusinessLayer.Helpers;
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
        public BuyLocalRespond Login(string password, string username)
        {
            BuyLocalRespond buyLocalRespond = new BuyLocalRespond();
            DataAccess.Repositories.ErrorRepository errorLogger = new DataAccess.Repositories.ErrorRepository(_context);
            try
            {
                DataAccess.Repositories.UserRepository dbUserRepository = new DataAccess.Repositories.UserRepository(_context);                
                var dbUser = dbUserRepository.GetUserByUsername(username);

                PasswordEnDecryption passwordEnDecryption = new PasswordEnDecryption();
                if (dbUser != null)
                {
                    bool areEqual = passwordEnDecryption.AreEqual(password, dbUser.Password, dbUser.Salt);
                    if (areEqual)
                    {
                        User user = new User();
                        user = user.ConvertdbUserToUser(dbUser);
                        buyLocalRespond.Respond = user;
                    }
                    else
                    {
                        buyLocalRespond.Respond = null;
                        buyLocalRespond.Error = "Invalid username or password";
                    }
                }
                else {
                    buyLocalRespond.Respond = null;
                    buyLocalRespond.Error = "This user doesn't exists";
                }
                
                buyLocalRespond.IsSuccessful = true;                
                
            }
            catch (Exception ex)
            {
                errorLogger.LogError(ex);
                buyLocalRespond.IsSuccessful = false;
                buyLocalRespond.Error = "Unable to log user in";
                buyLocalRespond.Respond = null;
            }

            return buyLocalRespond;
        }

        public BuyLocalRespond CreateUser(User user)
        {
            BuyLocalRespond buyLocalRespond = new BuyLocalRespond();
            DataAccess.Repositories.ErrorRepository errorLogger = new DataAccess.Repositories.ErrorRepository(_context);
            try
            {
                DataAccess.Repositories.UserRepository dbUserRepository = new DataAccess.Repositories.UserRepository(_context);
               
                var checkUserInDB = dbUserRepository.GetUserByUsername(user.Username);
                if (checkUserInDB != null)
                {
                    buyLocalRespond.IsSuccessful = true;
                    buyLocalRespond.Error = "User with this username already exists";
                    buyLocalRespond.Respond = null;
                }
                else {
                    PasswordEnDecryption passwordEnDecryption = new PasswordEnDecryption();
                    user.Salt = passwordEnDecryption.CreateSalt(user.Username.Length);
                    user.Password = passwordEnDecryption.GenerateHash(user.Password , user.Salt);
                    var dbUser = user.ConvertUserTodbUser(user);
                    dbUserRepository.CreateUser(dbUser);
                    var newUser = GetUserByUsername(user.Username);
                    buyLocalRespond.IsSuccessful = true;
                    buyLocalRespond.Respond = newUser;
                }    
            }
            catch (Exception ex)
            {
                errorLogger.LogError(ex);
                buyLocalRespond.IsSuccessful = false;
                buyLocalRespond.Error = "Unable to register user";
                buyLocalRespond.Respond = null;
            }
           
            return buyLocalRespond;
        }

        public User GetUserByUsername(string username)
        {
            DataAccess.Repositories.UserRepository dbUserRepository = new DataAccess.Repositories.UserRepository(_context);
            var dbUser = dbUserRepository.GetUserByUsername(username);
            User user = new User();

            if (dbUser != null)
                user = user.ConvertdbUserToUser(dbUser);
            return user;
        }

        #endregion
    }
}
