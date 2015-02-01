namespace Bank
{
    public interface IAccount
    {
        Customers Customer { get; set; }
        decimal Balance { get; }
        decimal InterestRate { get; set; }
        decimal CalculateInterest(int months);
        void Deposit(decimal amount);
    }
}
