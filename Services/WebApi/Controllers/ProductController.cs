using Application.Messages.Responses;
using Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductApplicationService productApplicationService;

        public ProductController(IProductApplicationService productApplicationService)
        {
            this.productApplicationService = productApplicationService;
        }


        [Route("")]
        [HttpGet]
        public ProductsResponseMessage Get()
        {
            return productApplicationService.Get();
        }
    }
}
