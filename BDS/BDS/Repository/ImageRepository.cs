using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BDS.Interface;
using BDS.Models;
using System.Data.Entity;

namespace BDS.Repository
{
    public class ImageRepository: BaseRepository<Image>, IHouseRepository
    {
        public ImageRepository(DbContext context) : base(context)
        {

        }

        public override bool Delete(Image image)
        {
            var entity = DbSet.FirstOrDefault(x => x.ImageId == image.ImageId);
            return Context.SaveChanges() > 0;
        }

        public IQueryable<Image> GetList()
        {
            return this.DbSet;
        }

        IQueryable<House> IHouseRepository.GetList()
        {
            throw new NotImplementedException();
        }

        public new IQueryable<House> GetAll()
        {
            throw new NotImplementedException();
        }

        public House SingleOrDefault(System.Linq.Expressions.Expression<Func<House, bool>> filter, params System.Linq.Expressions.Expression<Func<House, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public House FirstOrDefault(System.Linq.Expressions.Expression<Func<House, bool>> filter = null, params System.Linq.Expressions.Expression<Func<House, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<House> Find(System.Linq.Expressions.Expression<Func<House, bool>> filter, Func<IQueryable<House>, IOrderedQueryable<House>> orderBy, params System.Linq.Expressions.Expression<Func<House, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public bool Insert(House entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(House entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(House entity)
        {
            throw new NotImplementedException();
        }

        public bool Contains(System.Linq.Expressions.Expression<Func<House, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}