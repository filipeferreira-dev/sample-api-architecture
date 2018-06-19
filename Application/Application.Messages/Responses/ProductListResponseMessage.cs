using System.Collections.Generic;
using System.Net.Http;

namespace Application.Messages.Responses
{
    public class ProductListResponseMessage : HttpResponseMessage
    {
        public IEnumerable<ProductMessage> Products { get; set; }
    }
}
