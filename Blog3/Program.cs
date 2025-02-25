using System.ComponentModel;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Authentication.BearerToken;
using System.Text;
using Blog.Services;
using Blog3;
using Blog3.Data;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

var key = Encoding.UTF8.GetBytes(Configuration.JwtKey);
builder.Services.AddAuthentication( x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.DefaultAuthenticateScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.DefaultAuthenticateScheme;
}).AddJwtBearer( x => 
{
    x.TokenValidationParameter = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateIssuer = false,
        ValidateAudience = false
    };
});

builder.Services.AddControllers()
.ConfigureApiBehaviorOptions(options =>
{
    options.SuppressModelStateInvalidFilter = true;
});
builder.Services.AddDbContext<BlogDataContext>();
builder.Services.AddTransient<TokenService>();

var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();


app.MapControllers();


app.Run();
