using System.Net.Http;

namespace Application.Messages.Responses
{
    public class ProductResponseMessage : HttpResponseMessage
    {
        public ProductMessage Product { get; set; }
    }
}
