using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace mdCard_MVC.Models
{
    public class Contact
    {
        [Required(ErrorMessage ="وارد کردن این فیلد الزامی است")]
        [MinLength(3,ErrorMessage ="حداقل طول نام 3 کاراکتر است")]
        [MaxLength(100,ErrorMessage ="حداکثر طول نام 100 کاراکتر است")]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage ="مقدار وارد شده ایمیل صحیح نیست")]
        [Required(ErrorMessage ="وارد کردن این فیلد الزامی است")]
        public string Email { get; set; }

        [NotNull]
        public string Service { get; set; }

        public string Message { get; set; }
    }
}
