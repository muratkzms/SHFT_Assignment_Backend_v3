using Data.Abstract;
using Data.Concrete.Entityframework.Contexts;
using Data.Concrete.Entityframework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AssignmentDbContext _assignmentDbContext;
        private EfClientRepository _clientRepository;
        private EfDietplanRepository _dietplanRepository;
        private EfMealRepository _mealRepository;

        public UnitOfWork(AssignmentDbContext assignmentDbContext)
        {
            _assignmentDbContext = assignmentDbContext;
        }


        public IClientRepository Clients => _clientRepository ?? new EfClientRepository(_assignmentDbContext);

        public IDietPlanRepository DietPlans => _dietplanRepository ?? new EfDietplanRepository(_assignmentDbContext);

        public IMealRepository Meals => _mealRepository ?? new EfMealRepository(_assignmentDbContext);

        public async ValueTask DisposeAsync()
        {
            await _assignmentDbContext.DisposeAsync();
        }

        public async Task<int> SaveAsync()
        {
            return await _assignmentDbContext.SaveChangesAsync();
        }
    }
}
