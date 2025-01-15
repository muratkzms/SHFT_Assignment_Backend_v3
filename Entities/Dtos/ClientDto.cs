using Entities.Concrete;
using Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class ClientDto : DtoGetBase
    {
        public Client Client { get; set; }
    }
}
