namespace PaystactIntegrationWithDotNet.Model
{
    public class Transaction
    {
        public int Id { get; set; }
        public string TxnId { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public int Amount { get; set; }
        public string TransactionReference { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; } = false;
        public DateTime TransactionDate { get; set; } = DateTime.UtcNow;
    }
}
