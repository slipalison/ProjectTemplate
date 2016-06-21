using System;
using ProgectTemplate.Application.Interfaces;
using ProgectTemplate.Business.Entity.Table;
using ProgectTemplate.Business.Interfaces.Repository.Table;
using ProgectTemplate.Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;
using ProgectTemplate.Application.ViewModel;
using AutoMapper;

namespace ProgectTemplate.Application.Service
{
    public class WUserAppService : ApplicationService, IWUserAppService
    {
        private readonly IUnitOfWork _uow;
        private readonly IWUserRepository _userRepository;
        public WUserAppService(IUnitOfWork uow, IWUserRepository userRepository) : base(uow)
        {
            _uow = uow;
            _userRepository = userRepository;

        }

        public void Dispose()
        {
            _userRepository.Dispose();
            GC.SuppressFinalize(this);
        }

        public IEnumerable<WUserViewModel> GetAll()
        {
            _uow.BeginTransaction();
            var result = _userRepository.GetAll();
            var t = Mapper.Map<IEnumerable<WUser>, List<WUserViewModel>>(result);
            _uow.Commit();
           // Dispose();
            return t;
        }


    }
}
