using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstract
{
    public interface IMealService
    {
        Task<Meal> GetAsync(int mealId);
        Task<IEnumerable<Meal?>> GetAllAsync();
        Task<IEnumerable<Meal?>> GetAllByDietplanIdAsync(int dietplanId);
        Task AddAsync(Meal meal);
        Task UpdateAsync(Meal meal);
        Task HardDeleteAsync(int mealId);
        Task<int> CountAsync();
    }
}
