using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._8
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class account
    {
        private decimal _balance;
        public decimal balance
        {
            get
            {
                return balance;
            }
            private set
            {
                value = balance;
            }
        }
        public account(decimal initialBalance)
        {
            if (initialBalance < 0)
            {
                throw new ArgumentException("We need a balance greater than or equal to zero");
            }
            _balance = initialBalance;
        }
        virtual public bool credit(decimal amount)
        {
            _balance += amount;
            return true;
        }
        virtual public bool debit(decimal amount)
        {
            if (amount > _balance)
            {
                throw new ArgumentException("Debit amount exceeded account balance");
            }
            _balance -= amount;
            return true;
        }
    }
    class savingsAccount : account
    {
        private decimal _interestRate;
        public decimal interestRate
        {
            get
            {
                return _interestRate;
            }
            private set
            {
                _interestRate = value;
            }
        }
        public savingsAccount(decimal initialBalance, decimal initialIntrestRate):base(initialBalance)
        {
            interestRate = initialIntrestRate;
        }
        public decimal calculateInterest()
        {
            return balance * interestRate;
        }
    }
    class checkingAccount : account
    {
        private decimal _feePerTransaction;
        public decimal feePerTransaction
        {
            get
            {
                return _feePerTransaction;
            }
            private set
            {
                _feePerTransaction = value;
            }
        }
        public checkingAccount(decimal initialBalance, decimal initialFeePerTransaction) : base(initialBalance)
        {
            feePerTransaction = initialFeePerTransaction;
        }
        public override bool credit(decimal amount)
        {
            return amount>feePerTransaction&&base.credit(amount-feePerTransaction);
        }
        public override bool debit(decimal amount)
        {
            try
            {
                return base.debit(amount+feePerTransaction);
            }
            catch (ArgumentException e)
            {
                return false;
            }
        }
    }
}
