using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstract
{
    public interface IDietplanService
    {
        Task<DietPlan> GetAsync(int id);
        Task<IEnumerable<DietPlan?>> GetAllAsync();
        Task<IEnumerable<DietPlan?>> GetAllByClientIdAsync(int clientId);
        Task AddAsync(DietPlan dietPlan);
        Task UpdateAsync(DietPlan dietPlan);
        Task HardDeleteAsync(int dietPlanId);
        Task<int> CountAsync();
    }
}
