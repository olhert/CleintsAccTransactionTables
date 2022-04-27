using Microsoft.AspNetCore.Mvc;

namespace ClientsUiApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GetAccountsController : Controller
    {
        [HttpGet("/accounts")]
        public IActionResult AccountsTable()
        {
            var data = new AccountsGetter().GetTableOfAccount().Result;

            ViewBag.Accounts = data;
            return View();
        }
    }
}