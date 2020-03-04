using ProjectDemoAdress.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDemoAdress.Services
{
    public interface ICity
    {
        List<Provinces> getAll();
    }
}
