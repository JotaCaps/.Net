using BookManagement.API.Models;
using BookManagement.API.Persistence;
using Microsoft.AspNetCore.Mvc;


namespace BookManagement.API.Controllers
{
    [ApiController]
    [Route("api/lendings")]
    public class LoanController : ControllerBase
    {
        private readonly BookManagementDbContext _context;

        public LoanController(BookManagementDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Post(RegisterLoanInputModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var lending = model.ToEntity();

            _context.Lendings.Add(lending);
            _context.SaveChanges();

            return Ok();
        }
    }
}
