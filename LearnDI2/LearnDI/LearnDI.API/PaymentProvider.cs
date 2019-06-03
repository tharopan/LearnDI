using LearnDI.Payment;

namespace LearnDI.API
{
    public class PaymentProvider
    {
        public IPaymentService PaymentService { get; set; }
        
        public PaymentProvider(int paymentType)
        {
            switch (paymentType)
            {
                case (int)PaymentType.Paypal:
                    {
                        PaymentService = new PaypalPaymentService();
                        break;
                    }
                case (int)PaymentType.Stripe:
                    {
                        PaymentService = new StripePaymentService();
                        break;
                    }
                default:
                    break;
            }
        }
    }
}
