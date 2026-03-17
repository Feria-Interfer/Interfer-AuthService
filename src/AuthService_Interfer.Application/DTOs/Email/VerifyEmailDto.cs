using System.ComponentModel.DataAnnotations;

namespace AuthService_Interfer.Application.DTOs.Email;

public class VerifyEmailDto
{
    [Required]
    public string Token { get; set; } = string.Empty;
}