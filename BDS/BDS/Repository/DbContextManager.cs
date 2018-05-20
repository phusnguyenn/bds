using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BDS.Repository
{
    public static class DbContextManager
    {
        public static DbContext GetContext()
        {
            return new Database();
        }
    }
}