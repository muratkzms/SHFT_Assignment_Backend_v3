using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Abstract
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IClientRepository Clients { get; }
        IDietPlanRepository DietPlans { get; }
        IMealRepository Meals { get; }
        Task<int> SaveAsync();
    }
}
