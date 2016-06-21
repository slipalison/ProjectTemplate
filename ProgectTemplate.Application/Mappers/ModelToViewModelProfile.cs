using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ProgectTemplate.Application.ViewModel;
using ProgectTemplate.Business.Entity.Table;

namespace ProgectTemplate.Application.Mappers
{
    public class ModelToViewModelProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ModelToViewModelProfile"; }
        }

        protected override void Configure() => Mapper.CreateMap<WUser, WUserViewModel>();
    }
}
