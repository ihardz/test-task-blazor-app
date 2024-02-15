using BlazorApp.Server.Services.Abstraction;
using System;

namespace BlazorApp.Server.Services
{
    public class UriResolver : IUriResolver
    {
        private Uri Orders => new Uri("Orders", UriKind.Relative);

        public Uri Order(int id)
        {
            return new Uri(Orders, id.ToString());
        }
    }
}
