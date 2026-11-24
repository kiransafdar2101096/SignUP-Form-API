using Form_Api.Data;
using Form_Api.Model;
using Microsoft.AspNetCore.Mvc;

namespace Form_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SignupFormsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SignupFormsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult CreateSignup(Signupform signup)
        {
            _context.signupforms.Add(signup);
            _context.SaveChanges();

            return Ok("Signup successfully saved!");
        }

    }
}
