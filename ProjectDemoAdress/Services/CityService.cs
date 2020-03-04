using ProjectDemoAdress.Models;
using ProjectDemoAdress.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDemoAdress.Services
{
    public class CityService : ICity
    {
        private IRepository<Provinces> _repository;
        public CityService(IRepository<Provinces> repository)
        {
            _repository = repository;
        }
        public List<Provinces> getAll()
        {
            var reselt =  _repository.GetAll().ToList();
            return reselt;
        }
    }
}
