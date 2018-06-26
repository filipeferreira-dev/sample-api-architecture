using Application.Messages.Responses;
using Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductApplicationService productApplicationService;

        public ProductController(IProductApplicationService productApplicationService)
        {
            this.productApplicationService = productApplicationService;
        }

        [Route("")]
        [HttpGet]
        public ProductListResponseMessage Get()
        {
            return productApplicationService.Get();
        }

        [Route("{id}")]
        [HttpGet]
        public async Task<ProductResponseMessage> GetByIdAsync(long id)
        {
            return await productApplicationService.GetByIdAsync(id);
        }

    }
}
