using System;

namespace BlazorApp.Server.Services.Abstraction
{
    public interface IUriResolver
    {
        Uri Order(int id);
    }
}
