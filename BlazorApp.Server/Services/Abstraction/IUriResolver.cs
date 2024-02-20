using System;

namespace BlazorApp.Server.Services.Abstraction
{
    public interface IUriResolver
    {
        Uri Order(int id);
        Uri Window(int id);
        Uri SubElement(int id);
    }
}
