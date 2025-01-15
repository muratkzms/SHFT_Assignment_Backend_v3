using Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Client:EntityBase,IEntity
    {
        public string Picture { get; set; }
        public string About { get; set; }
        public string Fullname { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<DietPlan>? DietPlans { get; set; } = new();
    }
}
