using System.ComponentModel.DataAnnotations;

namespace AdminLTE.Models.CmsViewModels
{
    public class CmsIndexViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
