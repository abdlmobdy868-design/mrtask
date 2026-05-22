using static ConsoleApp_maintasks.Account.SavingsAccount;

namespace ConsoleApp_maintasks
{
    public class Account
    {
        public string Name { get; set; }
        public double Balance { get; set; }

        public Account(string name = "Unnamed Account", double balance = 550)
        {
            this.Name = name;
            this.Balance = balance;
        }

        public bool Deposit(double amont)
        {
            if (amont < 0)
                return false;
            else
            {
                Balance += amont;
                return true;
            }
        }

        public virtual bool Withdraw(double amont)
        {
            if (amont < 0 || amont > Balance)
                return false;
            else
            {
                Balance -= amont;
                return true;
            }
        }

        public class SavingsAccount : Account
        {
            public double InterestRate { get; set; }
            public SavingsAccount(string name = "Unnamed Savings Account", double balance = 0, double interestRate = 0.0) : base(name, balance)

            {
                this.InterestRate = interestRate;
            }
            public class CheckingAccount : Account
            {
                private double Witdfe;
                public CheckingAccount(string name = "Unnamed Checking Account", double balance = 0, double overdraftLimit = 0.0) : base(name, balance)
                {
                    this.Witdfe = overdraftLimit;
                }
                public override bool Withdraw(double amont)
                {
                    if ((amont >= Balance*0.2))
                    return base.Withdraw(amont);
                    return false;
                }
            }

            public class TrusAcont : Account
            {
                public double InterestRate { get; set; }
                private double BonAmint=40;
                private double BON=500;
                public TrusAcont(string name = "Unnamed Trust Account", double balance = 0, double withdrawLimit = 0.0) : base(name, balance)
                {
                    this.InterestRate = withdrawLimit;
                }
                public virtual bool Deposit(double amont)
                {
                    if (amont >= BON)  
                        amont += BonAmint;
                    return base.Deposit(amont);

                   
                }
                public override bool Withdraw(double amont)
                {
                    if (amont > BON) return base.Withdraw(amont);
                    return false;
                }


            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {

                Account account = new Account();
                account.Deposit(100);
                account.Withdraw(50);
                Console.WriteLine($"Account: {account.Name}, Balance: {account.Balance}");

                SavingsAccount savingsAccount = new SavingsAccount("my acont", 1000, 0.05);
                savingsAccount.Deposit(100);
                savingsAccount.Withdraw(200);
                Console.WriteLine($"Savings Account: {savingsAccount.Name}, Balance: {savingsAccount.Balance}");

                CheckingAccount checkingAccount = new CheckingAccount("my check", 500, 100);
                checkingAccount.Deposit(100);
                checkingAccount.Withdraw(550);
                Console.WriteLine( $"Checking Account: {checkingAccount.Name}, Balance: {checkingAccount.Balance}");

                TrusAcont trustAccount = new TrusAcont("my trust", 2000, 0.03);
                trustAccount.Deposit(100);
                trustAccount.Withdraw(200);
                Console.WriteLine($"Trust Account: {trustAccount.Name}, Balance: {trustAccount.Balance}");
                
                Console.ReadKey();
                
            }


        }
    }
}


