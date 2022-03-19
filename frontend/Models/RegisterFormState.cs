using System.ComponentModel.DataAnnotations;
public class RegisterFormState
{
    [Required]
    public string? email { get; set; }
    [Required]
    public string? username { get; set; }
    [Required]
    public string? password { get; set; }
}