using AutoMapper;

namespace education.system.Services.Infrastructure.AutoMapper
{
    public interface IHaveCustomMapping
    {
        void ConfigureMapping(Profile mapper);
    }
}
