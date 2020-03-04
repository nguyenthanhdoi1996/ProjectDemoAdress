using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDemoAdress.Models
{
    public class Provinces
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public int ManageCode { get; set; }
        public int VnpostAreaCode { get; set; }
    }
}
