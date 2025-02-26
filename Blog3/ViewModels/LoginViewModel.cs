
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Blog3.ViewModels;

public class LoginViewModel
{
    [Required(ErrorMessage = "Informe o E-mail")]
    [EmailAddress(ErrorMessage = "E-mail inválido")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Informe a senha")]
    public string Password { get; set; }
    
}
