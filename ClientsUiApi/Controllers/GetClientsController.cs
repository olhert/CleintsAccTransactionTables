using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Flurl;
using Flurl.Http;
using Flurl.Http.Configuration;
using Newtonsoft.Json;

namespace ClientsUiApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GetClientsController : Controller
    {
        [HttpGet("/clients")]
        public IActionResult ClientTable()
        {
            var data = new ClientsGetter().GetTableOfClients().Result;

            ViewBag.Clients = data;
            return View();
        }
    }
    
    public class UntrustedCertClientFactory : DefaultHttpClientFactory
    {
        public override HttpMessageHandler CreateMessageHandler() {
            return new HttpClientHandler {
                ServerCertificateCustomValidationCallback = (_, _, _, _) => true
            };
        }
    }
}