using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BDS.Interface;
using BDS.Models;
using System.Data.Entity;


namespace BDS.Repository
{
    public class HouseRepository : BaseRepository<House>, IHouseRepository
    {
        public HouseRepository(DbContext context) : base(context)
        {

        }

        public override bool Delete(House house)
        {
            var entity = DbSet.FirstOrDefault(x => x.HouseId == house.HouseId);
            entity.Deleted = true;
            return Context.SaveChanges() > 0;
        }

        public IQueryable<House> GetList()
        {
            return this.DbSet.Where(p => p.Deleted != true);
        }
    }
}