using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace WatchAPi.Controllers;

[ApiController]
[Route("[controller]")]
public class WatchController : ControllerBase
{

    private readonly ILogger<WatchController> _logger;

    public WatchController(ILogger<WatchController> logger)
    {
        _logger = logger;
    }

    [HttpPost("GetCheckoutTotal")]
    public CheckoutTotalResponse GetCheckoutTotal(int[] watchIds)
    {
        CheckoutTotalResponse response = new CheckoutTotalResponse(); 
        int price;

        price = WatchApiHelper.CheckoutTotal(watchIds);

        response.Price = price; 
        return response; 
    }
}
