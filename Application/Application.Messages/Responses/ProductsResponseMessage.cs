using System.Collections.Generic;
using System.Net.Http;

namespace Application.Messages.Responses
{
    public class ProductsResponseMessage : HttpResponseMessage
    {
        public IEnumerable<ProductMessage> Products { get; set; }
    }
}
