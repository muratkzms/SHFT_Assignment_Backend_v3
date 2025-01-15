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
    public class MealManager : ManagerBase, IMealService
    {
        public MealManager(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task AddAsync(Meal meal)
        {
            await UnitOfWork.Meals.AddAsync(meal);
            await UnitOfWork.SaveAsync();
        }

        public async Task<int> CountAsync()
        {
            var mealsCount = await UnitOfWork.Meals.CountAsync();
            return mealsCount > -1 ? mealsCount : -1;
        }

        public async Task<IEnumerable<Meal?>> GetAllAsync()
        {
            return await UnitOfWork.Meals.GetAllAsync();
        }

        public async Task<IEnumerable<Meal?>> GetAllByDietplanIdAsync(int dietplanId)
        {
            return await UnitOfWork.Meals.GetAllAsync(m => m.DietPlanId == dietplanId);
        }

        public async Task<Meal> GetAsync(int mealId)
        {
            return await UnitOfWork.Meals.GetByIdAsync(mealId);
        }

        public async Task HardDeleteAsync(int mealId)
        {
            await UnitOfWork.Meals.DeleteAsync(mealId);
            await UnitOfWork.SaveAsync();
        }

        public async Task UpdateAsync(Meal meal)
        {
            await UnitOfWork.Meals.UpdateAsync(meal);
            await UnitOfWork.SaveAsync();
        }
    }
}
