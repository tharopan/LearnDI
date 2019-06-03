using LearnDI.Payment.Models;
using System;
using System.Threading.Tasks;

namespace LearnDI.Payment
{
    public class StripePaymentService : IStripePaymentService
    {
        public async Task<PaymentResponseModel> Payment(PaymentModel payment)
        {
            return new PaymentResponseModel()
            {
                SuccessMessage = "Stripe payment has been success!"
            };
        }
    }
}
