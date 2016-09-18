using System;


namespace _16._9._12___Chapter_4
{
    public class BankAccount
    {
        public uint AccountNumber { get; private set; }
        public string AccountHolder { get; private set; }
        public decimal Balance { get; private set; }
        public BankAccount(string Holder, decimal initialValue)
        {
            Random rnd = new Random();
            AccountNumber = (uint)rnd.Next(int.MinValue, int.MaxValue);//Sets it to a random Account Number
            AccountHolder = Holder;
            Balance = initialValue;
        }
        public BankAccount(uint AccNumber, string Holder, decimal initialValue)
        {
            AccountNumber = AccNumber;
            AccountHolder = Holder;
            Balance = initialValue;
        }
    }
}