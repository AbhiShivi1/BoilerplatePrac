using System.ComponentModel.DataAnnotations;

namespace MYDEMOPROJ.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}