using BlazorApp.Server.Services.Abstraction;
using System;

namespace BlazorApp.Server.Services
{
    public class UriResolver : IUriResolver
    {
        public Uri Order(int id) => new Uri($"orders/{id}", UriKind.Relative);
        public Uri SubElement(int id) => new Uri(id.ToString(), UriKind.Relative);

        // todo: real recource url
        public Uri Window(int id) => new Uri(id.ToString(), UriKind.Relative);
    }
}
