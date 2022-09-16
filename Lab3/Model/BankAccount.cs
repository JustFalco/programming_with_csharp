using System;
namespace Lab3
{
    struct BankAccount
    {
        public string AcountNumber;
        public decimal Balance;
        public AccountType AccountType;

        public override string ToString()
        {
            return $"Account van het type {AccountType} heeft account nummer {AcountNumber} en een balans van {Balance}";
        }
    }
}

