using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RecordStore.Models
{
    public class NotInFutureAttribute : ValidationAttribute
    {
        public NotInFutureAttribute(string errorMessage) : base(errorMessage)
        {
        }

        public override bool IsValid(object value)
        {
            var date = (DateTime)value;
            if (date > DateTime.Now)
                return false;

            return true;
        }
    }
}