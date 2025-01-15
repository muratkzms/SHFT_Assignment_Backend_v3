using AutoMapper;
using Data.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using Services.Abstract;
using Shared.Utilities.Results.Abstract;
using Shared.Utilities.Results.ComplexTypes;
using Shared.Utilities.Results.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Concrete
{
    public class ClientManager : ManagerBase, IClientService
    {
        public ClientManager(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task AddAsync(Client client)
        {
            await UnitOfWork.Clients.AddAsync(client);
            await UnitOfWork.SaveAsync();
        }

        public async Task UpdateAsync(Client client)
        {
            foreach (var dietPlan in client.DietPlans)
            {
                foreach (var meal in dietPlan.Meals)
                {
                    await UnitOfWork.Meals.UpdateAsync(meal);
                }
                await UnitOfWork.DietPlans.UpdateAsync(dietPlan);
            }
            await UnitOfWork.Clients.UpdateAsync(client);
            await UnitOfWork.SaveAsync();
        }

        public async Task<IEnumerable<Client?>> GetAllAsync()
        {
            return await UnitOfWork.Clients.GetAllAsync(includeProperties: "DietPlans.Meals");
        }
        public async Task HardDeleteAsync(int clientId)
        {
            var client = await UnitOfWork.Clients.GetByIdAsync(clientId, includeProperties: "DietPlans.Meals");
            if (client != null && client.DietPlans != null)
            {
                foreach (var dietPlan in client.DietPlans)
                {
                    if (dietPlan.Meals != null)
                    {
                        foreach (var meal in dietPlan.Meals)
                        {
                            await UnitOfWork.Meals.DeleteAsync(meal.Id);
                        }
                    }
                    await UnitOfWork.DietPlans.DeleteAsync(dietPlan.Id);
                }
            }
            await UnitOfWork.Clients.DeleteAsync(clientId);
            await UnitOfWork.SaveAsync();
        }

        public async Task<Client> GetAsync(int id)
        {
            return await UnitOfWork.Clients.GetByIdAsync(id, includeProperties: "DietPlans.Meals");
        }

        public async Task<int> CountAsync()
        {
            var clientCount = await UnitOfWork.Clients.CountAsync();
            return clientCount > -1 ? clientCount : -1;
        }
    }
}
