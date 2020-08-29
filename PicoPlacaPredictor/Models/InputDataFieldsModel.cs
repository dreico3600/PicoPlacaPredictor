using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PicoPlacaPredictor.Models
{
    public class InputDataFieldsModel
    {
        [Display(Name = "Car Plate")]
        [Required(ErrorMessage = "Please enter a date valid car plate in format: AAA-0000")]
        [RegularExpression(@"^[A-Z,a-z]{3}-[0-9]{4}$")]
        public string CarPlate { get; set; }
        [Display(Name = "Date")]
        [Required(ErrorMessage = "Please enter a date valid in format dd/mm/yyyy, ex: 31/12/2020")]
        [RegularExpression(@"^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[13-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$")]
        public string DateTravel { get; set; }
        [Display(Name = "Monto de Recarga")]
        [Required(ErrorMessage = "Please enter a date valid in format dd/mm/yyyy, ex: 31/12/2020")]
        [RegularExpression(@"^(0[0-9]|1[0-9]|2[0-3]):[0-5][0-9]$")]
        public string TimeTravel { get; set; }
    }
}