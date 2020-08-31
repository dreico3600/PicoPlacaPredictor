using PicoPlacaPredictor.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PicoPlacaPredictor.Models
{
    [BindableType(IsBindable = true)]
    public class InputDataFieldsModel
    {
        /// <summary>
        /// Car number plate of vehicle
        /// </summary>
        [Display(Name = "Car Plate")]
        [Required(ErrorMessage = "The car plate is required")]
        [RegularExpression(@"^[A-Z,a-z]{3}-[0-9]{4}$",
            ErrorMessage = "Please enter a date valid car plate in format: AAA-0000")]
        public string CarPlate { get; set; }

        /// <summary>
        /// Date of travel, we find the weekday name
        /// </summary>
        [Display(Name = "Date")]
        [Required(ErrorMessage = "The date field is required")]
        [RegularExpression(@"^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[13-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$",
            ErrorMessage = "Please enter a date valid in format dd/mm/yyyy, ex: 31/12/2020")]
        public string DateTravel { get; set; }

        /// <summary>
        /// Hour of travel in 24h format
        /// </summary>
        [Display(Name = "Time")]
        [Required(ErrorMessage = "The time field is required")]
        [RegularExpression(@"^(0[0-9]|1[0-9]|2[0-3]):[0-5][0-9]$",
            ErrorMessage = "Please enter a time valid in format hh:mm, ex: 14:32")]
        [DateTimeTravel(ErrorMessage = "The combined date and time fields must be after current")]
        public string TimeTravel { get; set; }
    }
}