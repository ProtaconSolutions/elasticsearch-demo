using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet("api/account")]
        public string GetTest() 
        {
            return "jee";
        }
    }
}
