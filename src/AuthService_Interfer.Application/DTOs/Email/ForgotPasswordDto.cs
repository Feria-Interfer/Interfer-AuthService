using System.ComponentModel.DataAnnotations;

namespace AuthService_Interfer.Application.DTOs.Email;

public class ForgotPasswordDto
{
    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;
}