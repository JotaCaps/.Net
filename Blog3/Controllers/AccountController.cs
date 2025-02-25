using Blog.Services;
using Blog3.Data;
using Blog3.Extensions;
using Blog3.Models;
using Blog3.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Blog3.Controlers;


[ApiController]
public class AccountController : ControllerBase
{
    [HttpPost("v1/accounts")]
    public async Task<IActionResult> Post([FromBody]RegisterViewModel model, [FromServices] BlogDataContext context)
    {
        if(!ModelState.IsValid)
        return BadRequest(new ResultViewModel<string>(ModelState.GetErrors()));

       var user = new User
       {
        Name = model.Name ,
        Email = model.Email,
        Slug = model.Email.Replace("@", "-").Replace(".", "-")
       } 
    }

    [HttpPost("v1/accounts/login")]
    public IActionResult Login([FromServices]TokenService tokenService)
    {
        var token = tokenService.GenerateToken(null);

        return Ok(token);
    }

}