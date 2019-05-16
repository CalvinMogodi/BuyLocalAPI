using System;
using System.Collections.Generic;
using System.Text;

namespace BuyLocal.DataAccess.Entities
{
    public class Error
    {
        public int Id { get; set; }
        public string StackTrace { get; set; }
        public string Message { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedUserId { get; set; }
    }
}
