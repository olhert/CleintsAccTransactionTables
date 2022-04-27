using System;

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
    
    public interface IAccount
    {
        string AccountId { get; set; }
        string ClientId { get; set; }
        string Currency { get; set; }
        double Balance { get; set; }
    }

    public class Account : IAccount
    {
        public string AccountId { get; set; }
        public string ClientId { get; set; }
        public string Currency { get; set; }
        public double Balance { get; set; }
    }
    
    public interface ITransactionModel
    {
        string SenderId { get; set; }
        string RecipientId { get; set; }
        double SumOfTransaction { get; set; }
        DateTime DateTime { get; set; }
    }

    public class Transaction : ITransactionModel
    {
        public string SenderId { get; set; }
        public string RecipientId { get; set; }
        public double SumOfTransaction { get; set; }
        public DateTime DateTime { get; set; }
    }
}