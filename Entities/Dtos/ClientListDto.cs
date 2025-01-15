using Entities.Concrete;
using Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class ClientListDto:DtoGetBase
    {
        public IList<Client> Clients { get; set; }
    }
}
