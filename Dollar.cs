namespace TDDMoney.Tests
{
    public class Dollar
    {
        public Dollar(int amount)
        {
            Amount = amount;
        }

        public int Amount { get; private set; }

        public void Times(int multiplier)
        {
            Amount *= multiplier;
        }
    }
}