namespace ClientsUiApi
{
    public interface IClient
    {
        string ClientId { get; set; }
        string Email { get; set; }
        string ClientName { get; set; }
        string Password { get; set; }
    }

    public class Client : IClient
    {
        public string ClientId { get; set; }
        public string Email { get; set; }
        public string ClientName { get; set; }
        public string Password { get; set; }
    }
}