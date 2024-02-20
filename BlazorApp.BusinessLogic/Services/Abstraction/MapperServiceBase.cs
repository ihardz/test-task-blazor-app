using AutoMapper;

namespace BlazorApp.BusinessLogic.Services.Abstraction
{
    internal abstract class MapperServiceBase
    {
        protected IMapper Mapper { get; }

        protected MapperServiceBase(IMapper mapper)
        {
            Mapper = mapper;
        }
    }
}
