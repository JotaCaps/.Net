using BookManagement.API.Models;
using BookManagement.API.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace BookManagement.API.Controllers
{
    [ApiController]
    [Route("api/books")]
    public class UsersController : ControllerBase
    {
        private readonly BookManagementDbContext _context;

        public UsersController(BookManagementDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Post(RegisterUserInputModel model)
        {
            var user = model.ToEntity();

            _context.Users.Add(user);
            _context.SaveChanges();

            return Ok();
        }
    }
}
