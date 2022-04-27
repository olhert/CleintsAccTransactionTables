using Microsoft.AspNetCore.Mvc;

namespace ClientsUiApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GetTransactionsController : Controller
    {
        [HttpGet("/transactions")]
        public IActionResult TransactionsTable()
        {
            var data = new TransactionsGetter().GetTableOfAccount().Result;

            ViewBag.Transactions = data;
            return View();
        }
    }
}