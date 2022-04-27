using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Flurl.Http;
using Newtonsoft.Json;

namespace ClientsUiApi
{
    public class ClientsGetter
    {
        public async Task<IList<Client>> GetTableOfClients()
        {
            var clients = await "https://localhost:7097/clients/all".GetStringAsync();

            var data = JsonConvert.DeserializeObject<IList<Client>>(clients);

            return data;
        }
    }
}