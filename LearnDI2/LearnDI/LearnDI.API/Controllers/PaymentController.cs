using LearnDI.Payment.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LearnDI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {        
        [HttpPost]
        public async Task<PaymentResponseModel> Pay(
            int type, 
            [FromBody]PaymentModel paymentModel
            )
        {
            PaymentProvider paymentProvider = new PaymentProvider(type);
            return await paymentProvider.PaymentService.Payment(paymentModel);
        }
    }
}
