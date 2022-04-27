using System.Collections.Generic;
using System.Threading.Tasks;
using Flurl.Http;
using Newtonsoft.Json;

namespace ClientsUiApi
{
    public class AccountsGetter
    {
        public async Task<IList<Account>> GetTableOfAccount()
        {
            var accounts = await "https://localhost:7097/accounts/all".GetStringAsync();

            var data = JsonConvert.DeserializeObject<IList<Account>>(accounts);

            return data;
        }
    }
}