using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDS.Models;

namespace BDS.Interface
{
    interface IHouseRepository : IRepository<House>
    {
        IQueryable<House> GetList(); 
    }
}
