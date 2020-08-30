using PicoPlacaPredictor.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PicoPlacaPredictor.Common
{
    public class DateTimeTravelAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            ValidationResult result = null;

            object instance = validationContext.ObjectInstance;

            InputDataFieldsModel obj = (InputDataFieldsModel)validationContext.ObjectInstance;

            var convertedDateTime = Convert.ToDateTime(obj.DateTravel + " " + obj.TimeTravel);
            if (convertedDateTime <= DateTime.Now)
                result = new ValidationResult("The combined date and time fields must be after current");
            return result;
        }

        //public override bool IsValid(object value)
        //{
        //    bool flag = false;
        //    InputDataFieldsModel obj = (InputDataFieldsModel)value;
        //    var convertedDateTime = Convert.ToDateTime(obj.DateTravel + " " + obj.TimeTravel);
        //    if (convertedDateTime > DateTime.Now)
        //        flag = true;
        //    return flag;
        //}
    }
}