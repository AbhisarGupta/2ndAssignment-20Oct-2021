using System;

namespace Assignment2
{
    class q1
    {
        public double Interest(double bal)
        {
            bal += (bal * 1.5) / 100;
            return bal;
        }

        static void Main(string[] args)
        {
            double originalBal = 1000;
            q1 interest = new q1();
            double balAfterInterest = interest.Interest(originalBal);
            //Console.WriteLine(balAfterInterest);
            int monthlyPayment = 100;
            double balAfterPayment = balAfterInterest - monthlyPayment;
            int countPayments = 0;

            while (balAfterPayment >= 100)
            {              
                countPayments += 1;
                Console.WriteLine("Balance:" + balAfterPayment + "\ttotal  Payments:" + countPayments*100);
                double newInterest = interest.Interest(balAfterPayment);
                //Console.WriteLine(newInterest);
                
                balAfterPayment = newInterest - monthlyPayment;
                //Console.WriteLine(balAfterPayment);
            }

        }
    }
}
