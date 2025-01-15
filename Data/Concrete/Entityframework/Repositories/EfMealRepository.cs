using Data.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Shared.Data.Concrete.Entityframework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Concrete.Entityframework.Repositories
{
    public class EfMealRepository : EfEntityRepositoryBase<Meal>, IMealRepository
    {
        public EfMealRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
