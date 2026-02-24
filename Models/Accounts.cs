
namespace BankingAPI.Models
{
    // Request Class
    public class BalanceRequest
    {
        public string? transaction_reference { get; set; }
        public string? transaction_code { get; set; }
        public decimal amount { get; set; }
        public string? narration { get; set; }
        public string? phone_number { get; set; }
    }

    // Response Class
    public class BalanceResponse
    {
        public string? transaction_reference { get; set; }
        public string? transaction_code { get; set; }
        public decimal amount { get; set; }
        public string? phone_number { get; set; }
        public string? account_name { get; set; }
        public decimal actual_balance { get; set; }
        public decimal available_balance { get; set; }
    }
}