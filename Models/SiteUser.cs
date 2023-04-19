using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class SiteUser
{
    public uint SiteUserId { get; set; }

    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = "";

    [Display(Name = "First Name")]
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";

    [DataType(DataType.Password)]
    public string Password { get; set; } = "";

    [NotMapped]
    [Compare("Password", ErrorMessage = "Passwords do not match")]
    [Display(Name = "Verify Password")]
    [DataType(DataType.Password)]
    public string PasswordVerify { get; set; } = "";

    [Display(Name = "Mailing Address")]
    public string MailingAddress { get; set; } = "";
}