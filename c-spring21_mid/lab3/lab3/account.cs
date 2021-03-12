using System;
namespace lab3
{
    public class account
    {
        public account()
        {
             private string accName;
        private string acid;
        private int balance;
        private int deposit;
        private int withdraw;

        public Account() { }

        public string AccName { get => accName; set => accName = value; }
        public string Acid { get => acid; set => acid = value; }
        public int Balance { get => balance; set => balance = value; }
        public int Deposit { get => deposit; set => deposit = value; }
        public int Withdraw { get => withdraw; set => withdraw = value; }

        public void showinfo()
        {
            Console.WriteLine("Account Name: " + accName);
            Console.WriteLine("Account ID: " + acid);
            Console.WriteLine("Deposit: " + deposit);
            Console.WriteLine("Withdraw: " + withdraw);
            Console.WriteLine("Balance: " + balance);
        }

    }
}
    }

