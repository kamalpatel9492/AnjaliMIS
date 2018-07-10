using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnjaliMISDAL;
using AnjaliMISViewModal;
using AutoMapper;

namespace AnjaliMISRepository
{
    public class LOC_CountryRepository
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        private RepositoryBase<LOC_Country> _lOC_Country;

        public LOC_CountryRepository()
        {
            _lOC_Country = new RepositoryBase<LOC_Country>(unitOfWork._context);
        }

        public List<LOC_CountryViewModal> getallCountry()
        {

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<LOC_Country, LOC_CountryViewModal>();
            });

            IMapper mapper = config.CreateMapper();


            //Mapper.CreateMap<LOC_CountryViewModal, LOC_Country>();
            //var dbContext = new MyDBDataContext();
            //var userList = from user in dbContext.Users select user;
            //var users = new List<LearningMVC.Models.User>();
            //if (userList.Any())
            //{
            //    foreach (var user in userList)
            //    {
            //        LearningMVC.Models.User userModel =
            //          Mapper.Map<LearningMVC.User, LearningMVC.Models.User>(user);
            //        users.Add(userModel);
            //    }
            //}


            List<LOC_CountryViewModal> _Country =
            mapper.Map<List<LOC_Country>, List<LOC_CountryViewModal>>(_lOC_Country.GetAll().ToList());

            return _Country;
        }
    }
}
