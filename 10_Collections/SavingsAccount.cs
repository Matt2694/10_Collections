using System;

namespace _10_Collections{

    class SavingsAccount : IAsset{

        public double Value { get; set; }
        public double InterestRate { get; set; }
        public string Account { get; set; }

        public SavingsAccount() { }

        public SavingsAccount(string account, double value, double interestRate){

            Account = account;
            Value = value;
            InterestRate = interestRate;
        }

        public double GetValue(){

            return Value;
        }

        internal void ApplyInterest(){

            Value += Value * (InterestRate / 100);
        }

        public override string ToString(){

            return string.Format("SavingsAccount[value={0:0.0},interestRate={1:0.0}]", Value, InterestRate);
        }

        public string GetName(){

            return Account;
        }
    }
}
