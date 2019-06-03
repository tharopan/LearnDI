using LearnDI.Payment.Models;
using System.Threading.Tasks;

namespace LearnDI.Payment
{
    public class PaypalPaymentService : IPaypalPaymentService
    {
        public async Task<PaymentResponseModel> Payment(PaymentModel payment)
        {
            return new PaymentResponseModel()
            {
                SuccessMessage = "paupal payment has been success!"
            };
        }
    }
}
