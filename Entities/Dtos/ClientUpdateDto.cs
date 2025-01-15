using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class ClientUpdateDto
    {
        //todo: FluentValidation ugulanabilir
        public int Id { get; set; }
        public string Picture { get; set; }
        public string About { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}

//public string Picture { get; set; }
//public string About { get; set; }
//public string FirstName { get; set; }
//public string LastName { get; set; }
//public int Weight { get; set; }
//public int Height { get; set; }
//public DateTime DateOfBirth { get; set; }
//public ICollection<DietPlan> DietPlans { get; set; }
