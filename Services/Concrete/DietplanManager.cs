using AutoMapper;
using Data.Abstract;
using Entities.Concrete;
using Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Concrete
{
    public class DietplanManager : ManagerBase, IDietplanService
    {
        public DietplanManager(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task AddAsync(DietPlan dietPlan)
        {
            await UnitOfWork.DietPlans.AddAsync(dietPlan);
            await UnitOfWork.SaveAsync();
        }

        public async Task<int> CountAsync()
        {
            var dietplanCount = await UnitOfWork.DietPlans.CountAsync();
            return dietplanCount > -1 ? dietplanCount : -1;
        }

        public async Task<IEnumerable<DietPlan?>> GetAllAsync()
        {
            return await UnitOfWork.DietPlans.GetAllAsync(includeProperties: "Meals");
        }

        public async Task<IEnumerable<DietPlan?>> GetAllByClientIdAsync(int clientId)
        {
            return await UnitOfWork.DietPlans.GetAllAsync(d => d.ClientId == clientId, includeProperties: "Meals");
        }

        public async Task<DietPlan> GetAsync(int id)
        {
            return await UnitOfWork.DietPlans.GetByIdAsync(id, includeProperties: "Meals");
        }

        public async Task HardDeleteAsync(int dietPlanId)
        {
            var dietPlan = await UnitOfWork.DietPlans.GetByIdAsync(dietPlanId, includeProperties: "Meals");
            foreach (var meal in dietPlan.Meals)
            {
                await UnitOfWork.Meals.DeleteAsync(meal.Id);
            }
            await UnitOfWork.DietPlans.DeleteAsync(dietPlanId);
            await UnitOfWork.SaveAsync();
        }

        public async Task UpdateAsync(DietPlan dietPlan)
        {
            await UnitOfWork.DietPlans.UpdateAsync(dietPlan);
            await UnitOfWork.SaveAsync();
        }
    }
}
