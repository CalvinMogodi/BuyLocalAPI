using System;
using System.Collections.Generic;
using System.Text;

namespace BuyLocal.BusinessLayer.Models
{
    public class BuyLocalRespond
    {
        public bool IsSuccessful { get; set; }
        public string Error { get; set; }
        public object Respond { get; set; }
    }
}
