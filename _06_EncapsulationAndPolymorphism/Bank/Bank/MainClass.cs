namespace Bank
{
    using System;

    public class MainClass
    {
        public static void Main()
        {
            DepositAccount kiro = new DepositAccount(Customers.Individual, 1000m, 5);
            Console.WriteLine(kiro.CalculateInterest(10) + "\n");

            LoanAccount pesho = new LoanAccount(Customers.Individual, 1500m, 3);
            Console.WriteLine(pesho.CalculateInterest(12) + "\n");

            LoanAccount maglaOOD = new LoanAccount(Customers.Company, 1500m, 3);
            Console.WriteLine(maglaOOD.CalculateInterest(12) + "\n");

            MortgageAccount penka = new MortgageAccount(Customers.Individual, 50000m, 2);
            Console.WriteLine(penka.CalculateInterest(8) + "\n");

            MortgageAccount shadyAD = new MortgageAccount(Customers.Company, 250000m, 5);
            Console.WriteLine(penka.CalculateInterest(12) + "\n");

            MortgageAccount shadyOOD = new MortgageAccount(Customers.Company, 250000m, 5);
            Console.WriteLine(penka.CalculateInterest(24) + "\n");
        }
    }
}
