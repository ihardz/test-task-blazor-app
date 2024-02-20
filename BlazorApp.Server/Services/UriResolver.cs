using BlazorApp.Server.Services.Abstraction;
using System;

namespace BlazorApp.Server.Services
{
    public class UriResolver : IUriResolver
    {
        private Uri Orders => new Uri("Orders", UriKind.Relative);

        public Uri Order(int id) => new Uri(Orders, id.ToString());

        public Uri SubElement(int id) => new Uri(id.ToString(), UriKind.Relative);

        // todo: real recource url
        public Uri Window(int id) => new Uri(id.ToString(), UriKind.Relative);
    }
}
