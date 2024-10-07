using MVCApp.Dtos;
using MVCApp.Models;
using System.ComponentModel.DataAnnotations;

namespace MVCApp.CustomValidation
{
    public class DateRangeValidation:ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            NewsCreateDto news = (NewsCreateDto)validationContext.ObjectInstance;

            if(news.StartDateTime > news.EndDateTime)
            {
                return new ValidationResult("起始日期不可大於結束日期");
            }

            return ValidationResult.Success;
        }
    }
}
