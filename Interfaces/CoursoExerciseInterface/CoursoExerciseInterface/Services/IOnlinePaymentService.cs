using System;
using System.Collections.Generic;
using System.Text;

namespace CoursoExerciseInterface.Services
{
    interface IOnlinePaymentService
    {
        double PaymentFree(double amount);
        double Interest(double amount, int months);
    }
}
