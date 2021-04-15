using System;
using System.Collections.Generic;
using System.Text;

namespace CoursoExerciseInterface.Services
{
    class PaypalService : IOnlinePaymentService
    {
        private const double FeePercentage = 0.02;
        private const double MonthlyInterest = 0.01;

        public double Interest(double amount, int months)
        {
            return amount * MonthlyInterest * months;
        }

        public double PaymentFree(double amount)
        {
            return amount * FeePercentage;
        }
    }
}
