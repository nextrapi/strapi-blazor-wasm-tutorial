using System.ComponentModel.DataAnnotations;
public class LoginFormState
{
    [Required]
    public string? identifier { get; set; }
    [Required]
    public string? password { get; set; }
}