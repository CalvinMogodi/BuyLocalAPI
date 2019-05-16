using BuyLocal.DataAccess.Entities;
using BuyLocal.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuyLocal.DataAccess.Repositories
{
    public class ErrorRepository : IError
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
        public ErrorRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        #endregion

        #region Methods

        public void LogError(Exception exception)
        {
            Error error = new Error() {
                    StackTrace = exception.StackTrace,
                    Message = exception.Message,
                    CreatedDate = DateTime.Now,
                    CreatedUserId = 0
                };
            _dbContext.Error.Add(error);
            _dbContext.SaveChanges();
        }

        #endregion
    }
}
