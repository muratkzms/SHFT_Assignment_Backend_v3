using Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Meal : EntityBase, IEntity
    {
        public string Name { get; set; }
        public string Content { get; set; } = "Default Content Of a Meal";
        public TimeOnly MealTime { get; set; }=new TimeOnly(9,30);
        public int DietPlanId { get; set; } = 1;
        public DietPlan? DietPlan { get; set; }
    }
}
