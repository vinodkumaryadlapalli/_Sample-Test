using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Test_2022F.Attributes
{
    public class ValidISBN : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null) return ValidationResult.Success;
            string valueStr = value.ToString();
            char[] valueArr = valueStr.ToCharArray();
            bool onlyDigits = valueArr.All(x => Char.IsDigit(x));
            bool goodLength = valueArr.Length == 9 || valueArr.Length == 10 || valueArr.Length == 13;
            if (onlyDigits && goodLength) return ValidationResult.Success;
            else return new ValidationResult("Must be 9, 10 or 13 digits. No letters or other characters.");
        }
    }
}