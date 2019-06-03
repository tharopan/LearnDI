using LearnDI.Payment.Models;
using System.Threading.Tasks;

namespace LearnDI.Payment
{
    public interface IPaymentService
    {
        Task<PaymentResponseModel> Payment(PaymentModel payment);
    }
}
