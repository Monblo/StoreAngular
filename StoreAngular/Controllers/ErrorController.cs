using Microsoft.AspNetCore.Mvc;
using StoreAngular.Errors;

namespace StoreAngular.Controllers
{
    [Route("errors/{code}")]
    public class ErrorController : BaseApiController
    {
        public IActionResult Error(int code)
        {
            return new ObjectResult(new ApiResponse(code));
        }
    }
}
