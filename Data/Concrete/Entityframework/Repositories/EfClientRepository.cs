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
    public class EfClientRepository : EfEntityRepositoryBase<Client>, IClientRepository
    {
        public EfClientRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
