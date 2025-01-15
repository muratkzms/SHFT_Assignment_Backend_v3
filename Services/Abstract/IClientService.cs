using Entities.Concrete;
using Entities.Dtos;
using Shared.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstract
{
    public interface IClientService
    {
        Task<Client> GetAsync(int id);
        Task<IEnumerable<Client?>> GetAllAsync();
        Task AddAsync(Client client);
        Task UpdateAsync(Client client);
        Task HardDeleteAsync(int clientId);
        Task<int> CountAsync();
    }
}
