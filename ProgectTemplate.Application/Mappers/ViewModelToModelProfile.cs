using AutoMapper;
using ProgectTemplate.Application.ViewModel;
using ProgectTemplate.Business.Entity.Table;

namespace ProgectTemplate.Application
{
    public class ViewModelToModelProfile :Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToModelProfile"; }
        }
        protected override void Configure()
        {
            Mapper.CreateMap<WUserViewModel, WUser>();
        }
    }
}