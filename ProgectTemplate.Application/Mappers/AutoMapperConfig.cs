using AutoMapper;
using ProgectTemplate.Application.Mappers;
using ProgectTemplate.Application.ViewModel;
using ProgectTemplate.Business.Entity.Table;

namespace ProgectTemplate.Application
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<ModelToViewModelProfile>();
                x.AddProfile<ViewModelToModelProfile>();
            });
        }
    }
}
