using System.Collections.Generic;
using System.Threading.Tasks;
using Flurl.Http;
using Newtonsoft.Json;

namespace ClientsUiApi
{
    public class TransactionsGetter
    {
        public async Task<IList<Transaction>> GetTableOfAccount()
        {
            var transactions = await "https://localhost:7097/transactions/all".GetStringAsync();

            var data = JsonConvert.DeserializeObject<IList<Transaction>>(transactions);

            return data;
        }
    }
}