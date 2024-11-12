using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Stripe;
using Stripe.Checkout;
using WatchStoreApi.Dtos;

namespace WatchStoreApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PaymentController : ControllerBase
{
    public PaymentController()
    {
        StripeConfiguration.ApiKey =
            "sk_test_51QK8w5HKLuxQGaDRLWkE0WKacccyM4ydcQhlmBGEAVEKNKxCetzUJW7yCXr6yJ95BBSqbygp951cxqAPq0Wgm4oo00ZsUtyiBm";
    }

    [HttpPost("checkout")] 
    public ActionResult CreateCheckoutSession(IEnumerable<CartItemDto> cartItemDtos)
    {
        var lineItems = new List<SessionLineItemOptions>();
        foreach (var cartItemDto in cartItemDtos)
        {
            lineItems.Add(new SessionLineItemOptions
            {
                PriceData = new SessionLineItemPriceDataOptions
                {
                    UnitAmountDecimal = cartItemDto.Price * 100,
                    Currency = "bgn",
                    ProductData = new SessionLineItemPriceDataProductDataOptions
                    {
                        Name = cartItemDto.Name,
                    }
                },
                Quantity = cartItemDto.Quantity
            });
        }

        var options = new SessionCreateOptions
        {
            PaymentMethodTypes = new List<string>()
            {
              "card",  
            },
            LineItems = lineItems,
            Mode = "payment",
            SuccessUrl = "https://localhost:7252/OrderSuccessful",
            CancelUrl = "https://localhost:7252/Cart",
        };

        var service = new SessionService();
        Session session = service.Create(options);

        return Ok(session.Url);
    }
}